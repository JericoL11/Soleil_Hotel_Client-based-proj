using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVEDRI_FINAL_PROJECT
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        const string sixthree = "+63";
        const int minLength = 9; // Minimum length required
        //Database Injection
        DataClasses1DataContext _data = new DataClasses1DataContext();
        private void Employee_Load(object sender, EventArgs e)
        {
            cmb_Type.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Type.SelectedIndex = 0;

        }
        void EMPLOYEE_PANEL()
        {
            //hiding of panels
            btn_CreateAccount.Visible = false;
            pnl_User.Visible = false;

            btn_createEmployee.Visible = true;
            pnl_Emp.Visible = true;


        }
        void USER_PANEL()
        {
            //hiding of panels
            btn_createEmployee.Visible = false;
            pnl_Emp.Visible = false;

            btn_CreateAccount.Visible = true;
            pnl_User.Visible = true;

        }
        public void Fill_out()
        {
            string title = "Notification";
            string message = "Please fill-out the form completely";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void Success_Create()
        {
            string title = "Notification";
            string message = "Successfully Created";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Unmatched_Pass()
        {
            string title = "Notification";
            string message = "Password are not match";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Phone_Invalid()
        {
            string title = "Notification";
            string message = $"Minimum length of Phone number is: {minLength} characters.";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }




        private void cmb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_Type.SelectedIndex)
            {
                case 0:
                    EMPLOYEE_PANEL();
                    break;
                case 1:
                    USER_PANEL();
                    break;

                default:
                    break;
            }
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        e.KeyChar != '.')
            {
                e.Handled = true; // Ignore the key press
            }
        }

        private void btn_CreateAccount_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_username.Text) || string.IsNullOrWhiteSpace(txt_pass.Text) || string.IsNullOrWhiteSpace(txt_confirmPass.Text))
            {
                Fill_out();

            }
            else
            {
                if (txt_pass.Text != txt_confirmPass.Text)
                {
                    Unmatched_Pass();
                }
                else
                {
                    Success_Create();
                    _data.SP_Admin_addUser(txt_username.Text, txt_pass.Text);

                    txt_username.Clear();
                    txt_pass.Clear();
                    txt_confirmPass.Clear();
                }

            }
        }

        private void btn_createEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_fname.Text) || string.IsNullOrWhiteSpace(txt_lname.Text) || string.IsNullOrWhiteSpace(txt_position.Text) || string.IsNullOrWhiteSpace(txt_email.Text) || string.IsNullOrWhiteSpace(txt_phone.Text) || string.IsNullOrWhiteSpace(txt_address.Text))
            {
                Fill_out();
            }
            else
            {
                 string PhoneNumber = $"09{txt_phone.Text}";

                if (txt_phone.Text.Length < minLength)
                {
                    Phone_Invalid();
                }
                else
                {
                    Success_Create();
                    _data.SP_Admin_addEmployee(txt_fname.Text, txt_lname.Text, txt_position.Text, PhoneNumber, txt_email.Text, txt_address.Text);

                    txt_fname.Clear();
                    txt_lname.Clear();
                    txt_email.Clear();
                    txt_address.Clear();
                    txt_phone.Clear();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            this.Close();
            ad.Show();
        }
    }
}
