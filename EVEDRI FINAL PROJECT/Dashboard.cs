
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
    public partial class Dashboard : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);


        private void SetBorderRadius(Control control, int radius)
        {
            control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, radius, radius));
        }
        public Dashboard()
        {
            InitializeComponent();

            // Set border radius for buttons  
            SetBorderRadius(btn_checkIn, 30);
            SetBorderRadius(btn_checkOut, 30);
            SetBorderRadius(btn_logout, 30);

        }


        public int guestId { get; set; }

     
        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void btn_checkIn_Click(object sender, EventArgs e)
        {
           CheckInForm ck = new CheckInForm();
            this.Close();
            ck.Show();
        }

        private void btn_checkOut_Click(object sender, EventArgs e)
        {
            CheckOut ck = new CheckOut();
            this.Close();
            ck.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
