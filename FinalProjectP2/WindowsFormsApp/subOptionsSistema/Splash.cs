using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.subOptionsSistema
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1500;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            while(this.Opacity> 0)
            {
                this.Opacity -= 0.0001; 
            }
            this.Hide();
            Form1 Principal = new Form1();
            Principal.Show();
            timer1.Stop();
        }
    }
}
