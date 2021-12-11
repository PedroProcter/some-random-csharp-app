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
    public partial class EntidadesPopup : Form
    {
        Datos datos = new Datos();
        public EntidadesPopup()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string status = "Inactivo";
            int noEliminable = 0;
            if (StatuscheckBox.Checked) status = "Activo";
            if (NoEliminablecheckBox.Checked) noEliminable = 1;
            datos.InsertarEntidades(txtDescripcion.Text, 
                txtDireccion.Text,
                txtLocalidad.Text,
                TipoEntidadCombo.Text,
                TipoDocumentoCombo.Text,
                Convert.ToInt32(txtNDocumento.Text),
                txtTelefono.Text, 
                txtUrlPag.Text,
                txtUrlFacebook.Text,
                txtUrlInstagram.Text,
                txtUrlTwitter.Text,
                txtUrlTiktok.Text,
                Convert.ToInt32(GrupocomboBox.Text),
                Convert.ToInt32(txtIdEntidad.Text), 
                Convert.ToInt32(txtLimiteCredito.Text),
                txtUsername.Text,
                txtPassEntidad.Text,
                RolCombo.Text,
                txtComentario.Text, 
                StatuscheckBox.Text, 
                Convert.ToInt32(NoEliminablecheckBox.Text),
                txtFecha.Text);
        }

        private void EntidadesPopup_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
