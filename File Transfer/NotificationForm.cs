using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Transfer
{
    public partial class NotificationForm : Form
    {
        string name, IP;
        public NotificationForm(string name, string IP)
        {
            InitializeComponent();
            this.name = name;
            this.IP = IP;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double previousbytessend = 0;
            double uploadspeed;
            IPv4InterfaceStatistics interfaceStats;
            interfaceStats = NetworkInterface.GetAllNetworkInterfaces()[0].GetIPv4Statistics();
            uploadspeed = (interfaceStats.BytesSent - previousbytessend) / 1024;
            previousbytessend = (double)NetworkInterface.GetAllNetworkInterfaces()[0].GetIPv4Statistics().BytesSent;
            txtSpeed.Text = "Upload Speed: "+ Math.Round(uploadspeed / 1024, 2) + " MB/s";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            notificationTempLabel.Text = "File sending to " + IP + " " + name + "...";
            timer1.Start();
        }
    }
}
