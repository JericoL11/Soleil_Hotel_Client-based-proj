namespace EVEDRI_FINAL_PROJECT
{
	partial class Admin
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_addEmployee = new System.Windows.Forms.Button();
            this.btn_Cdetails = new System.Windows.Forms.Button();
            this.btn_employee = new System.Windows.Forms.Button();
            this.dgv_admin = new System.Windows.Forms.DataGridView();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Hide = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Accounts = new System.Windows.Forms.Button();
            this.pnl_userAcc = new System.Windows.Forms.Panel();
            this.btn_delUserAccs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_accID = new System.Windows.Forms.TextBox();
            this.pnl_emp = new System.Windows.Forms.Panel();
            this.btn_delEmp = new System.Windows.Forms.Button();
            this.txt_delEmp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_userAcc.SuspendLayout();
            this.pnl_emp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_Accounts);
            this.panel1.Controls.Add(this.btn_addEmployee);
            this.panel1.Controls.Add(this.btn_Cdetails);
            this.panel1.Controls.Add(this.btn_employee);
            this.panel1.Location = new System.Drawing.Point(33, 287);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 359);
            this.panel1.TabIndex = 0;
            // 
            // btn_addEmployee
            // 
            this.btn_addEmployee.BackColor = System.Drawing.Color.Orange;
            this.btn_addEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_addEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_addEmployee.Location = new System.Drawing.Point(44, 291);
            this.btn_addEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addEmployee.Name = "btn_addEmployee";
            this.btn_addEmployee.Size = new System.Drawing.Size(255, 63);
            this.btn_addEmployee.TabIndex = 4;
            this.btn_addEmployee.Text = "Add Accounts";
            this.btn_addEmployee.UseVisualStyleBackColor = false;
            this.btn_addEmployee.Click += new System.EventHandler(this.btn_addEmployee_Click);
            // 
            // btn_Cdetails
            // 
            this.btn_Cdetails.BackColor = System.Drawing.Color.Orange;
            this.btn_Cdetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cdetails.ForeColor = System.Drawing.Color.White;
            this.btn_Cdetails.Location = new System.Drawing.Point(44, 30);
            this.btn_Cdetails.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cdetails.Name = "btn_Cdetails";
            this.btn_Cdetails.Size = new System.Drawing.Size(255, 63);
            this.btn_Cdetails.TabIndex = 3;
            this.btn_Cdetails.Text = "Customer Details";
            this.btn_Cdetails.UseVisualStyleBackColor = false;
            this.btn_Cdetails.Click += new System.EventHandler(this.btn_Cdetails_Click);
            // 
            // btn_employee
            // 
            this.btn_employee.BackColor = System.Drawing.Color.Orange;
            this.btn_employee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employee.ForeColor = System.Drawing.Color.White;
            this.btn_employee.Location = new System.Drawing.Point(44, 117);
            this.btn_employee.Margin = new System.Windows.Forms.Padding(4);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(255, 63);
            this.btn_employee.TabIndex = 2;
            this.btn_employee.Text = "Employee";
            this.btn_employee.UseVisualStyleBackColor = false;
            this.btn_employee.Click += new System.EventHandler(this.btn_employee_Click);
            // 
            // dgv_admin
            // 
            this.dgv_admin.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dgv_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_admin.Location = new System.Drawing.Point(380, 275);
            this.dgv_admin.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_admin.Name = "dgv_admin";
            this.dgv_admin.RowHeadersWidth = 51;
            this.dgv_admin.Size = new System.Drawing.Size(984, 418);
            this.dgv_admin.TabIndex = 66;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Orange;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(1315, 36);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(108, 42);
            this.btn_logout.TabIndex = 67;
            this.btn_logout.Text = "LOG-OUT";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_Show
            // 
            this.btn_Show.BackColor = System.Drawing.Color.Orange;
            this.btn_Show.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Show.ForeColor = System.Drawing.Color.White;
            this.btn_Show.Location = new System.Drawing.Point(180, 17);
            this.btn_Show.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(132, 34);
            this.btn_Show.TabIndex = 4;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = false;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 68;
            this.label1.Text = "All customers ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_Show);
            this.panel2.Controls.Add(this.btn_Hide);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(421, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 63);
            this.panel2.TabIndex = 69;
            this.panel2.Visible = false;
            // 
            // btn_Hide
            // 
            this.btn_Hide.AutoSize = true;
            this.btn_Hide.BackColor = System.Drawing.Color.Orange;
            this.btn_Hide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hide.Location = new System.Drawing.Point(180, 17);
            this.btn_Hide.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Hide.Name = "btn_Hide";
            this.btn_Hide.Size = new System.Drawing.Size(132, 34);
            this.btn_Hide.TabIndex = 69;
            this.btn_Hide.Text = "Hide";
            this.btn_Hide.UseVisualStyleBackColor = false;
            this.btn_Hide.Visible = false;
            this.btn_Hide.Click += new System.EventHandler(this.btn_Hide_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::EVEDRI_FINAL_PROJECT.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-10, -24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 348);
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Accounts
            // 
            this.btn_Accounts.BackColor = System.Drawing.Color.Orange;
            this.btn_Accounts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Accounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Accounts.ForeColor = System.Drawing.Color.White;
            this.btn_Accounts.Location = new System.Drawing.Point(44, 205);
            this.btn_Accounts.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Accounts.Name = "btn_Accounts";
            this.btn_Accounts.Size = new System.Drawing.Size(255, 63);
            this.btn_Accounts.TabIndex = 5;
            this.btn_Accounts.Text = "User Accounts";
            this.btn_Accounts.UseVisualStyleBackColor = false;
            this.btn_Accounts.Click += new System.EventHandler(this.btn_Accounts_Click);
            // 
            // pnl_userAcc
            // 
            this.pnl_userAcc.BackColor = System.Drawing.Color.Transparent;
            this.pnl_userAcc.Controls.Add(this.btn_delUserAccs);
            this.pnl_userAcc.Controls.Add(this.txt_accID);
            this.pnl_userAcc.Controls.Add(this.label2);
            this.pnl_userAcc.ForeColor = System.Drawing.Color.White;
            this.pnl_userAcc.Location = new System.Drawing.Point(421, 177);
            this.pnl_userAcc.Name = "pnl_userAcc";
            this.pnl_userAcc.Size = new System.Drawing.Size(501, 63);
            this.pnl_userAcc.TabIndex = 71;
            this.pnl_userAcc.Visible = false;
            // 
            // btn_delUserAccs
            // 
            this.btn_delUserAccs.AutoSize = true;
            this.btn_delUserAccs.BackColor = System.Drawing.Color.Orange;
            this.btn_delUserAccs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delUserAccs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delUserAccs.Location = new System.Drawing.Point(316, 18);
            this.btn_delUserAccs.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delUserAccs.Name = "btn_delUserAccs";
            this.btn_delUserAccs.Size = new System.Drawing.Size(132, 34);
            this.btn_delUserAccs.TabIndex = 69;
            this.btn_delUserAccs.Text = "Delete";
            this.btn_delUserAccs.UseVisualStyleBackColor = false;
            this.btn_delUserAccs.Click += new System.EventHandler(this.btn_delUserAccs_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 68;
            this.label2.Text = "User Account ID:";
            // 
            // txt_accID
            // 
            this.txt_accID.Location = new System.Drawing.Point(184, 23);
            this.txt_accID.MaxLength = 6;
            this.txt_accID.Name = "txt_accID";
            this.txt_accID.Size = new System.Drawing.Size(100, 22);
            this.txt_accID.TabIndex = 70;
            this.txt_accID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_accID_KeyPress);
            // 
            // pnl_emp
            // 
            this.pnl_emp.BackColor = System.Drawing.Color.Transparent;
            this.pnl_emp.Controls.Add(this.btn_delEmp);
            this.pnl_emp.Controls.Add(this.txt_delEmp);
            this.pnl_emp.Controls.Add(this.label3);
            this.pnl_emp.ForeColor = System.Drawing.Color.White;
            this.pnl_emp.Location = new System.Drawing.Point(421, 177);
            this.pnl_emp.Name = "pnl_emp";
            this.pnl_emp.Size = new System.Drawing.Size(501, 63);
            this.pnl_emp.TabIndex = 72;
            this.pnl_emp.Visible = false;
            // 
            // btn_delEmp
            // 
            this.btn_delEmp.AutoSize = true;
            this.btn_delEmp.BackColor = System.Drawing.Color.Orange;
            this.btn_delEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delEmp.Location = new System.Drawing.Point(316, 18);
            this.btn_delEmp.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delEmp.Name = "btn_delEmp";
            this.btn_delEmp.Size = new System.Drawing.Size(132, 34);
            this.btn_delEmp.TabIndex = 69;
            this.btn_delEmp.Text = "Delete";
            this.btn_delEmp.UseVisualStyleBackColor = false;
            this.btn_delEmp.Click += new System.EventHandler(this.btn_delEmp_Click);
            // 
            // txt_delEmp
            // 
            this.txt_delEmp.Location = new System.Drawing.Point(184, 23);
            this.txt_delEmp.MaxLength = 6;
            this.txt_delEmp.Name = "txt_delEmp";
            this.txt_delEmp.Size = new System.Drawing.Size(100, 22);
            this.txt_delEmp.TabIndex = 70;
            this.txt_delEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_delEmp_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 68;
            this.label3.Text = "Employee ID:";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EVEDRI_FINAL_PROJECT.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1436, 754);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_emp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_userAcc);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.dgv_admin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_userAcc.ResumeLayout(false);
            this.pnl_userAcc.PerformLayout();
            this.pnl_emp.ResumeLayout(false);
            this.pnl_emp.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_admin;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.Button btn_Cdetails;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Hide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_addEmployee;
        private System.Windows.Forms.Button btn_Accounts;
        private System.Windows.Forms.Panel pnl_userAcc;
        private System.Windows.Forms.TextBox txt_accID;
        private System.Windows.Forms.Button btn_delUserAccs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_emp;
        private System.Windows.Forms.Button btn_delEmp;
        private System.Windows.Forms.TextBox txt_delEmp;
        private System.Windows.Forms.Label label3;
    }
}