using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        string latitude;
        string longitude;
        string[] lci_Plate_arr = { "37L - 00029", "29X - 89898", "NY - 888.88", "29X1 - 444.44"};
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "XpG3HiAbNsb0PKF9pMVmfkpWHWvHk16enIATyL2O",
            BasePath = "https://staffdatabase2-9d424-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        public Form2()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);
            lstLcience.Items.AddRange(lci_Plate_arr);
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            FirebaseResponse resp2 = await client.GetTaskAsync("Staff/" + Convert.ToString(1));
            GPSLocation obj2 = resp2.ResultAs<GPSLocation>();
            latitude = Convert.ToString(obj2.latitude);
            longitude = Convert.ToString(obj2.longitude);
            if (latitude== string.Empty || longitude == string.Empty)
            {
                this.Dispose();
            }
            try
            {
                drawMap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void drawMap()
        {
            StringBuilder queryAddress = new StringBuilder();
            
            string OfficeAddress = "'20.972446,105.8177103'/";
            queryAddress.Append("http://maps.google.com/maps/dir/" + OfficeAddress);
            if (latitude != string.Empty)
            {
                queryAddress.Append(latitude + ",");
            }
            if (longitude != string.Empty)
            {
                queryAddress.Append(longitude + "/");
            }
            webBrowser1.Navigate(queryAddress.ToString());
        }

        private async void getGpsLocation()
        {
            int i = 0;
            for(i = 0; i < 3; i++)
            {
                if (lci_Plate_arr[i] == lstLcience.Text)
                    break;
            }
            if(StaffPic.Image != null)
            {
                StaffPic.Image.Dispose();
                StaffPic.Image = null;
            }
            StaffPic.Image = new Bitmap(Application.StartupPath + "\\Resources\\" + Convert.ToString(i+1) + ".jpg");
            FirebaseResponse staffDb = await client.GetTaskAsync("Staff/" + Convert.ToString(i+1));
            //FirebaseResponse Staff_resp = await DataBase.GetTaskAsync(Convert.ToString(1));
            Staff staff = staffDb.ResultAs<Staff>();
            StaffName.Text = staff.Name;
            StaffID.Text = staff.StaffID;
            LciensePlate.Text = staff.LicensePlate;
            PhoneNumber.Text = staff.PhoneNumber;
            latitude = Convert.ToString(staff.latitude);
            longitude = Convert.ToString(staff.longitude);
            //Staff staff = Staff_resp.ResultAs<Staff>();
        }

        private void Connect_Click(object sender, EventArgs e)
        {   
            getGpsLocation();
            drawMap();
        }

    }

}
