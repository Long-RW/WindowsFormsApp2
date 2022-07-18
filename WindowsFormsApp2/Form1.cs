﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using AForge.Video;
using AForge.Video.DirectShow;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
namespace WindowsFormsApp2
{   
    public partial class Form1 : Form
    {
        /*************************Camera Variables********************************************************************************************/
        //Tạo địa chỉ lưu ảnh
        private string PictureOutSavePath = Application.StartupPath + "\\Resources\\PictureOut\\";
        private string PictureInSavePath = Application.StartupPath + "\\Resources\\PictureIn\\";
        //Khởi tạo Camera
        private FilterInfoCollection Cameras;
        private VideoCaptureDevice cam;
        public double latitude;
        public double longitude;
        /***********************************************************************************************************************************/

        /*************************Staff Variables********************************************************************************************/
        //Lưu trữ dữ liệu nhân viên
        private string[] UID_Key = { "0", "1d e6 af c9 9d", "63 ac b1 18 66", "88  4 80 41 4d", "6c 5c 4d 49 34" };

        //Mảng chứa tốc độ baud của UART
        string[] pause = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };

        //FireBasew Config
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "XpG3HiAbNsb0PKF9pMVmfkpWHWvHk16enIATyL2O",
            BasePath = "https://staffdatabase2-9d424-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        //DataBase của nhân viên
        List<Staff> StaffDb = new List<Staff>();
        
        //List lưu trữ trạng thái vào ra của xe tải
        private List<bool> truckState = new List<bool>();

        //List lưu trữ thời gian xuất kho của xe tải
        private List<string> listDateOut = new List<string>();
        private List<string> listTimeOut = new List<string>();

        //Biến đếm của STT
        int counterOfSTT = 0;
        /***********************************************************************************************************************************/
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            /*************************Camera Config****************************************************************/
            //Đọc dữ liệu từ camera của máy tính
            Cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //Add Camera được cọn từ Combobox
            foreach (FilterInfo info in Cameras)
            {
                cBoxCamera.Items.Add(info.Name);
            }
            cBoxCamera.SelectedIndex = 0
            /******************************************************************************************************/

;           /*************************Staff Config****************************************************************/
            //Gán trạng thái ở trong kho cho tất cả các xe
            for (int i = 0; i < UID_Key.Length; i++)
            {
                truckState.Add(false);
            }

