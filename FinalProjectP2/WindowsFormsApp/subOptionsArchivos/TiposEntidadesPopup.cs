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

        Datos datos = new Datos();
        public TiposEntidadesPopup()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string status = "Inactivo";
            int noEliminable = 0;
            if (statusCheckBox.Checked) status = "Activo";
            if (EliminableCheckBox.Checked) noEliminable = 1;
            //Obtener el ID de el comboBox
            datos.InsertarTiposEntidades(txtDescripcion.Text,Convert.ToInt32(ComboBoxID.Text), txtComentario.Text, status, noEliminable, txtFecha.Text);
        }
    }
}
