using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_5_SplashScreen
{
    public partial class SplashScreen : Form
    {
        Timer tmr;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.StartPosition = FormStartPosition.CenterScreen;
            //pictureBox1.Image = Image.FromFile(@"C:\Users\HEC\Pictures\Pitures\WhatsApp Image 2025-05-31 at 8.24.56 AM.jpeg");
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
           
            tmr = new Timer();

            //set time interval 3 sec
            tmr.Interval = 3000;

            //starts the timer
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }

        private void tmr_Tick(object sender, EventArgs e)
        {

            //after 3 sec stop the timer
            tmr.Stop();

            //display mainform
            Form1 f1 = new Form1();
            f1.Show();

            this.Hide();
        }

    }
}