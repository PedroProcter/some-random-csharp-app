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

            int old_count = dataGridView1.Rows.Count;

            datos.InsertarGruposEntidades(descripcionTextBox.Text, ComentarioTextBox.Text, status, noEliminable, fechaRegistroDatePicker.Text);
            updateDataGridView();

            if (dataGridView1.Rows.Count != old_count)
            {
                MessageBox.Show("Row Inserted Sucessfully...");
            }
            else
            {
                MessageBox.Show("ERROR: Row not inserted");
            }

            
        }

        private void clearControlsButton_Click(object sender, EventArgs e)
        {
            clearControls();
        }

        private void GruposEntidadesPopup_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sellPointDataSet.GruposEntidades' Puede moverla o quitarla según sea necesario.
            this.gruposEntidadesTableAdapter.Fill(this.sellPointDataSet.GruposEntidades);
        }

        private void deleteGrupoEntidadButton_Click(object sender, EventArgs e)
        {
            int old_count = dataGridView1.Rows.Count;
            try {
                datos.EliminarGruposEntidades(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                updateDataGridView();
            } catch (Exception ex){

                MessageBox.Show("ERROR: Row not deleted" + ex);
            }

            if (dataGridView1.Rows.Count != old_count)
            {
                MessageBox.Show("Row Deleted Sucessfully...");
            }
            else
            {
                MessageBox.Show("ERROR: Row not deleted");
            }

           
        }

        private void updateDataGridView() {
            this.gruposEntidadesTableAdapter.Fill(this.sellPointDataSet.GruposEntidades);
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

            try {
                datos.UpdateGruposEntidades(Convert.ToInt32(idGrupoEntidadTextBox.Text), descripcionTextBox.Text, ComentarioTextBox.Text, status, noEliminable, fechaRegistroDatePicker.Text);
                updateDataGridView();

                MessageBox.Show("Row Modify Sucessfully...");
            } catch {
                MessageBox.Show("ERROR: Row Not Inserted...");
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0) {
                DataGridViewCellCollection row = dataGridView1.SelectedRows[0].Cells;

                bool status = false;
                bool eliminable = false;
                if (row[3].Value.ToString() == "Activa") status = true;
                if (row[4].Value.ToString() == "1") eliminable = true;

                idGrupoEntidadTextBox.Text = row[0].Value.ToString();
                descripcionTextBox.Text = row[1].Value.ToString();
                ComentarioTextBox.Text = row[2].Value.ToString();
                statusCheckBox.Checked = status;
                eliminableCheckBox.Checked = eliminable;
                fechaRegistroDatePicker.Value = DateTime.Parse(row[5].Value.ToString());
            }
            
        }
    }
}
