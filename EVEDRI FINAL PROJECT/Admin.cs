using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVEDRI_FINAL_PROJECT
{
    public partial class Admin : Form
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
        public Admin()
        {
            InitializeComponent();
        }
        //database injection

        DataClasses1DataContext _data = new DataClasses1DataContext();


        private void Form6_Load(object sender, EventArgs e)
        {
            btn_Cdetails.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Cdetails.Width, btn_Cdetails.Height, 20, 20));
            btn_employee.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_employee.Width, btn_employee.Height, 20, 20));
            btn_Show.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Show.Width, btn_Show.Height, 20, 20));
            btn_Hide.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Hide.Width, btn_Hide.Height, 20, 20));
            btn_logout.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_logout.Width, btn_logout.Height, 20, 20));

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }



        private void btn_employee_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            pnl_userAcc.Visible = false;
            pnl_emp.Visible = true;
            dgv_admin.DataSource = _data.SP_admin_staff();
        }

        private void btn_Cdetails_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            pnl_userAcc.Visible = false;
            pnl_emp.Visible = false;
            dgv_admin.DataSource = _data.SP_admin_Records();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            btn_Show.Visible = false;
            btn_Hide.Visible = true;


            dgv_admin.DataSource = _data.SP_admin_Guest();
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            btn_Show.Visible = true;
            btn_Hide.Visible = false;
            dgv_admin.DataSource = _data.SP_admin_Records();
        }

        private void btn_addEmployee_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            this.Close();
            emp.Show();
        }

        private void btn_Accounts_Click(object sender, EventArgs e)
        {
            dgv_admin.DataSource = _data.SP_Admin_ViewAccounts();
            pnl_userAcc.Visible = true;
            panel2.Visible = false;
            pnl_emp.Visible = false;

        }
        public void ID_User()
        {
            string title = "Notification";
            string message = "Please input the User Account ID";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void ID_EMP()
        {
            string title = "Notification";
            string message = "Please input the User Account ID";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Not_Found()
        {
            string title = "Notification";
            string message = "ID is not available";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Successful_delete()
        {
            string title = "Notification";
            string message = "Successfully deleted";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_delUserAccs_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_accID.Text))
            {
                ID_User();
            }
            else
            {
                try
                {
                    var checkID = _data.tbl_accounts.FirstOrDefault(a => a.acc_id == Convert.ToInt32(txt_accID.Text));

                    if (checkID != null)
                    {
                        Successful_delete();
                        _data.SP_Admin_DelUser(Convert.ToInt32(txt_accID.Text));
                        dgv_admin.DataSource = _data.SP_Admin_ViewAccounts();
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

        private void txt_accID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      e.KeyChar != '.')
            {
                e.Handled = true; // Ignore the key press
            }
        }

        private void txt_delEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    e.KeyChar != '.')
            {
                e.Handled = true; // Ignore the key press
            }
        }

        private void btn_delEmp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_delEmp.Text))
            {
                ID_EMP();
            }
            else
            {
                try
                {
                    var checkID = _data.tbl_Staffs.FirstOrDefault(a => a.staff_Id == Convert.ToInt32(txt_delEmp.Text));

                    if (checkID != null)
                    {
                        Successful_delete();
                        _data.SP_Admin_DelEmployee(Convert.ToInt32(txt_delEmp.Text));
                        dgv_admin.DataSource = _data.SP_admin_staff();
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
