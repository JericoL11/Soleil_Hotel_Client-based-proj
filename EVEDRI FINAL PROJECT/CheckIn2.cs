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
    public partial class CheckIn2 : Form
    {


        //id reciever

        //limit, no advance booking


        public int guestID { get; set; }
        public double total_payment { get; set; }
        public double payment { get; set; }
        public double StayIn_days { get; set; }


        double zero = 0;

        public string roomType { get; set; }
      /*  public string numberOfGuest { get; set; }*/

        //dateTime default 
        DateTime Today = DateTime.Now;


        //Database Injection
        DataClasses1DataContext _data = new DataClasses1DataContext();

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

        public CheckIn2()
        {
            InitializeComponent();
        }

       
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        void Cash_Elements_False()
        {
            //hiding of cash elements
            btn_amount.Visible = false;
            lbl_CoH.Visible = false;
            txt_cashOnHand.Visible = false;

        }
        void Cash_Elements_True()
        {
            //hiding of cash elements
            btn_amount.Visible = true;
            lbl_CoH.Visible = true;
            txt_cashOnHand.Visible = true;

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            cmb_roomNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_numGuest.DropDownStyle = ComboBoxStyle.DropDownList;
            dtp_checkin.Enabled = false;

            //hiding of amount methods

           Cash_Elements_False();

            pnl_credit.Visible = false; 

            lbl_guest_Id.Text = guestID.ToString();

            lbl_payment.Text = zero.ToString("C");

            btn_back.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_back.Width, btn_back.Height, 20, 20));
            btn_submit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_submit.Width, btn_submit.Height, 20, 20));
            btn_amount.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_amount.Width, btn_amount.Height, 20, 20));
        }

        private void rbtn_standard_Click(object sender, EventArgs e)
        {
            txt_cashOnHand.Text = null;
            cmb_numGuest.Items.Clear();
            cmb_numGuest.Text = "----------";

            cmb_roomNumber.Items.Clear();
            cmb_roomNumber.Text = "----------";

            cmb_numGuest.Items.Add("1");   
            cmb_numGuest.Items.Add("2");

            cmb_roomNumber.Items.Add("101");
            cmb_roomNumber.Items.Add("102");
            cmb_roomNumber.Items.Add("103");

            //assigning of payment
            payment = 699.00;

            total_payment = payment * StayIn_days;
            lbl_payment.Text = total_payment.ToString("C");
            roomType = "Standard Room";


        }

        private void rbtn_family_Click(object sender, EventArgs e)
        {
          

            txt_cashOnHand.Text = null;
            cmb_numGuest.Items.Clear();
            cmb_numGuest.Text = "----------";

            cmb_roomNumber.Items.Clear();
            cmb_roomNumber.Text = "----------";


            cmb_numGuest.Items.Add("1");
            cmb_numGuest.Items.Add("2");
            cmb_numGuest.Items.Add("3");
            cmb_numGuest.Items.Add("4");

      
            cmb_roomNumber.Items.Add("201");
            cmb_roomNumber.Items.Add("202");
            cmb_roomNumber.Items.Add("203");
            //assigning of payment


            payment = 1100.00 * StayIn_days;
            total_payment = payment * StayIn_days;
            lbl_payment.Text = total_payment.ToString("C");
            roomType = "Family Room";
        }

        private void rbtn_Private_Click(object sender, EventArgs e)
        {
          
            txt_cashOnHand.Text = null;
            cmb_numGuest.Items.Clear();
            cmb_numGuest.Text = "----------";

            cmb_roomNumber.Items.Clear();
            cmb_roomNumber.Text = "----------";


            cmb_numGuest.Items.Add("1");
            cmb_numGuest.Items.Add("2");
            cmb_numGuest.Items.Add("3");

            cmb_roomNumber.Items.Add("301");
            cmb_roomNumber.Items.Add("302");
            cmb_roomNumber.Items.Add("303");

            payment = 1450;

            total_payment = payment * StayIn_days;
            lbl_payment.Text = total_payment.ToString("C");
            roomType = "Private Room";
        }

        private void rbtn_mixdoom_Click(object sender, EventArgs e)
        {
        
            txt_cashOnHand.Text = null;
            cmb_numGuest.Items.Clear();
            cmb_numGuest.Text = "----------";

            cmb_roomNumber.Items.Clear();
            cmb_roomNumber.Text = "----------";


            cmb_numGuest.Items.Add("1");
            cmb_numGuest.Items.Add("2");
            cmb_numGuest.Items.Add("3");
            cmb_numGuest.Items.Add("4");
            cmb_numGuest.Items.Add("5");
            cmb_numGuest.Items.Add("6");

            cmb_roomNumber.Items.Add("401");
            cmb_roomNumber.Items.Add("402");
            cmb_roomNumber.Items.Add("403");

            payment = 1500;

            total_payment = payment * StayIn_days;
            lbl_payment.Text = total_payment.ToString("C");
            roomType = "Mix Doom";
        }

        private void rbtn_femaleDoom_Click(object sender, EventArgs e)
        {
        
            txt_cashOnHand.Text = null;
            cmb_numGuest.Items.Clear();
            cmb_numGuest.Text = "----------";

            cmb_roomNumber.Items.Clear();
            cmb_roomNumber.Text = "----------";


            cmb_numGuest.Items.Add("1");
            cmb_numGuest.Items.Add("2");
            cmb_numGuest.Items.Add("3");
            cmb_numGuest.Items.Add("4");
            cmb_numGuest.Items.Add("5");
            cmb_numGuest.Items.Add("6");

            cmb_roomNumber.Items.Add("501");
            cmb_roomNumber.Items.Add("502");
            cmb_roomNumber.Items.Add("503");

            payment = 1150;

            total_payment = payment * StayIn_days;
            lbl_payment.Text = total_payment.ToString("C");
            roomType = "Female Doom";
        }

        private void rbtn_maleDoom_Click(object sender, EventArgs e)
        {
     
            txt_cashOnHand.Text = null;
            cmb_numGuest.Items.Clear();
            cmb_numGuest.Text = "----------";

            cmb_roomNumber.Items.Clear();
            cmb_roomNumber.Text = "----------";


            cmb_numGuest.Items.Add("1");
            cmb_numGuest.Items.Add("2");
            cmb_numGuest.Items.Add("3");
            cmb_numGuest.Items.Add("4");
            cmb_numGuest.Items.Add("5");
            cmb_numGuest.Items.Add("6");

            cmb_roomNumber.Items.Add("601");
            cmb_roomNumber.Items.Add("602");
            cmb_roomNumber.Items.Add("603");

            payment = 1100;

            total_payment = payment * StayIn_days;
            lbl_payment.Text = total_payment.ToString("C");
            roomType = "Male Doom";
        }

        private void btn_amount_Click(object sender, EventArgs e)
        {
            
           if(lbl_payment.Text == zero.ToString("C"))
            {
                txt_cashOnHand.Text = null;
            }
            else
            {
                txt_cashOnHand.Text = total_payment.ToString("N");
            }
        
        }


        private void btn_submit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cmb_roomNumber.Text)||string.IsNullOrEmpty(cmb_numGuest.Text) || btn_amount.Text == "0")
            {
                Fill_out();
            }
            else if (string.IsNullOrWhiteSpace(txt_cashOnHand.Text))
            {
                    Enter_Amount();  
            }
            else
            {
                
                try
                {

                    var rm_check = _data.tbl_Guests.FirstOrDefault(r => r.RoomNo == cmb_roomNumber.Text && r.IsClean == "TBU");

                    var Cash =  Convert.ToDouble(txt_cashOnHand.Text);
               
                //if the payment is lees than the total payment
                if (Cash < total_payment)
                {
                    Invalid_Amount();
                }
            
                else
                {

                        if (rm_check != null)
                        {
                            cmb_roomNumber.Text = "----------";
                            Occupied();


                        }
                        else if (string.IsNullOrEmpty(cmb_roomNumber.Text))
                        {
                            Fill_out();
                        }
                        else
                        {
                            var data = _data.tbl_Guests
                           .FirstOrDefault(d => d.Guest_Id == guestID);

                            Receipt r = new Receipt();
                            //passing of data from database
                            r.guestId = guestID;
                            r.fname = data.firstName;
                            r.lname = data.lastName;
                            r.email = data.email;
                            r.phoneNumber = data.phoneNumber;
                            r.roomType = roomType;
                            r.numberGuest = Convert.ToInt32(cmb_numGuest.Text);
                            r.RoomNum = cmb_roomNumber.Text;
                            r.CheckIn = dtp_checkin.Value;
                            r.CheckOut = dtp_checkOut.Value;
                            r.totalPayment = total_payment;
                            r.numberDays = (int)StayIn_days;
                            r.cashOnhand = Convert.ToDouble(txt_cashOnHand.Text);

                            r.ShowDialog();
                        }
                    }
                   
                }
                catch
                {
                   Fill_out();
                }
             }
        }
  
        private void btn_back_Click(object sender, EventArgs e)
        {
            CheckInForm ck = new CheckInForm();
            this.Close();
            ck.Show();
        }

        public void Fill_out()
        {
            string title = "Notification";
            string message = "Please fill-out the form completely";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void Enter_Amount()
        {
            string title = "Notification";
            string message = "Please enter an Amount";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void Invalid_Amount()
        {
            string title = "Notification";
            string message = "Amount is below on the total payment";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void Invalid_Room()
        {
            string title = "Notification";
            string message = "Room Number is invalid";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void Invalid_Text()
        {
            string title = "Notification";
            string message = "Text or letters in cash on hand is invalid";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void Invalid_Days()
        {
            string title = "Notification";
            string message = "Number of day/s is invalid";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void Occupied()
        {
            string title = "Notification";
            string message = "The room number has been occupied";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }


        private void dtp_checkOut_Enter(object sender, EventArgs e)
        { }

        private void dtp_checkOut_Leave(object sender, EventArgs e)
        {

                var checkIn = dtp_checkin.Value.Date;
                var checkOut = dtp_checkOut.Value.Date;

                TimeSpan difference = checkOut - checkIn;

                StayIn_days = difference.TotalDays;

            if(StayIn_days <= 0)
            {
                Invalid_Days();
                StayIn_days = 0;
            }
            else
            {
            
                lbl_stayInDays.Text = StayIn_days.ToString();

                rbtn_family.Checked = false;
                rbtn_maleDoom.Checked = false;
                rbtn_Private.Checked = false;
                rbtn_standard.Checked = false;
                rbtn_mixdoom.Checked = false;
                rbtn_femaleDoom.Checked = false;

                lbl_payment.Text = zero.ToString("C");   
            }
             
            }

        private void cmb_roomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            var rm_check = _data.tbl_Guests.FirstOrDefault(r => r.RoomNo == cmb_roomNumber.Text && r.IsClean == "TBU");


            if (rm_check != null)
            {
                cmb_roomNumber.Text = "----------";
                Occupied();


            }
        }

        private void cmb_roomNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void cmb_roomNumber_SelectionChangeCommitted(object sender, EventArgs e)
        {

          
        }

        private void cmb_roomNumber_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void cmb_roomNumber_SelectedValueChanged(object sender, EventArgs e)
        {

         
        }

       
    
        private void cmb_roomNumber_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_cashOnHand_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cashOnHand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      e.KeyChar != '.')
            {
                e.Handled = true; // Ignore the key press
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_guest_Id_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_payment_Click(object sender, EventArgs e)
        {

        }

        private void rbtn_standard_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_mixdoom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_femaleDoom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_maleDoom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbtn_family_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmb_numGuest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_Cash_Click(object sender, EventArgs e)
        {
            Cash_Elements_True();
            pnl_credit.Visible = false;
        }

        private void rbtn_Credit_Click(object sender, EventArgs e)
        {
            Cash_Elements_False();
            pnl_credit.Visible = true;
        }
    }
}
  


//DONE NA WORK NAS ELEMENT FUNTIONS ESPECIALLY SA MGA COMPUTATION SA  RATE UG PENALTY