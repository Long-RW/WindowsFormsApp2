namespace WindowsFormsApp2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.UART_SET = new System.Windows.Forms.Button();
            this.lstCom = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comBoxLable = new System.Windows.Forms.Label();
            this.Camera = new System.Windows.Forms.PictureBox();
            this.cBoxCamera = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBaud = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.StaffIF = new System.Windows.Forms.Button();
            this.PictureOut = new System.Windows.Forms.PictureBox();
            this.PictureOutText = new System.Windows.Forms.Label();
            this.PictureIn = new System.Windows.Forms.PictureBox();
            this.PictureInText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.UID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.DateOutLable = new System.Windows.Forms.Label();
            this.TimeOutLable = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.DateInLabel = new System.Windows.Forms.Label();
            this.TimeInLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Camera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UART_SET
            // 
            this.UART_SET.Location = new System.Drawing.Point(12, 12);
            this.UART_SET.Name = "UART_SET";
            this.UART_SET.Size = new System.Drawing.Size(75, 49);
            this.UART_SET.TabIndex = 0;
            this.UART_SET.Text = "UART_SET";
            this.UART_SET.UseVisualStyleBackColor = true;
            this.UART_SET.Click += new System.EventHandler(this.UART_SET_Click);
            // 
            // lstCom
            // 
            this.lstCom.FormattingEnabled = true;
            this.lstCom.Location = new System.Drawing.Point(108, 6);
            this.lstCom.Name = "lstCom";
            this.lstCom.Size = new System.Drawing.Size(121, 21);
            this.lstCom.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.comBoxLable);
            this.panel1.Controls.Add(this.Camera);
            this.panel1.Controls.Add(this.cBoxCamera);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lstBaud);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lstCom);
            this.panel1.Location = new System.Drawing.Point(1680, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 414);
            this.panel1.TabIndex = 2;
            // 
            // comBoxLable
            // 
            this.comBoxLable.AutoSize = true;
            this.comBoxLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxLable.Location = new System.Drawing.Point(6, 160);
            this.comBoxLable.Name = "comBoxLable";
            this.comBoxLable.Size = new System.Drawing.Size(65, 20);
            this.comBoxLable.TabIndex = 8;
            this.comBoxLable.Text = "Camera";
            // 
            // Camera
            // 
            this.Camera.Location = new System.Drawing.Point(26, 209);
            this.Camera.Name = "Camera";
            this.Camera.Size = new System.Drawing.Size(192, 163);
            this.Camera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Camera.TabIndex = 7;
            this.Camera.TabStop = false;
            // 
            // cBoxCamera
            // 
            this.cBoxCamera.FormattingEnabled = true;
            this.cBoxCamera.Location = new System.Drawing.Point(77, 159);
            this.cBoxCamera.Name = "cBoxCamera";
            this.cBoxCamera.Size = new System.Drawing.Size(151, 21);
            this.cBoxCamera.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(39, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Kết Nối";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "BaudRate";
            // 
            // lstBaud
            // 
            this.lstBaud.FormattingEnabled = true;
            this.lstBaud.Location = new System.Drawing.Point(107, 57);
            this.lstBaud.Name = "lstBaud";
            this.lstBaud.Size = new System.Drawing.Size(121, 21);
            this.lstBaud.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "CỔNG COM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1581, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 42);
            this.label3.TabIndex = 15;
            this.label3.Text = "Đồng hồ";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // StaffIF
            // 
            this.StaffIF.Location = new System.Drawing.Point(115, 12);
            this.StaffIF.Name = "StaffIF";
            this.StaffIF.Size = new System.Drawing.Size(75, 49);
            this.StaffIF.TabIndex = 8;
            this.StaffIF.Text = "StaffIF";
            this.StaffIF.UseVisualStyleBackColor = true;
            // 
            // PictureOut
            // 
            this.PictureOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureOut.Location = new System.Drawing.Point(21, 166);
            this.PictureOut.Name = "PictureOut";
            this.PictureOut.Padding = new System.Windows.Forms.Padding(3);
            this.PictureOut.Size = new System.Drawing.Size(210, 211);
            this.PictureOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureOut.TabIndex = 9;
            this.PictureOut.TabStop = false;
            // 
            // PictureOutText
            // 
            this.PictureOutText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureOutText.AutoSize = true;
            this.PictureOutText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureOutText.Location = new System.Drawing.Point(58, 390);
            this.PictureOutText.Name = "PictureOutText";
            this.PictureOutText.Size = new System.Drawing.Size(112, 29);
            this.PictureOutText.TabIndex = 10;
            this.PictureOutText.Text = "Ảnh xe ra";
            // 
            // PictureIn
            // 
            this.PictureIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureIn.Location = new System.Drawing.Point(303, 166);
            this.PictureIn.Name = "PictureIn";
            this.PictureIn.Padding = new System.Windows.Forms.Padding(3);
            this.PictureIn.Size = new System.Drawing.Size(225, 211);
            this.PictureIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureIn.TabIndex = 11;
            this.PictureIn.TabStop = false;
            // 
            // PictureInText
            // 
            this.PictureInText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureInText.AutoSize = true;
            this.PictureInText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureInText.Location = new System.Drawing.Point(349, 390);
            this.PictureInText.Name = "PictureInText";
            this.PictureInText.Size = new System.Drawing.Size(129, 29);
            this.PictureInText.TabIndex = 12;
            this.PictureInText.Text = "Ảnh xe vào";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UID
            // 
            this.UID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UID.Location = new System.Drawing.Point(602, 351);
            this.UID.Name = "UID";
            this.UID.Size = new System.Drawing.Size(121, 26);
            this.UID.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(602, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(621, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mã số thẻ";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(795, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(392, 47);
            this.label5.TabIndex = 17;
            this.label5.Text = "ĐỒ ÁN THIẾT KẾ ";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(0, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1928, 73);
            this.label6.TabIndex = 18;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 542);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1940, 305);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(767, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Họ và tên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(767, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Ngày sinh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(767, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Số điện thoại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1100, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Ngày ra";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1100, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Giờ ra";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1406, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Ngày vào";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1406, 228);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Giờ vào";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1100, 272);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Tải trọng";
            // 
            // nameLabel
            // 
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(875, 180);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(175, 23);
            this.nameLabel.TabIndex = 31;
            this.nameLabel.Text = "Họ và Tên";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateOfBirthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirthLabel.Location = new System.Drawing.Point(875, 223);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(175, 23);
            this.DateOfBirthLabel.TabIndex = 32;
            this.DateOfBirthLabel.Text = "Ngày sinh";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(875, 272);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(175, 23);
            this.PhoneNumberLabel.TabIndex = 33;
            this.PhoneNumberLabel.Text = "Số điện thoại";
            // 
            // DateOutLable
            // 
            this.DateOutLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateOutLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOutLable.Location = new System.Drawing.Point(1180, 180);
            this.DateOutLable.Name = "DateOutLable";
            this.DateOutLable.Size = new System.Drawing.Size(175, 23);
            this.DateOutLable.TabIndex = 34;
            this.DateOutLable.Text = "Ngày ra";
            // 
            // TimeOutLable
            // 
            this.TimeOutLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeOutLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOutLable.Location = new System.Drawing.Point(1180, 225);
            this.TimeOutLable.Name = "TimeOutLable";
            this.TimeOutLable.Size = new System.Drawing.Size(175, 23);
            this.TimeOutLable.TabIndex = 35;
            this.TimeOutLable.Text = "Giờ ra";
            // 
            // WeightLabel
            // 
            this.WeightLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(1180, 272);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(175, 23);
            this.WeightLabel.TabIndex = 36;
            this.WeightLabel.Text = "Tải trọng";
            // 
            // DateInLabel
            // 
            this.DateInLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateInLabel.Location = new System.Drawing.Point(1486, 179);
            this.DateInLabel.Name = "DateInLabel";
            this.DateInLabel.Size = new System.Drawing.Size(175, 23);
            this.DateInLabel.TabIndex = 37;
            this.DateInLabel.Text = "Ngày vào";
            // 
            // TimeInLabel
            // 
            this.TimeInLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeInLabel.Location = new System.Drawing.Point(1486, 225);
            this.TimeInLabel.Name = "TimeInLabel";
            this.TimeInLabel.Size = new System.Drawing.Size(175, 23);
            this.TimeInLabel.TabIndex = 38;
            this.TimeInLabel.Text = "Giờ vào";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1940, 847);
            this.Controls.Add(this.TimeInLabel);
            this.Controls.Add(this.DateInLabel);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.TimeOutLable);
            this.Controls.Add(this.DateOutLable);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PictureInText);
            this.Controls.Add(this.PictureIn);
            this.Controls.Add(this.PictureOutText);
            this.Controls.Add(this.PictureOut);
            this.Controls.Add(this.StaffIF);
            this.Controls.Add(this.UART_SET);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "m";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Camera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UART_SET;
        private System.Windows.Forms.ComboBox lstCom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox lstBaud;
        private System.Windows.Forms.Button button2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label comBoxLable;
        private System.Windows.Forms.ComboBox cBoxCamera;
        private System.Windows.Forms.PictureBox Camera;
        private System.Windows.Forms.Button StaffIF;
        private System.Windows.Forms.Label PictureOutText;
        public System.Windows.Forms.PictureBox PictureOut;
        public System.Windows.Forms.PictureBox PictureIn;
        private System.Windows.Forms.Label PictureInText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label UID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label DateOutLable;
        private System.Windows.Forms.Label TimeOutLable;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label DateInLabel;
        private System.Windows.Forms.Label TimeInLabel;
    }
}

