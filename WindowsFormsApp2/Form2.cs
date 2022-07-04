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
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "am5lN8f15pMFlFU8q4FyCH6Jz6al5CNhNRec0IVk",
            BasePath = "https://gpslocation-d7c58-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;

        public Form2()
        {
            InitializeComponent();
            client = new FireSharp.FirebaseClient(config);

            timer1.Enabled = true;
            timer1.Start();
            timer2.Enabled = true;
            timer2.Start();
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            FirebaseResponse resp2 = await client.GetTaskAsync(Convert.ToString(1));
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            drawMap();
        }

        private async void timer2_Tick(object sender, EventArgs e)
        {
            FirebaseResponse resp2 = await client.GetTaskAsync(Convert.ToString(1));
            GPSLocation obj2 = resp2.ResultAs<GPSLocation>();
            latitude = Convert.ToString(obj2.latitude);
            longitude = Convert.ToString(obj2.longitude);
        }
    }

}
