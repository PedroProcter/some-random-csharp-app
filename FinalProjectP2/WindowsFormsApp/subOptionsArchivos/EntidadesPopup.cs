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
using Negocio;
using CapaPresentacion;

namespace WindowsFormsApp
{
    public partial class EntidadesPopup : Form
    {
        private Datos datos = new Datos();
        private CNegocio negocio = new CNegocio();
        private Presentacion presentacion = new Presentacion();
        byte editar= 0;
        int id;
        long numDocumento;


        public EntidadesPopup()
        {
            InitializeComponent();
        }

        private void clearControls()
        {

            txtDescripcion.Clear();
            txtDireccion.Clear();
            txtLocalidad.Clear();
            cbIdTipoEntidad.Text = "Selecciona un tipo";
            cbTipoDocumento.SelectedIndex= 0;
            txtNumDocumento.Clear();
            txtTelefono.Clear();
            txtWeb.Clear();
            txtFacebook.Clear();
            txtInstagram.Clear();
            txtTwitter.Clear();
            txtTikTok.Clear();
            cbIdGrupoEntidad.Text = "Selecciona un grupo";
            txtLimiteCredito.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtComentario.Clear();
            dateTimePicker1.Value = DateTime.Today;
        }

        public void MostrarTodo()
        {
            Datos dt = new Datos();
            dataGridView1.DataSource = dt.ListarEntidades();
        }

