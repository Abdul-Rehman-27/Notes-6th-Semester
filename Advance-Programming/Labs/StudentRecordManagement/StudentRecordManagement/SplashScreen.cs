using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentRecordManagement
{
    public partial class SplashScreen : Form
    {
        Timer tmr;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            tmr = new Timer();
            tmr.Interval = 30;        // fires every 30ms → 100 steps = ~3 seconds
            tmr.Tick += tmr_Tick;
            tmr.Start();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {


        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            // increase progress bar by 1 each tick
            progressBar1.Value += 1;
            labelPercent.Text = progressBar1.Value + "%";

            // when bar reaches 100 stop timer and open LoginForm
            if (progressBar1.Value >= 100)
            {
                tmr.Stop();
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }
    }
}
