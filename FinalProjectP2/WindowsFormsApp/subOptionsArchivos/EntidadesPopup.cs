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

namespace WindowsFormsApp
{
    public partial class EntidadesPopup : Form
    {
        private Datos datos = new Datos();
        private CNegocio negocio = new CNegocio();
        byte editar= 0;
        int id=0;


        public EntidadesPopup()
        {
            InitializeComponent();
        }

        private void clearControls()
        {
            //limpiar combo box

            txtDescripcion.Clear();
            txtDireccion.Clear();
            txtLocalidad.Clear();
           // cbIdTipoEntidad.Clear();
            //cbTipoDocumento.Clear();
            txtNumDocumento.Clear();
            txtTelefono.Clear();
            txtWeb.Clear();
            txtFacebook.Clear();
            txtInstagram.Clear();
            txtTwitter.Clear();
            txtTikTok.Clear();
            //cbIdGrupoEntidad.Clear();
            //cbIdTipoEntidad.
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
            string Rol = "User"; //crearle sentencias if segun cada opcion
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
                        datos.InsertarEntidades(txtDescripcion.Text, txtDireccion.Text, txtLocalidad.Text, cbTipoEntidad.Text, cbTipoDocumento.Text, Convert.ToInt32(txtNumDocumento.Text), txtTelefono.Text, txtWeb.Text, txtFacebook.Text, txtInstagram.Text, txtTwitter.Text, txtTikTok.Text, Convert.ToInt32(cbIdGrupoEntidad.Text), Convert.ToInt32(cbIdTipoEntidad.Text), Convert.ToInt32(txtLimiteCredito.Text), txtUserName.Text, txtPassword.Text, Rol, txtComentario.Text, status, noEliminable, Convert.ToDateTime(dateTimePicker1.Value));
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
                            datos.UpdateEntidades(id, txtDescripcion.Text, txtDireccion.Text, txtLocalidad.Text, cbTipoEntidad.Text, cbTipoDocumento.Text, Convert.ToInt32(txtNumDocumento.Text), txtTelefono.Text, txtWeb.Text, txtFacebook.Text, txtInstagram.Text, txtTwitter.Text, txtTikTok.Text, Convert.ToInt32(cbIdGrupoEntidad.Text), Convert.ToInt32(cbIdTipoEntidad.Text), Convert.ToInt32(txtLimiteCredito.Text), txtUserName.Text, txtPassword.Text, Rol, txtComentario.Text, status, noEliminable, Convert.ToDateTime(dateTimePicker1.Value));
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

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

        private void cbTipoEntidad_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            datos.cargarComboBox2(Convert.ToInt32(cbIdGrupoEntidad.Text));

                cbIdTipoEntidad.ValueMember = Datos.Value2 ;
                cbIdTipoEntidad.DisplayMember = Datos.Value2;
        }

        private void cbIdTipoEntidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Datos datos = new Datos();

            datos.cargarComboBox2(Convert.ToInt32(cbIdGrupoEntidad.Text));

            //cbIdTipoEntidad.ValueMember = Datos.Value2;
            cbIdTipoEntidad.DisplayMember = Datos.Value2;
        }

        private void cbIdGrupoEntidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
