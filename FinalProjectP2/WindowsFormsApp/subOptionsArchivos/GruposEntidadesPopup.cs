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
            string status = "Inactiva";
            int noEliminable = 0;
            if (statusCheckBox.Checked) status = "Activa";
            if (eliminableCheckBox.Checked) noEliminable = 1;
            datos.InsertarGruposEntidades(descripcionTextBox.Text, ComentarioTextBox.Text, status, noEliminable, fechaRegistroDatePicker.Text);
            updateDataGridView();
        }

        private void clearControlsButton_Click(object sender, EventArgs e)
        {
            clearControls();
        }

        private void GruposEntidadesPopup_Load(object sender, EventArgs e)
        {
           dataGridView1.DataSource = datos.ListarGrupoEntidades();
        }

        private void deleteGrupoEntidadButton_Click(object sender, EventArgs e)
        {
            try {
                datos.EliminarGruposEntidades(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            } catch {
                
            }
            
            updateDataGridView();
        }

        private void updateDataGridView() {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            dataGridView1.DataSource = datos.ListarGrupoEntidades();
        }

        private void findGrupoEntidadButton_Click(object sender, EventArgs e)
        {
            string id = idGrupoEntidadTextBox.Text;
            DataTable dataTable = datos.BuscarGruposEntidades(int.Parse(id));

            foreach (DataRow row in dataTable.Rows) {
                bool status = false;
                bool eliminable = false;
                if (row["Estatus"].ToString() == "Activa") status = true;
                if (row["NoEliminable"].ToString() == "1") eliminable = true;

                descripcionTextBox.Text = row["Descripcion"].ToString();
                ComentarioTextBox.Text = row["Comentario"].ToString();
                statusCheckBox.Checked = status;
                eliminableCheckBox.Checked = eliminable;
                fechaRegistroDatePicker.Value = DateTime.Parse(row["FechaRegistro"].ToString());
            }
        }

        private void modifyGrupoEntidadButton_Click(object sender, EventArgs e)
        {
            string status = "Inactiva";
            int noEliminable = 0;
            if (statusCheckBox.Checked) status = "Activa";
            if (eliminableCheckBox.Checked) noEliminable = 1;

            datos.UpdateGruposEntidades(Convert.ToInt32(idGrupoEntidadTextBox.Text), descripcionTextBox.Text, ComentarioTextBox.Text, status, noEliminable, fechaRegistroDatePicker.Text);
            updateDataGridView();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
