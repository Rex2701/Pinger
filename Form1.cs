using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;

namespace Pinger
{
    public partial class MainWin : Form
    {
        public MainWin()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            bool result = CheckHost(Hostname.Text, Convert.ToInt16(PingTimeOut.Value));
            if (result == true) Hostname.BackColor = Color.LightGreen;
            else Hostname.BackColor = Color.White;
        }

        private bool CheckHost(string host, int timeout)
        {
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();
            options.DontFragment = true;
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            PingReply reply = pingSender.Send(host, timeout, buffer, options);
            if (reply.Status == IPStatus.Success) return true;
            else return false;
        }
    }
}