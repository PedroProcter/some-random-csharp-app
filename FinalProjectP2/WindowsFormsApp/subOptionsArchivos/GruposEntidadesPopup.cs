using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class GruposEntidadesPopup : Form
    {
        private Datos datos = new Datos();
        public GruposEntidadesPopup()
        {
            InitializeComponent();
        }

        private void clearControls() {
            descripcionTextBox.Text = "";
            ComentarioTextBox.Text = "";
            statusCheckBox.Checked = false;
            eliminableCheckBox.Checked = false;
            fechaRegistroDatePicker.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string status = "Inactivo";
            int noEliminable = 0;
            if (statusCheckBox.Checked) status = "Activo";
            if (eliminableCheckBox.Checked) noEliminable = 1;
            datos.InsertarGruposEntidades(descripcionTextBox.Text, ComentarioTextBox.Text, status, noEliminable, fechaRegistroDatePicker.Text);
        }

        private void clearControlsButton_Click(object sender, EventArgs e)
        {
            clearControls();
        }
    }
}
