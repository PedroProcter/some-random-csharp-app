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
        private Datos datos = new Datos();


        public EntidadesPopup()
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

        private void EntidadesPopup_Load(object sender, EventArgs e)
        {
            gridEntidades.DataSource = datos.ListarEntidades();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string status = "Inactiva";
            int noEliminable = 0;
            if (statusCheckBox.Checked) status = "Activa";
            if (eliminableCheckBox.Checked) noEliminable = 1;
            //este es el boton de guardar
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            editar = 1;
            id = Convert.ToInt32(gridEntidades.CurrentRow.Cells["IdTipoEntidad"].Value.ToString());
            dateTimePicker1.Value = Convert.ToDateTime(gridEntidades.CurrentRow.Cells["FechaRegistro"].Value.ToString());
            txtComentario.Value = gridEntidades.CurrentRow.Cells["Comentario"].Value.ToString();
            txtDescripcion.Value = gridEntidades.CurrentRow.Cells["Descripcion"].Value.ToString();
            cbIdTipoEntidad.Value= Convert.ToInt32(gridEntidades.CurrentRow.Cells["IdGrupoEntidad"].Value.ToString());
            txtDireccion.Value = gridEntidades.CurrentRow.Cells["Direccion"].Value.ToString();
            txtLocalidad.Value = gridEntidades.CurrentRow.Cells["Localidad"].Value.ToString();
            cbTipoDocumento.Value = Convert.ToInt32(gridEntidades.CurrentRow.Cells["TipoDocumento"].Value.ToString());
            txtTelefono.Value = gridEntidades.CurrentRow.Cells["Telefonos"].Value.ToString();
            txtWeb.Value = gridEntidades.CurrentRow.Cells["URLPaginaWeb"].Value.ToString();
            txtFacebook.Value = gridEntidades.CurrentRow.Cells["URLFacebook"].Value.ToString();
            txtInstagram.Value = gridEntidades.CurrentRow.Cells["URLInstagram"].Value.ToString();
            txtTwitter.Value = gridEntidades.CurrentRow.Cells["URLTwitter"].Value.ToString();
            txtTikTok.Value = gridEntidades.CurrentRow.Cells["URLTikTok"].Value.ToString();
            txtUserName.Value = gridEntidades.CurrentRow.Cells["UserNameEntidad"].Value.ToString();
            txtPassword.Value = gridEntidades.CurrentRow.Cells["PassworEntidad"].Value.ToString();
            status.Value = gridEntidades.CurrentRow.Cells["Estatus"].Value.ToString();
            txtNumDocumento.Value= Convert.ToInt32(gridEntidades.CurrentRow.Cells["NumeroDocumento"].Value.ToString());
            noEliminable.Value = Convert.ToInt32(gridEntidades.CurrentRow.Cells["NoEliminable"].Value.ToString());
            txtLimiteCredito.Value= Convert.ToInt32(gridEntidades.CurrentRow.Cells["LimiteCredito"].Value.ToString());
            cbIdGrupoEntidad.Value =Convert.ToInt32( gridEntidades.CurrentRow.Cells["IdGrupoEntidad"].Value.ToString());
            if (gridEntidades.CurrentRow.Cells["Estatus"].Value.ToString() == "Activa")
                statusCheckBox.Checked = true;

            else
                statusCheckBox.Checked = false;

            if (gridEntidades.CurrentRow.Cells["NoEliminable"].Value.ToString() == "1")
                eliminableCheckBox.Checked = true;

            else
                eliminableCheckBox.Checked = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
