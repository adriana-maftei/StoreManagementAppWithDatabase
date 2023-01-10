using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicShop
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        int startPosition = 0;

        private void timer_Tick(object sender, EventArgs e)
        {
            startPosition++;
            progressBar.Value= startPosition;
            loadingPercentage.Text = "Loading " + startPosition + "%";

            if(progressBar.Value == 100 )
            {
                progressBar.Value = 0;
                timer.Stop();
                Login log = new Login();
                this.Hide();
                log.Show();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