        private void EntidadesPopup_Load(object sender, EventArgs e)
        {
            MostrarTodo();

            cbIdGrupoEntidad.DataSource = datos.cargarComboBox();
            cbIdGrupoEntidad.ValueMember = Datos.Value;
            cbIdGrupoEntidad.DisplayMember = Datos.Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string status = "Inactiva";
            int noEliminable = 0;
            string Rol = "User"; 
            if (statusCheckBox.Checked) status = "Activa";
            if (eliminableCheckBox.Checked) noEliminable = 1;
            if (rbAdmin.Checked) Rol = "Admin";
            if (rbSupervisor.Checked) Rol = "supervisor";
            int limite = Convert.ToInt32(txtLimiteCredito.Text);

            try
            {
                if (editar == 0)
                {
                    if (Convert.ToInt32(negocio.ValidarLimiteCredito(limite)) > 0)
                     {
                        datos.InsertarEntidades(txtDescripcion.Text, txtDireccion.Text, txtLocalidad.Text, cbTipoEntidad.Text, cbTipoDocumento.Text, numDocumento, txtTelefono.Text, txtWeb.Text, txtFacebook.Text, txtInstagram.Text, txtTwitter.Text, txtTikTok.Text, Convert.ToInt32(cbIdGrupoEntidad.Text), Convert.ToInt32(cbIdTipoEntidad.Text), Convert.ToInt32(txtLimiteCredito.Text), txtUserName.Text, txtPassword.Text, Rol, txtComentario.Text, status, noEliminable, Convert.ToDateTime(dateTimePicker1.Value));
                    }
                     else
                        MessageBox.Show(negocio.ValidarLimiteCredito(limite));
                    

                }

                else
                {
                    try
                    {
                        if (Convert.ToInt32(negocio.ValidarLimiteCredito(limite)) > 0)
                        {
                            datos.UpdateEntidades(id, txtDescripcion.Text, txtDireccion.Text, txtLocalidad.Text, cbTipoEntidad.Text, cbTipoDocumento.Text, numDocumento, txtTelefono.Text, txtWeb.Text, txtFacebook.Text, txtInstagram.Text, txtTwitter.Text, txtTikTok.Text, Convert.ToInt32(cbIdGrupoEntidad.Text), Convert.ToInt32(cbIdTipoEntidad.Text), Convert.ToInt32(txtLimiteCredito.Text), txtUserName.Text, txtPassword.Text, Rol, txtComentario.Text, status, noEliminable, Convert.ToDateTime(dateTimePicker1.Value));
                            editar = 0;
                        }

                        else
                            MessageBox.Show(negocio.ValidarLimiteCredito(limite));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("no se pudo insertar los datos por: " + ex);
                        
                    }

                }

                clearControls();
                MostrarTodo();

            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo insertar los datos por: " + ex);
                
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                find_textBox.Text = dataGridView1.CurrentRow.Cells["IdEntidad"].Value.ToString();
                datos.EliminarEntidades(Convert.ToInt32(find_textBox.Text));
                MessageBox.Show("Eliminado correctamente");

                MostrarTodo();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                Datos datos1 = new Datos();
                dataGridView1.DataSource = datos1.BuscarEntidades(Convert.ToInt32(find_textBox.Text));
                clearControls();

                if (dataGridView1.RowCount <= 1)
                {
                    MessageBox.Show("no se encontro ningun archivo, revise el nombre y vuelvalo a escribir");
                    
                    MostrarTodo();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo continuar la busqueda porque: " + ex);
                MostrarTodo();
            }
        }

        private void txtNumDocumento_Leave(object sender, EventArgs e)
        {
            numDocumento = long.Parse(txtNumDocumento.Text);
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            txtNumDocumento.Text = presentacion.ConversionDatos(numDocumento, cbTipoDocumento.Text);
        }

        private void cbIdGrupoEntidad_Leave(object sender, EventArgs e)
        {
            Datos datos1 = new Datos();

               cbIdTipoEntidad.DataSource =  datos1.cargarComboBox2(Convert.ToInt32(cbIdGrupoEntidad.Text));

            cbIdTipoEntidad.ValueMember = Datos.Value2;
            cbIdTipoEntidad.DisplayMember = Datos.Value2;
        }

        private void btClean_Click(object sender, EventArgs e)
        {
            clearControls();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editar = 1;
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdTipoEntidad"].Value.ToString());
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["FechaRegistro"].Value.ToString());
            txtComentario.Text = dataGridView1.CurrentRow.Cells["Comentario"].Value.ToString();
            txtDescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
            cbIdTipoEntidad.Text = dataGridView1.CurrentRow.Cells["IdGrupoEntidad"].Value.ToString();
            txtDireccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
            txtLocalidad.Text = dataGridView1.CurrentRow.Cells["Localidad"].Value.ToString();
            cbTipoDocumento.Text = dataGridView1.CurrentRow.Cells["TipoDocumento"].Value.ToString();
            txtTelefono.Text = dataGridView1.CurrentRow.Cells["Telefonos"].Value.ToString();
            txtWeb.Text = dataGridView1.CurrentRow.Cells["URLPaginaWeb"].Value.ToString();
            txtFacebook.Text = dataGridView1.CurrentRow.Cells["URLFacebook"].Value.ToString();
            txtInstagram.Text = dataGridView1.CurrentRow.Cells["URLInstagram"].Value.ToString();
            txtTwitter.Text = dataGridView1.CurrentRow.Cells["URLTwitter"].Value.ToString();
            txtTikTok.Text = dataGridView1.CurrentRow.Cells["URLTikTok"].Value.ToString();
            txtUserName.Text = dataGridView1.CurrentRow.Cells["UserNameEntidad"].Value.ToString();
            txtPassword.Text = dataGridView1.CurrentRow.Cells["PassworEntidad"].Value.ToString();
            
            txtNumDocumento.Text = dataGridView1.CurrentRow.Cells["NumeroDocumento"].Value.ToString();
           
            txtLimiteCredito.Text = dataGridView1.CurrentRow.Cells["LimiteCredito"].Value.ToString();
            cbIdGrupoEntidad.Text = dataGridView1.CurrentRow.Cells["IdGrupoEntidad"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["Estatus"].Value.ToString() == "Activa")
                statusCheckBox.Checked = true;

            else
                statusCheckBox.Checked = false;

            if (dataGridView1.CurrentRow.Cells["NoEliminable"].Value.ToString() == "1")
                eliminableCheckBox.Checked = true;

            else
                eliminableCheckBox.Checked = false;
        }

        private void txtNumDocumento_Enter(object sender, EventArgs e)
        {
            if (cbTipoDocumento.Text == "RNC" || cbTipoDocumento.Text == "Cedula")
                txtNumDocumento.MaxLength = 14;
            else if (cbTipoDocumento.Text == "Pasaporte")
                txtNumDocumento.MaxLength = 10;
        }
    }
}
