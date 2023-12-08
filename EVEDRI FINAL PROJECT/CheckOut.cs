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

namespace EVEDRI_FINAL_PROJECT
{
    public partial class CheckOut : Form
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

        public CheckOut()
        {
            InitializeComponent();
        }

        public int selectedIndex { get; set; }
        //database injection

        DataClasses1DataContext _data = new DataClasses1DataContext();

        private void CheckOut_Load(object sender, EventArgs e)
        {
           /* refresh_Data();*/
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));
            btn_back.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_back.Width, btn_back.Height, 20, 20));
            btn_done.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_done.Width, btn_done.Height, 20, 20));
            cmb_Type.DropDownStyle = ComboBoxStyle.DropDownList;
            btn_setAvailable.Visible = false;
          
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            this.Close();
            d.Show();
        }

        void refresh_Data()
        {
            cmb_Type.SelectedIndex = 0;
            dgv_CheckOutSettlement.DataSource = _data.SP_user_checkOutView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh_Data();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        //messagebox
        public void ID()
        {
            string title = "Notification";
            string message = "Please input the Guest ID";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Success()
        {
            string title = "Notification";
            string message = "Update Successfully";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Not_Found()
        {
            string title = "Notification";
            string message = "Guest ID is not available";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Input_Id()
        {
            string title = "Notification";
            string message = "Please input the Guest ID";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btn_done_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ID.Text))
            {
                Input_Id();
            }
            else
            {
                try
                {
                    var FindID = _data.tbl_Guests
                                                        .FirstOrDefault(id => id.Guest_Id == Convert.ToInt32(txt_ID.Text));

                    if (string.IsNullOrWhiteSpace(txt_ID.Text))
                    {
                        ID();
                    }
                    else if (FindID != null)
                    {
                        Success();
                        _data.SP_user_SettleMent(Convert.ToInt32(txt_ID.Text));
                    }
                    else
                    {
                        Not_Found();
                    }
                }
                catch
                {
                    Not_Found();
                }
             
            }
        }
            private void label2_Click(object sender, EventArgs e)
            {
                
            }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      e.KeyChar != '.')
            {
                e.Handled = true; // Ignore the key press
            }
        }

        private void cmb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = cmb_Type.SelectedIndex;
            if(SelectedIndex == 0)
            {
        
                refresh_Data();
                btn_done.Visible = true;
                

            }
            else 
            {
               
                btn_done.Visible = false;
                btn_setAvailable.Visible = true;
                dgv_CheckOutSettlement.DataSource = _data.SP_user_ViewForClean();
            }
         
        }

        private void btn_setAvailable_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ID.Text))
            {
                Input_Id();
            }
            else
            {
                try
                {
                    var FindID = _data.tbl_Guests
                                      .FirstOrDefault(id => id.Guest_Id == Convert.ToInt32(txt_ID.Text));

                    if (string.IsNullOrWhiteSpace(txt_ID.Text))
                    {
                        ID();
                    }
                    else if (FindID != null)
                    {
                        Success();
                        _data.SP_user_CleanSettleMent(Convert.ToInt32(txt_ID.Text));
                    }
                    else
                    {
                        Not_Found();
                    }
                }
                catch
                {
                    Not_Found();
                }
               
            }
        }
    }
    }

