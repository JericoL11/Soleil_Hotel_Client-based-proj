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
            this.btn_Cdetails = new System.Windows.Forms.Button();
            this.btn_employee = new System.Windows.Forms.Button();
            this.dgv_admin = new System.Windows.Forms.DataGridView();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Hide = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_Cdetails);
            this.panel1.Controls.Add(this.btn_employee);
            this.panel1.Location = new System.Drawing.Point(33, 287);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 359);
            this.panel1.TabIndex = 0;
            // 
            // btn_Cdetails
            // 
            this.btn_Cdetails.BackColor = System.Drawing.Color.Orange;
            this.btn_Cdetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cdetails.ForeColor = System.Drawing.Color.White;
            this.btn_Cdetails.Location = new System.Drawing.Point(44, 61);
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
            this.btn_employee.Location = new System.Drawing.Point(44, 227);
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
            this.panel2.Controls.Add(this.btn_Show);
            this.panel2.Controls.Add(this.btn_Hide);
            this.panel2.Controls.Add(this.label1);
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
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EVEDRI_FINAL_PROJECT.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1436, 754);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
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
    }
}