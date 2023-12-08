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
    public partial class Login : Form
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
        public Login()
        {
            InitializeComponent();
        }

        //database injection

        DataClasses1DataContext _data = new DataClasses1DataContext();


        private void btn_login_Click(object sender, EventArgs e)
        {

            //admin 
            var Admin_data = _data.tbl_Admins
                    .FirstOrDefault(adm => adm.admin_User == txt_username.Text
                            && adm.admin_Pass == txt_password.Text);

            //authorized accounts 
            var accounts_data = _data.tbl_accounts
                  .FirstOrDefault(acc => acc.acc_User == txt_username.Text
                          && acc.acc_Pass == txt_password.Text);

            if (Admin_data != null)
            {
                login_success();

                Admin ad = new Admin();
                this.Hide();
                ad.Show();
            }
            else if (accounts_data != null)
            {
                login_success();
                Dashboard d = new Dashboard();
                this.Hide();
                d.Show();
            }
            else
            {
                login_fail();
            }
        }



        //messagebox
            public void login_fail()
            {
                string title = "Notification";
                string message = "Incorrect Username or Password";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            public void login_success()
            {
                string title = "Notification";
                string message = "Successfully login";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        private void Login_Load(object sender, EventArgs e)
        {
            btn_login.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_login.Width, btn_login.Height, 20,20));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 17, 17 ));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