            //Gán dữ liệu vào ra cho các xe
            for (int i = 0; i < UID_Key.Length; i++)
            {
                listDateOut.Add("");
                listTimeOut.Add("");
            }
            /******************************************************************************************************/
        }

        //Timer đếm cho đồng hồ thời gian thực
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("hh:mm tt");
        }

  
        private void UART_SET_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            client = new FireSharp.FirebaseClient(config);

            //Khởi tạo timer
            timer1.Enabled = true;
            timer1.Start();
            timer2.Enabled = true;
            timer2.Start();
            //Cập nhật thời gian đồng hồ liên tục
            label3.Text = DateTime.Now.ToString("hh:mm tt");

            //Lấy các cổng Serial Port của máy
            string[] listnamecom = SerialPort.GetPortNames();
            lstCom.Items.AddRange(listnamecom);
            lstBaud.Items.AddRange(pause);
            //Kiểm tra trạng thái hoạt động của camera => Mở hay chưa mở
            if(cam != null && cam.IsRunning)
            {
                cam.Stop(); //Nếu mở thì tắt nó đi
            }
            cam = new VideoCaptureDevice(Cameras[cBoxCamera.SelectedIndex].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam.Start();    //Khởi động camera
            LoadListView(); //Hiển thị listView
        }
        /********************************************Staff Data Display Function*************************************/
        private void LoadListView()
        {
            listView1.Columns.Add("STT");
            listView1.Columns.Add("Mã số nhân viên");
            listView1.Columns.Add("Họ và tên");
            listView1.Columns.Add("Ngày sinh");
            listView1.Columns.Add("Số điện thoại");
            listView1.Columns.Add("Biển số xe");
            listView1.Columns.Add("Ngày ra");
            listView1.Columns.Add("Giờ ra");
            listView1.Columns.Add("Ngày vào");
            listView1.Columns.Add("Giờ vào");
            listView1.Columns.Add("Tải trọng");
        }

        private async void PrintNewItem(int i, int counter, bool truckState, string Weight )
        {    
            FirebaseResponse resp2 = await client.GetTaskAsync("Staff/" + Convert.ToString(i));

            Staff obj2 = resp2.ResultAs<Staff>();
            string dateNow = DateTime.Now.ToString("dd/MM/yyyy");
            string timeNow = DateTime.Now.ToString("hh:mm:ss tt");
            ListViewItem STT = new ListViewItem();
            STT.Text = Convert.ToString(counter);
            if( truckState == false )
            {   
                //ListView Display
                STT.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = obj2.StaffID });
                STT.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = obj2.Name });
                STT.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = obj2.DateOfBirth });
                STT.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = obj2.PhoneNumber });
                STT.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = obj2.LicensePlate });
                STT.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dateNow });
                STT.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = timeNow });
                STT.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "" });
                STT.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "" });
                STT.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = Weight });
                listDateOut[i] = dateNow;
                listTimeOut[i] = timeNow;
                //Text Panel Display
                nameLabel.Text = obj2.Name;
                DateOfBirthLabel.Text = obj2.DateOfBirth;
                PhoneNumberLabel.Text = obj2.PhoneNumber;
                DateOutLable.Text = dateNow;
                TimeOutLable.Text = timeNow;
                TimeInLabel.Text = "";
                DateInLabel.Text = "";
                WeightLabel.Text = Weight;
            }
            else if (truckState == true)
            {
                STT.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = obj2.StaffID });
                STT.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = obj2.Name });
                STT.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = obj2.DateOfBirth });
                STT.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = obj2.PhoneNumber });
                STT.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = obj2.LicensePlate });
                STT.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listDateOut[i] });
                STT.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = listTimeOut[i] });
                STT.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dateNow });
                STT.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = timeNow });
                STT.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = Weight });

                nameLabel.Text = obj2.Name;
                DateOfBirthLabel.Text = obj2.DateOfBirth;
                PhoneNumberLabel.Text = obj2.PhoneNumber;
                DateOutLable.Text = listDateOut[i];
                TimeOutLable.Text = listTimeOut[i];
                TimeInLabel.Text = timeNow;
                DateInLabel.Text = dateNow;
                WeightLabel.Text = Weight;
            }

            listView1.Items.Add(STT);
        }
        /******************************************************************************************************/

        /*****************************************Camera Function**********************************************/
        //Clone những gì Camera ghi lại và hiển thị trên màn hình theo thời gian thực
        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            Camera.Image = bitmap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstCom.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn cổng com", "Thông báo");
            }
            if (lstBaud.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn tốc độ Baud", "Thông báo");
            }
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                button2.Text = "Kết Nối";
            }
            else if (serialPort1.IsOpen == false)
            {
                serialPort1.PortName = lstCom.Text;
                serialPort1.BaudRate = int.Parse(lstBaud.Text);
                serialPort1.Open();
                button2.Text = "Ngắt kết nối";
            }
        }

        private void SavePictureOut(int i)
        {
            if (PictureOut.Image != null)
            {
                PictureOut.Image.Dispose();
                PictureOut.Image = null;
            }
            Image image = Camera.Image;
            image.Save(PictureOutSavePath + Convert.ToString(i) + ".jpg");
        }

        private void DisPlayPictureOut(int i)
        {

            PictureOut.Image = Image.FromFile(PictureOutSavePath + Convert.ToString(i) + ".jpg");
        }

        private void SavePictureIn(int i)
        {
            if (PictureIn.Image != null)
            {
                PictureIn.Image.Dispose();
                PictureIn.Image = null;
            }
            Image image = Camera.Image;
            image.Save(PictureInSavePath + Convert.ToString(i) + ".jpg");
        }

        private void DisPlayPictureIn(int i)
        {

            PictureIn.Image = Image.FromFile(PictureInSavePath + Convert.ToString(i) + ".jpg");
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
        }
        /******************************************************************************************************/

        /*****************************************UART Receive Event**********************************************/
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            counterOfSTT++;
            int i = 0;
            string data = serialPort1.ReadExisting();
            string[] dataList = data.Split(',');    //Tách chuỗi nhận được thành 2 chuỗi ngăn cách bởi dấu phẩy
            UID.Text = dataList[0];
            for (i = 0; i < UID_Key.Length; i++)
            {   
                //Nếu thẻ đúng
                if (dataList[0] == UID_Key[i])
                {   
                    //Nếu xe đang ở trong kho
                    if (truckState[i] == false)
                    {

                        //Nếu ảnh ở pictrurebox1 không trống
                        if (pictureBox1.Image != null)
                        {
                            pictureBox1.Image.Dispose();
                            pictureBox1.Image = null;
                        }
                        //Hiển thị thông tin của nhân viên
                        pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Resources\\" + Convert.ToString(i) + ".jpg");

                        //Nếu Camera đang hoạt động
                        if (cam != null && cam.IsRunning)
                        {
                            SavePictureOut(i);      //Lưu ảnh xe ra
                        }
                        DisPlayPictureOut(i);       //Hiển thị ảnh xe ra
                        PrintNewItem(i, counterOfSTT, truckState[i], dataList[1]);
                        truckState[i] = true;       //Chuyển trạng thái xe ứng với mã số nhân viên thành ra khỏi kho
                    }
                    else
                    {   

                        ////Nếu ảnh ở pictrurebox1 không trống
                        if (pictureBox1.Image != null)
                        {
                            pictureBox1.Image.Dispose();
                            pictureBox1.Image = null;
                        }
                        //Hiển thị thông tin của nhân viên
                        pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Resources\\" + Convert.ToString(i) + ".jpg");

                        //Nếu Camera đang hoạt động
                        if (cam != null && cam.IsRunning)
                        {
                            SavePictureIn(i);       //Lưu ảnh xe ra
                        }   
                        DisPlayPictureIn(i);        //Hiển thị ảnh xe vào
                        PrintNewItem(i, counterOfSTT, truckState[i], dataList[1]);
                        truckState[i] = false;      //Chuyển trạng thái xe ứng với mã số nhân viên thành đi vào kho
                    }
                }
            }
        }
        /**********************************************************************************************************************/

        private void Map_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private async void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
