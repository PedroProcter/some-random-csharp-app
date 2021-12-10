using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.subOptionsSistema;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gruposEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GruposEntidadesPopup grupoEntidades = new GruposEntidadesPopup();
            grupoEntidades.Visible = true;
            grupoEntidades.Activate();
        }

        private void tiposEntidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiposEntidadesPopup tiposEntidades = new TiposEntidadesPopup();
            tiposEntidades.Visible = true;
            tiposEntidades.Activate();
        }

        private void entidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntidadesPopup entidades = new EntidadesPopup();
            entidades.Visible = true;
            entidades.Activate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongTimeString();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acercade acercade1 = new Acercade();
            acercade1.Show();
        }

     

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Ha salido del sistema");
            this.Close();
        }
    }
}
