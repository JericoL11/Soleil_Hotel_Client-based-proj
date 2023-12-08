namespace EVEDRI_FINAL_PROJECT
{
    partial class Dashboard
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
            this.btn_checkIn = new System.Windows.Forms.Button();
            this.btn_checkOut = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_checkIn
            // 
            this.btn_checkIn.BackColor = System.Drawing.Color.Orange;
            this.btn_checkIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_checkIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_checkIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkIn.ForeColor = System.Drawing.Color.White;
            this.btn_checkIn.Location = new System.Drawing.Point(130, 438);
            this.btn_checkIn.Margin = new System.Windows.Forms.Padding(4);
            this.btn_checkIn.Name = "btn_checkIn";
            this.btn_checkIn.Size = new System.Drawing.Size(192, 87);
            this.btn_checkIn.TabIndex = 51;
            this.btn_checkIn.Text = "CHECK-IN";
            this.btn_checkIn.UseVisualStyleBackColor = false;
            this.btn_checkIn.Click += new System.EventHandler(this.btn_checkIn_Click);
            // 
            // btn_checkOut
            // 
            this.btn_checkOut.BackColor = System.Drawing.Color.Orange;
            this.btn_checkOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_checkOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_checkOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkOut.ForeColor = System.Drawing.Color.White;
            this.btn_checkOut.Location = new System.Drawing.Point(417, 438);
            this.btn_checkOut.Margin = new System.Windows.Forms.Padding(4);
            this.btn_checkOut.Name = "btn_checkOut";
            this.btn_checkOut.Size = new System.Drawing.Size(230, 87);
            this.btn_checkOut.TabIndex = 52;
            this.btn_checkOut.Text = "CHECK-OUT";
            this.btn_checkOut.UseVisualStyleBackColor = false;
            this.btn_checkOut.Click += new System.EventHandler(this.btn_checkOut_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Orange;
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(654, 13);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(107, 36);
            this.btn_logout.TabIndex = 67;
            this.btn_logout.Text = "LOG-OUT";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::EVEDRI_FINAL_PROJECT.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(130, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(517, 398);
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EVEDRI_FINAL_PROJECT.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 665);
            this.ControlBox = false;
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_checkOut);
            this.Controls.Add(this.btn_checkIn);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_checkIn;
        private System.Windows.Forms.Button btn_checkOut;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}