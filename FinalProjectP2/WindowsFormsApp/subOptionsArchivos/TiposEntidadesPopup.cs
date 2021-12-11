using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace WindowsFormsApp
{
    public partial class TiposEntidadesPopup : Form
    {
        private Datos datos = new Datos();
        public TiposEntidadesPopup()
        {
            InitializeComponent();
        }

        private void clearControls()
        {
            //descripcionTextBox.Text = "";
            //ComentarioTextBox.Text = "";
            //statusCheckBox.Checked = false;
            //eliminableCheckBox.Checked = false;
            //fechaRegistroDatePicker.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string status = "Inactiva";
            int noEliminable = 0;
            if (statusCheckBox.Checked) status = "Activa";
            if (eliminableCheckBox.Checked) noEliminable = 1;
            //boton de guardar
        }

        private void TiposEntidadesPopup_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = datos.ListarTiposEntidades();
        }
    }
}
