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
        //private Datos datos = new Datos();
        private int id;
            byte editar = 1;
        public TiposEntidadesPopup()
        {
            InitializeComponent();

        }

        private void clearControls()
        {
            txtComentario.Clear();
            txtDescripcion.Clear();
            textBox1.Clear();
            
            statusCheckBox.Checked = false;
            eliminableCheckBox.Checked = false;
            dateTimePicker1.Value = DateTime.Today;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            string status = "Inactiva";
            int noEliminable = 0;
            if (statusCheckBox.Checked) status = "Activa";
            if (eliminableCheckBox.Checked) noEliminable = 1;

            try {
                if (editar == 0)
                {
                    datos.InsertarTiposEntidades(txtDescripcion.Text, Convert.ToInt32(comboBox1.Text), txtComentario.Text, status, noEliminable, Convert.ToDateTime(dateTimePicker1.Value));
                    
                }

                else
                {
                    try
                    {
                        datos.UpdateTiposEntidades(id, txtDescripcion.Text, Convert.ToInt32(comboBox1.Text), txtComentario.Text, status, noEliminable, Convert.ToDateTime(dateTimePicker1.Value));
                        editar = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("no se pudo insertar los datos por: " + ex);
                    }
                    
                }

                clearControls();
                dataGridView1.DataSource = datos.ListarTiposEntidades();

            }
            catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
        }

        private void TiposEntidadesPopup_Load(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            dataGridView1.DataSource = datos.ListarTiposEntidades();

            
            comboBox1.DataSource = datos.cargarComboBox();
            comboBox1.ValueMember = Datos.Value;
            comboBox1.DisplayMember = Datos.Value;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clearControls();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Datos datos = new Datos();
                textBox1.Text = dataGridView1.CurrentRow.Cells["IdTipoEntidad"].Value.ToString();
                datos.EliminarTiposEntidades(Convert.ToInt32(textBox1.Text));
                MessageBox.Show("Eliminado correctamente");
                
                dataGridView1.DataSource = datos.ListarTiposEntidades();
            }
            else
                MessageBox.Show("seleccione una fila por favor");

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            try
            {   
                dataGridView1.DataSource = datos.BuscarTiposEntidades(Convert.ToInt32(textBox1.Text));
                clearControls();

                if (dataGridView1.RowCount <= 1)
                {
                    MessageBox.Show("no se encontro ningun archivo, revise el nombre y vuelvalo a escribir");
                    Datos datos1 = new Datos();
                    dataGridView1.DataSource = datos1.ListarTiposEntidades();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo insertar los datos por: " + ex);
                dataGridView1.DataSource = datos.ListarTiposEntidades();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            editar = 1;
            id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdTipoEntidad"].Value.ToString());
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["FechaRegistro"].Value.ToString());
            txtComentario.Text = dataGridView1.CurrentRow.Cells["Comentario"].Value.ToString();
            txtDescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells["IdGrupoEntidad"].Value.ToString();

            if (dataGridView1.CurrentRow.Cells["Estatus"].Value.ToString() == "Activa")
                statusCheckBox.Checked = true;

            else
                statusCheckBox.Checked = false;

            if (dataGridView1.CurrentRow.Cells["NoEliminable"].Value.ToString() == "1")
                eliminableCheckBox.Checked = true;

            else
                eliminableCheckBox.Checked = false;
        }
    }
}
