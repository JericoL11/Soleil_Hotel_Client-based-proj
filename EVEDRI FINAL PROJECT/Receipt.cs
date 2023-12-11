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
	public partial class Receipt : Form
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
        public Receipt()
		{
			InitializeComponent();
		}

        DataClasses1DataContext _data = new DataClasses1DataContext();
        //form attributes
        public int guestId { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string email { get; set; }
       
        public string phoneNumber { get; set; }
        public string roomType { get; set; }
        public int numberGuest { get; set; }
        public string RoomNum { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public double totalPayment { get; set; }
        public double cashOnhand { get; set; }
        public double totalChange { get; set; }

        public int numberDays { get; set; }

        public string modePayment { get; set; }


     

        private void Form5_Load(object sender, EventArgs e)
        {
            //auto compute
            totalChange = cashOnhand - totalPayment; 

            //assigning of data to the labels
            lbl_guestId.Text = guestId.ToString();
            lbl_fname .Text = fname;
            lbl_lname .Text = lname;
            lbl_email .Text = email;
          
            lbl_phoneNumber .Text = phoneNumber;
            lbl_roomType .Text = roomType;
            lbl_numberGuest.Text = numberGuest.ToString();
            lbl_roomNumber.Text = RoomNum;
            lbl_CheckInDate.Text = CheckIn.ToString();
            lbl_CheckoutDate.Text = CheckOut.ToString();
            lbl_modePayment.Text = modePayment;
            lbl_Totalpayment.Text = totalPayment.ToString("C");
            lbl_cashOnhand.Text = cashOnhand.ToString("C");
            lbl_change.Text = totalChange.ToString("C");

            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));
            btn_save.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_save.Width, btn_save.Height, 20, 20));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        public void Success()
        {
            string title = "Notification";
            string message = "Transaction has been recorded.";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            Success();
            _data.SP_User_Transact_CheckIn(guestId, Convert.ToDecimal(totalPayment), CheckIn);

            _data.SP_User_Transact_Rooms(guestId,roomType, RoomNum.ToString(),numberGuest.ToString());

            _data.SP_User_Transact_CheckOut(guestId,CheckOut, numberDays.ToString());
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cashOnhand_Click(object sender, EventArgs e)
        {

        }

        private void lbl_change_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
