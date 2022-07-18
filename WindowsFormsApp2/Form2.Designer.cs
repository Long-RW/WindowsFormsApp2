namespace WindowsFormsApp2
{
    partial class Form2
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Connect = new System.Windows.Forms.Button();
            this.lstLcience = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StaffPic = new System.Windows.Forms.PictureBox();
            this.StaffName = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StaffID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LciensePlate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffPic)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 680);
            this.webBrowser1.TabIndex = 0;
            // 
            // Connect
            // 
            this.Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.Location = new System.Drawing.Point(68, 80);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(305, 30);
            this.Connect.TabIndex = 1;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // lstLcience
            // 
            this.lstLcience.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLcience.FormattingEnabled = true;
            this.lstLcience.Location = new System.Drawing.Point(197, 31);
            this.lstLcience.Name = "lstLcience";
            this.lstLcience.Size = new System.Drawing.Size(176, 32);
            this.lstLcience.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LciensePlate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.PhoneNumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.StaffID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.StaffPic);
            this.panel1.Controls.Add(this.StaffName);
            this.panel1.Controls.Add(this.lable2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lstLcience);
            this.panel1.Controls.Add(this.Connect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 680);
            this.panel1.TabIndex = 3;
            // 
            // StaffPic
            // 
            this.StaffPic.Location = new System.Drawing.Point(134, 148);
            this.StaffPic.Name = "StaffPic";
            this.StaffPic.Size = new System.Drawing.Size(194, 237);
            this.StaffPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StaffPic.TabIndex = 6;
            this.StaffPic.TabStop = false;
            // 
            // StaffName
            // 
            this.StaffName.AutoEllipsis = true;
            this.StaffName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StaffName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffName.Location = new System.Drawing.Point(154, 422);
            this.StaffName.Name = "StaffName";
            this.StaffName.Size = new System.Drawing.Size(261, 25);
            this.StaffName.TabIndex = 5;
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable2.Location = new System.Drawing.Point(12, 423);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(90, 24);
            this.lable2.TabIndex = 4;
            this.lable2.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Biển số xe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã NV";
            // 
            // StaffID
            // 
            this.StaffID.AutoEllipsis = true;
            this.StaffID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.StaffID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffID.Location = new System.Drawing.Point(154, 481);
            this.StaffID.Name = "StaffID";
            this.StaffID.Size = new System.Drawing.Size(50, 25);
            this.StaffID.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 537);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số điện thoại";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoEllipsis = true;
            this.PhoneNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumber.Location = new System.Drawing.Point(154, 537);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(261, 24);
            this.PhoneNumber.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(220, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "BKS";
            // 
            // LciensePlate
            // 
            this.LciensePlate.AutoEllipsis = true;
            this.LciensePlate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LciensePlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LciensePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LciensePlate.Location = new System.Drawing.Point(272, 481);
            this.LciensePlate.Name = "LciensePlate";
            this.LciensePlate.Size = new System.Drawing.Size(143, 25);
            this.LciensePlate.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 680);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form2";
            this.Text = "Map";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.ComboBox lstLcience;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox StaffPic;
        private System.Windows.Forms.Label StaffName;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label LciensePlate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label StaffID;
        private System.Windows.Forms.Label label2;
    }
}