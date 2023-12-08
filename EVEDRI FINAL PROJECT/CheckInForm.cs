using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EVEDRI_FINAL_PROJECT
{
    public partial class CheckInForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
               int nLeft,
               int nTop,
               int nRight,
               int nBottom,
               int nWidthEllipse,
               int nHeightEllipse
           );
        public int ID { get; set; }

        const int minLength = 11; // Minimum length required

        public CheckInForm()
        {
            InitializeComponent();
        }

        //database injection

        DataClasses1DataContext _data = new DataClasses1DataContext();

        private void btn_next_Click(object sender, EventArgs e)
        {
            CheckTextboxes();
        }
        void CheckTextboxes()
        {
            if (string.IsNullOrWhiteSpace(txt_fname.Text) || string.IsNullOrWhiteSpace(txt_lname.Text) || string.IsNullOrWhiteSpace(txt_phone.Text) || string.IsNullOrWhiteSpace(txt_email.Text))
            {
                fill_out();
            }
            else
            {
                //for txtphone
                  
                if (txt_phone.Text.Length < minLength)
                {

                    Phone_Invalid();
                }
                else
                {
                    //passing of data into gusst table
                    _data.SP_User_Craete_Guest(txt_fname.Text, txt_lname.Text, txt_phone.Text, txt_email.Text);

                    var getID = _data.tbl_Guests
                                .FirstOrDefault(g => g.firstName == txt_fname.Text && g.lastName == txt_lname.Text && g.phoneNumber == txt_phone.Text && g.email == txt_email.Text);


                    if (getID != null)
                    {
                        CheckIn2 c2 = new CheckIn2();
                        c2.guestID = getID.Guest_Id;
                        c2.Show();
                        this.Hide();
                    }
                    else
                    {
                        Not_Found();
                    }
                }

            }
        }

        //message
        public void fill_out()
        {
            string title = "Notification";
            string message = "Please fill the form completely";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void input_Id()
        {
            string title = "Notification";
            string message = "Please input a customer ID";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Phone_Invalid()
        {
            string title = "Notification";
            string message = $"Minimum length of Phone number is: {minLength} characters.";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public void Not_Found()
        {
            string title = "Notification";
            string message = "Customer Info is not available in database";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Text_Error()
        {
            string title = "Notification";
            string message = "Text or character is not allowed";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lnk_guestId_Click(object sender, EventArgs e)
        {
            pnl_guestID.Visible = true;

            txt_fname.Enabled = false;
            txt_lname.Enabled = false;
            txt_phone.Enabled = false;
            txt_email.Enabled = false;
            btn_next.Enabled = false;
        }

        private void lnk_guestId_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void CheckInForm_Load(object sender, EventArgs e)
        {
            btn_back.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_back.Width, btn_back.Height, 20, 20));
            btn_next.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_next.Width, btn_next.Height, 20, 20));
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_guestID.Text = null;
            pnl_guestID.Visible = false;

            txt_fname.Enabled = true;
            txt_lname.Enabled = true;
            txt_phone.Enabled = true;
            txt_email.Enabled = true;
            btn_next.Enabled = true;
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            try
            {

                if (String.IsNullOrWhiteSpace(txt_guestID.Text))
                {
                    input_Id();
                }

                else
                {
                    var getID = _data.tbl_Guests
                     .FirstOrDefault(g => g.Guest_Id == Convert.ToInt32(txt_guestID.Text));
   
                    if (getID == null)
                    {

                        Not_Found();
                    }
                    else
                    {
                        CheckIn2 c2 = new CheckIn2();
                        c2.guestID = getID.Guest_Id;
                        c2.Show();
                        this.Hide();
                    }
                }
            }
            catch
            {
                Text_Error();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Dashboard ck = new Dashboard();
            this.Close();
            ck.Show();
        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
          e.KeyChar != '.')
            {
                e.Handled = true; // Ignore the key press
            }
        }
    }
}

