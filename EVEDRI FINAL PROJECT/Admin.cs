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
            dgv_admin.DataSource =_data.SP_admin_staff();
        }

        private void btn_Cdetails_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;

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
    }
}
