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

        public int Maximum { get; set; }
        public double penalty { get; set; }

        public string ModePayment { get; set; }


        double zero = 0;

        public string roomType { get; set; }
      /*  public string numberOfGuest { get; set; }*/

        //dateTime default 
        DateTime Today = DateTime.Now;

        private DateTimePicker monthYearPicker;


        public DateTime Tommorow { get; set; }

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
        void Credit_Elements()
        {
            btn_amount.Visible = false;
            lbl_CoH.Visible = false;
            txt_cashOnHand.Visible = true;
        }

        void Background_True()
        {
            pnl_Selection.Visible = false;
            dtp_checkOut.Enabled = true;
            btn_reserved.Enabled = true;
            rbtn_Cash.Enabled = true;
            rbtn_Credit.Enabled = true;
            btn_amount.Enabled = true;
            txt_cashOnHand.Enabled = true;
            btn_back.Enabled = true;
            btn_submit.Enabled = true;
        }

      
        void Background_False()
        {
            dtp_checkOut.Enabled = false;
            btn_reserved.Enabled = false;
            rbtn_Cash.Enabled = false;
            rbtn_Credit.Enabled = false;
            btn_amount.Enabled = false;
            txt_cashOnHand.Enabled = false;
            btn_back.Enabled = false;
            btn_submit.Enabled = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            btn_picClose.Visible = false;
            cmb_roomNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_numGuest.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_roomType.DropDownStyle = ComboBoxStyle.DropDownList;
            dtp_checkin.Enabled = false;

         

            dtp_checkOut.Value = Today.AddDays(1);

            rbtn_Cash.Checked = true;

            StayIn_days = 1;

            lbl_stayInDays.Text = StayIn_days.ToString();



            //hiding of amount methods

          

            pnl_credit.Visible = false;
            pnl_Selection.Visible = false;

            lbl_guest_Id.Text = guestID.ToString();

            lbl_payment.Text = zero.ToString("C");

            btn_back.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_back.Width, btn_back.Height, 20, 20));
            btn_submit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_submit.Width, btn_submit.Height, 20, 20));
            btn_amount.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_amount.Width, btn_amount.Height, 20, 20));
        }
        private void dtp_creditDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmb_numGuest_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_roomType.SelectedIndex)
            {
                case 0:
                    {
                        if (Convert.ToInt32(cmb_numGuest.Text) > Maximum)
                        {
                            penalty = 300;
                            lbl_penalty.Text = penalty.ToString("C");

                            total_payment = (payment * StayIn_days) + penalty;

                            txt_penaltyTotal.Text = penalty.ToString("C");
                            lbl_totalPaypent.Text = total_payment.ToString("C");

                            
                        }
                        else
                        {
                            penalty = 0;
                            lbl_penalty.Text = penalty.ToString("C");

                            total_payment = (payment * StayIn_days) + penalty;

                            txt_penaltyTotal.Text = penalty.ToString("C");
                            lbl_totalPaypent.Text = total_payment.ToString("C");

                        }
                    }
                    break;
                case 1:
                    {
                        if (Convert.ToInt32(cmb_numGuest.Text) > Maximum)
                        {
                            penalty = 500;
                            lbl_penalty.Text = penalty.ToString("C");

                            total_payment = (payment * StayIn_days) + penalty;

                            txt_penaltyTotal.Text = penalty.ToString("C");
                            lbl_totalPaypent.Text = total_payment.ToString("C");

                        }
                        else
                        {
                            penalty = 0;
                            lbl_penalty.Text = penalty.ToString("C");

                            total_payment = (payment * StayIn_days) + penalty;

                            txt_penaltyTotal.Text = penalty.ToString("C");
                            lbl_totalPaypent.Text = total_payment.ToString("C");
                        }
                    }
                    break;
                case 2:
                    {
                        if (Convert.ToInt32(cmb_numGuest.Text) > Maximum)
                        {
                            penalty = 1000;
                            lbl_penalty.Text = penalty.ToString("C");


                            total_payment = (payment * StayIn_days) + penalty;

                            txt_penaltyTotal.Text = penalty.ToString("C");
                            lbl_totalPaypent.Text = total_payment.ToString("C");
                        }
                    }
                    break;
                case 3:
                    {
                        if (Convert.ToInt32(cmb_numGuest.Text) > Maximum)
                        {
                            penalty = 2000;
                            lbl_penalty.Text = penalty.ToString("C");


                            total_payment = (payment * StayIn_days) + penalty;

                            txt_penaltyTotal.Text = penalty.ToString("C");
                            lbl_totalPaypent.Text = total_payment.ToString("C");
                        }
                        else
                        {
                            penalty = 0;
                            lbl_penalty.Text = penalty.ToString("C");

                            total_payment = (payment * StayIn_days) + penalty;

                            txt_penaltyTotal.Text = penalty.ToString("C");
                            lbl_totalPaypent.Text = total_payment.ToString("C");
                        }
                    }
                    break;
                case 4:
                    {
                        if (Convert.ToInt32(cmb_numGuest.Text) > Maximum)
                        {
                            penalty = 3000;
                            lbl_penalty.Text = penalty.ToString("C");


                            total_payment = (payment * StayIn_days) + penalty;

                            txt_penaltyTotal.Text = penalty.ToString("C");
                            lbl_totalPaypent.Text = total_payment.ToString("C");
                        }
                        else
                        {
                            penalty = 0;
                            lbl_penalty.Text = penalty.ToString("C");

                            total_payment = (payment * StayIn_days) + penalty;

                            txt_penaltyTotal.Text = penalty.ToString("C");
                            lbl_totalPaypent.Text = total_payment.ToString("C");
                        }
                    }
                    break;
            }
        }
        private void cmb_numGuest_Click(object sender, EventArgs e)
        {
        /*    if(Maximum == 0)
            {
                MessageBox.Show("");
            }
            else
            {
                
         
            }*/

        }
        private void cmb_roomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_roomType.SelectedIndex)
            {
                //standard
                case 0:
                    Maximum = 2;
                    lbl_penalty.Text = 0.ToString("C");
                    txt_cashOnHand.Text = null;
                    cmb_numGuest.Items.Clear();
                    cmb_numGuest.Text = "----------";
               


                    cmb_roomNumber.Items.Clear();
                    cmb_roomNumber.Text = "----------";
                    cmb_roomNumber.Items.Add("101");
                    cmb_roomNumber.Items.Add("102");
                    cmb_roomNumber.Items.Add("103");


                    cmb_numGuest.Items.Add("1");
                    cmb_numGuest.Items.Add("2");
                    cmb_numGuest.Items.Add("3");
                    cmb_numGuest.Items.Add("4");


                    //assigning of payment
                    payment = 699.00;

                  
                    lbl_maximum.Text = Maximum.ToString();
                    roomType = cmb_roomType.Text;
                    lbl_roomPayment.Text = payment.ToString("C");
                    txt_penaltyTotal.Text = 0.ToString("C2");

                    break;

                //family
                case 1:
                    Maximum = 4;
                    lbl_penalty.Text = 0.ToString("C");
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



                    cmb_roomNumber.Items.Add("201");
                    cmb_roomNumber.Items.Add("202");
                    cmb_roomNumber.Items.Add("203");

                    //assigning of payment
                 

                    payment = 1100.00 * StayIn_days;

/*
                    lbl_payment.Text = total_payment.ToString("C");*/
                    lbl_maximum.Text = Maximum.ToString();
                    roomType = cmb_roomType.Text;
                    lbl_roomPayment.Text = payment.ToString("C");
                    txt_penaltyTotal.Text = 0.ToString("C2");
                    break;

                //Private
                case 2:
                    Maximum = 3;
                    lbl_penalty.Text = 0.ToString("C");
                    txt_cashOnHand.Text = null;
                    cmb_numGuest.Items.Clear();
                    cmb_numGuest.Text = "----------";

                    cmb_roomNumber.Items.Clear();
                    cmb_roomNumber.Text = "----------";


                    cmb_numGuest.Items.Add("1");
                    cmb_numGuest.Items.Add("2");
                    cmb_numGuest.Items.Add("3");
                    cmb_numGuest.Items.Add("5");
            

                    cmb_roomNumber.Items.Add("301");
                    cmb_roomNumber.Items.Add("302");
                    cmb_roomNumber.Items.Add("303");

                    payment = 1450;

             
               
                    lbl_maximum.Text = Maximum.ToString();
                    roomType = cmb_roomType.Text;
                    lbl_roomPayment.Text = payment.ToString("C");
                    txt_penaltyTotal.Text = 0.ToString("C2");
                    break;

                //Deluxe
                case 3:
                    Maximum = 10;
                    lbl_penalty.Text = 0.ToString("C");
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
                    cmb_numGuest.Items.Add("7");
                    cmb_numGuest.Items.Add("8");
                    cmb_numGuest.Items.Add("9");
                    cmb_numGuest.Items.Add("10");
                    cmb_numGuest.Items.Add("11");
                    cmb_numGuest.Items.Add("12");
                    cmb_numGuest.Items.Add("13");
                    cmb_numGuest.Items.Add("14");
                    cmb_numGuest.Items.Add("15");


                    cmb_roomNumber.Items.Add("401");
                    cmb_roomNumber.Items.Add("402");
                    cmb_roomNumber.Items.Add("403");

                    payment = 2000;

              
           /*         total_payment = payment * StayIn_days;
                    lbl_payment.Text = total_payment.ToString("C");*/
                    lbl_maximum.Text = Maximum.ToString();
                    roomType = cmb_roomType.Text;
                    lbl_roomPayment.Text = payment.ToString("C");
                    txt_penaltyTotal.Text = 0.ToString("C2");
                    break;

                //Executive
                case 4:
                    Maximum = 10;
                    lbl_penalty.Text = 0.ToString("C");
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
                    cmb_numGuest.Items.Add("7");
                    cmb_numGuest.Items.Add("8");
                    cmb_numGuest.Items.Add("9");
                    cmb_numGuest.Items.Add("10");
                    cmb_numGuest.Items.Add("11");
                    cmb_numGuest.Items.Add("12");
                    cmb_numGuest.Items.Add("13");
                    cmb_numGuest.Items.Add("14");
                    cmb_numGuest.Items.Add("15");

                    cmb_roomNumber.Items.Add("501");
                    cmb_roomNumber.Items.Add("502");
                    cmb_roomNumber.Items.Add("503");

                    payment = 3000;

                    /*    total_payment = payment * StayIn_days;
                        lbl_payment.Text = total_payment.ToString("C");*/

                    lbl_maximum.Text = Maximum.ToString();
                    roomType = cmb_roomType.Text;
                    lbl_roomPayment.Text = payment.ToString("C");
                    txt_penaltyTotal.Text = 0.ToString("C2");
                    break;
             /*   case 5:
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
                    break;
*/
                default:
                    cmb_roomType.Text = "Not Found";
                    break;
            }


        }
        private void btn_amount_Click(object sender, EventArgs e)
        {
            if (lbl_payment.Text == zero.ToString("C"))
            {
                Choose_Records();
                txt_cashOnHand.Clear();
            }
            else
            {
                if (lbl_payment.Text == zero.ToString("C"))
                {
                    txt_cashOnHand.Text = null;
                }
                else
                {
                    txt_cashOnHand.Text = total_payment.ToString("N");
                }
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
                            r.modePayment = ModePayment;
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
        public void Success_credit()
        {
            string title = "Notification";
            string message = "Payment Successful";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void Choose_Records()
        {
            string title = "Notification";
            string message = "Reservation of room is needed";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void Occupied()
        {
            string title = "Notification";
            string message = "The room number has been occupied";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }
        public void CardNum_Min()
        {
            string title = "Notification";
            string message = "Card Number must be 12 digits";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        public void CardCvv_Min()
        {
            string title = "Notification";
            string message = "CVV must be 3 digits";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Background_True();
/*            cmb_roomType.Text = null;
            cmb_roomNumber.Text = null;
            cmb_numGuest.Text = null;*/
      /*      lbl_totalPaypent.Text = "0";
            lbl_roomPayment.Text = "0";
            lbl_penalty.Text = "0";*/


        }
        private void rbtn_Cash_Click(object sender, EventArgs e)
        {
            if (lbl_payment.Text == zero.ToString("C"))
            {
                Choose_Records();
                txt_cashOnHand.Clear();
            }
            else
            {
                txt_cashOnHand.Clear();
                Cash_Elements_True();
                lbl_CoH.Visible = true;
                lbl_credit.Visible = false;

                pnl_credit.Visible = false;
                ModePayment = rbtn_Cash.Text;
                rbtn_Cash.Checked = true;
            }
        }

        private void rbtn_Credit_Click(object sender, EventArgs e)
        {

            if (lbl_payment.Text == zero.ToString("C"))
            {
                Choose_Records();
                txt_cashOnHand.Clear();
            }
            else
            {
                
                txt_cashOnHand.Clear();
                Cash_Elements_False();
                pnl_credit.Visible = true;
                ModePayment = rbtn_Credit.Text;
                Credit_Elements();
              
            }
        }

        private void btn_reserved_Click(object sender, EventArgs e)
        {
            Background_False();
            pnl_Selection.Visible = true;
        }
        private void txt_cashOnHand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             e.KeyChar != '.')
            {
                e.Handled = true; // Ignore the key press
            }
        }



        private void dtp_checkOut_CloseUp(object sender, EventArgs e)
        {
            var checkIn = dtp_checkin.Value.Date;
            var checkOut = dtp_checkOut.Value.Date;

            TimeSpan difference = checkOut - checkIn;

            StayIn_days = difference.TotalDays;

            if (StayIn_days <= 0)
            {
                Invalid_Days();

                dtp_checkOut.Value = Today.AddDays(1);
                StayIn_days = 1;
                lbl_stayInDays.Text = StayIn_days.ToString();
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
        #region === Null elemenents === 
        private void txt_cashOnHand_TextChanged(object sender, EventArgs e)
        {

        }
        private void dtp_checkOut_MouseEnter(object sender, EventArgs e)
        {


        }

        private void dtp_checkOut_Enter(object sender, EventArgs e)
        { }

        private void dtp_checkOut_Leave(object sender, EventArgs e)
        {


        }

        private void dtp_checkOut_MouseLeave(object sender, EventArgs e)
        {

        }

        private void dtp_checkOut_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void dtp_checkOut_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dtp_checkOut_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void dtp_checkOut_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dtp_checkOut_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void dtp_checkOut_FormatChanged(object sender, EventArgs e)
        {

        }
        private void rbtn_standard_Click(object sender, EventArgs e)
        {


        }

        private void rbtn_family_Click(object sender, EventArgs e)
        {



        }

        private void rbtn_Private_Click(object sender, EventArgs e)
        {


        }

        private void rbtn_mixdoom_Click(object sender, EventArgs e)
        {


        }

        private void rbtn_femaleDoom_Click(object sender, EventArgs e)
        {


        }

        private void rbtn_maleDoom_Click(object sender, EventArgs e)
        {


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


        #endregion

        private void btn_creditBack_Click(object sender, EventArgs e)
        {
            pnl_credit.Visible = false;
            Cash_Elements_True();
            rbtn_Cash.Focus();
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var rm_check = _data.tbl_Guests.FirstOrDefault(r => r.RoomNo == cmb_roomNumber.Text && r.IsClean == "TBU");


            if (rm_check != null)
            {
                Occupied();
            }
            else
            {
                if (string.IsNullOrEmpty(cmb_roomType.Text) || string.IsNullOrEmpty(cmb_roomNumber.Text) || string.IsNullOrEmpty(cmb_numGuest.Text))
                {
                    Fill_out();
                }
                else
                {
                    Background_True();
                    pnl_Selection.Visible = false;
                 
                    lbl_roomType.Text = cmb_roomType.Text;
                    lbl_roomNo.Text = cmb_roomNumber.Text;
                    lbl_GuestNo.Text = cmb_numGuest.Text;
                    lbl_payment.Text = lbl_totalPaypent.Text;
                    rbtn_Cash.Focus();
                }
            }
           
        }
        const int CardLength = 12; // Minimum length required
        const int CvvLength = 3; // Minimum length required
        private void btn_saveCredit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_cardNum.Text) || string.IsNullOrEmpty(txt_CvvCard.Text) || string.IsNullOrEmpty(txt_NameCredit.Text))
            {
                Fill_out();
            }
            else
            {
                if(txt_cardNum.Text.Length < CardLength)
                {
                    CardNum_Min();
                }
                else if(txt_CvvCard.Text.Length < CvvLength)
                {
                    CardCvv_Min();
                }
                else
                {
                    pnl_credit.Visible = false;
                    Success_credit();
                    Credit_Elements();

                    rbtn_Credit.Checked = true;
                    lbl_CoH.Visible = false;
                    lbl_credit.Visible = true;
                    txt_cashOnHand.Text = total_payment.ToString();
                    btn_amount.Visible = false;

                    if (!(string.IsNullOrEmpty(txt_cashOnHand.Text)))
                    {
                        txt_cashOnHand.Enabled = false;
                        rbtn_Cash.Enabled = false;
                    }
                    else
                    {
                        txt_cashOnHand.Enabled = true;
                        rbtn_Cash.Enabled = true;
                    }
                }
                
             
            }
            
         
        }

        private void pnl_credit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbtn_Credit_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_cardNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_CvvCard_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cardNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
e.KeyChar != '.')
            {
                e.Handled = true; // Ignore the key press
            }
        }

        private void txt_NameCredit_KeyPress(object sender, KeyPressEventArgs e)
        {
     
        }

        private void txt_CvvCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
e.KeyChar != '.')
            {
                e.Handled = true; // Ignore the key press
            }
        }

        private void btn_policy_Click(object sender, EventArgs e)
        {
            pic_policy.Visible = true;
            btn_picClose.Visible = true;
            Background_False();
        }

        private void btn_picClose_Click(object sender, EventArgs e)
        {
            pic_policy.Visible = false;
            btn_picClose.Visible = false;
            Background_True();
        }
    }
}
