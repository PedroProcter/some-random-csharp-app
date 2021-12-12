
namespace WindowsFormsApp
{
    partial class GruposEntidadesPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GruposEntidadesPopup));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clearControlsButton = new System.Windows.Forms.Button();
            this.fechaRegistroDatePicker = new System.Windows.Forms.DateTimePicker();
            this.modifyGrupoEntidadButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.eliminableCheckBox = new System.Windows.Forms.CheckBox();
            this.statusCheckBox = new System.Windows.Forms.CheckBox();
            this.ComentarioTextBox = new System.Windows.Forms.TextBox();
            this.descripcion_label = new System.Windows.Forms.Label();
            this.comentario_label = new System.Windows.Forms.Label();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.deleteGrupoEntidadButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idGrupoEntidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noEliminableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gruposEntidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellPointDataSet = new WindowsFormsApp.SellPointDataSet();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.findGrupoEntidadButton = new System.Windows.Forms.Button();
            this.idGrupoEntidadTextBox = new System.Windows.Forms.TextBox();
            this.gruposEntidadesTableAdapter = new WindowsFormsApp.SellPointDataSetTableAdapters.GruposEntidadesTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposEntidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellPointDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 31);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 432);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.clearControlsButton);
            this.tabPage1.Controls.Add(this.fechaRegistroDatePicker);
            this.tabPage1.Controls.Add(this.modifyGrupoEntidadButton);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.ComentarioTextBox);
            this.tabPage1.Controls.Add(this.descripcion_label);
            this.tabPage1.Controls.Add(this.comentario_label);
            this.tabPage1.Controls.Add(this.descripcionTextBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(742, 406);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modificador";
            // 
            // clearControlsButton
            // 
            this.clearControlsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            this.clearControlsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearControlsButton.Image = global::WindowsFormsApp.Properties.Resources.eliminar;
            this.clearControlsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearControlsButton.Location = new System.Drawing.Point(479, 353);
            this.clearControlsButton.Name = "clearControlsButton";
            this.clearControlsButton.Size = new System.Drawing.Size(75, 23);
            this.clearControlsButton.TabIndex = 30;
            this.clearControlsButton.Text = "Clear";
            this.clearControlsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearControlsButton.UseVisualStyleBackColor = false;
            this.clearControlsButton.Click += new System.EventHandler(this.clearControlsButton_Click);
            // 
            // fechaRegistroDatePicker
            // 
            this.fechaRegistroDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaRegistroDatePicker.Location = new System.Drawing.Point(21, 53);
            this.fechaRegistroDatePicker.Name = "fechaRegistroDatePicker";
            this.fechaRegistroDatePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fechaRegistroDatePicker.Size = new System.Drawing.Size(146, 20);
            this.fechaRegistroDatePicker.TabIndex = 29;
            // 
            // modifyGrupoEntidadButton
            // 
            this.modifyGrupoEntidadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            this.modifyGrupoEntidadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyGrupoEntidadButton.Image = global::WindowsFormsApp.Properties.Resources.editar_texto;
            this.modifyGrupoEntidadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modifyGrupoEntidadButton.Location = new System.Drawing.Point(561, 353);
            this.modifyGrupoEntidadButton.Name = "modifyGrupoEntidadButton";
            this.modifyGrupoEntidadButton.Size = new System.Drawing.Size(75, 23);
            this.modifyGrupoEntidadButton.TabIndex = 28;
            this.modifyGrupoEntidadButton.Text = "         Modify";
            this.modifyGrupoEntidadButton.UseVisualStyleBackColor = false;
            this.modifyGrupoEntidadButton.Click += new System.EventHandler(this.modifyGrupoEntidadButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::WindowsFormsApp.Properties.Resources.guardar_el_archivo;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(642, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Add";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.eliminableCheckBox);
            this.panel5.Controls.Add(this.statusCheckBox);
            this.panel5.Location = new System.Drawing.Point(21, 102);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(146, 46);
            this.panel5.TabIndex = 26;
            // 
            // eliminableCheckBox
            // 
            this.eliminableCheckBox.AutoSize = true;
            this.eliminableCheckBox.Location = new System.Drawing.Point(0, 26);
            this.eliminableCheckBox.Name = "eliminableCheckBox";
            this.eliminableCheckBox.Size = new System.Drawing.Size(87, 17);
            this.eliminableCheckBox.TabIndex = 29;
            this.eliminableCheckBox.Text = "NoEliminable";
            this.eliminableCheckBox.UseVisualStyleBackColor = true;
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.AutoSize = true;
            this.statusCheckBox.Location = new System.Drawing.Point(0, 3);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(56, 17);
            this.statusCheckBox.TabIndex = 28;
            this.statusCheckBox.Text = "Status";
            this.statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // ComentarioTextBox
            // 
            this.ComentarioTextBox.Location = new System.Drawing.Point(479, 53);
            this.ComentarioTextBox.Multiline = true;
            this.ComentarioTextBox.Name = "ComentarioTextBox";
            this.ComentarioTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ComentarioTextBox.Size = new System.Drawing.Size(238, 281);
            this.ComentarioTextBox.TabIndex = 25;
            // 
            // descripcion_label
            // 
            this.descripcion_label.AutoSize = true;
            this.descripcion_label.Location = new System.Drawing.Point(198, 37);
            this.descripcion_label.Name = "descripcion_label";
            this.descripcion_label.Size = new System.Drawing.Size(63, 13);
            this.descripcion_label.TabIndex = 22;
            this.descripcion_label.Text = "Descripcion";
            // 
            // comentario_label
            // 
            this.comentario_label.AutoSize = true;
            this.comentario_label.Location = new System.Drawing.Point(476, 37);
            this.comentario_label.Name = "comentario_label";
            this.comentario_label.Size = new System.Drawing.Size(60, 13);
            this.comentario_label.TabIndex = 24;
            this.comentario_label.Text = "Comentario";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(201, 53);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descripcionTextBox.Size = new System.Drawing.Size(238, 281);
            this.descripcionTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Registro";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.deleteGrupoEntidadButton);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(742, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visualizador";
            // 
            // deleteGrupoEntidadButton
            // 
            this.deleteGrupoEntidadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteGrupoEntidadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            this.deleteGrupoEntidadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteGrupoEntidadButton.Image = global::WindowsFormsApp.Properties.Resources.eliminar;
            this.deleteGrupoEntidadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteGrupoEntidadButton.Location = new System.Drawing.Point(661, 377);
            this.deleteGrupoEntidadButton.Name = "deleteGrupoEntidadButton";
            this.deleteGrupoEntidadButton.Size = new System.Drawing.Size(75, 23);
            this.deleteGrupoEntidadButton.TabIndex = 30;
            this.deleteGrupoEntidadButton.Text = "Delete";
            this.deleteGrupoEntidadButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteGrupoEntidadButton.UseVisualStyleBackColor = false;
            this.deleteGrupoEntidadButton.Click += new System.EventHandler(this.deleteGrupoEntidadButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGrupoEntidadDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.comentarioDataGridViewTextBoxColumn,
            this.estatusDataGridViewTextBoxColumn,
            this.noEliminableDataGridViewTextBoxColumn,
            this.fechaRegistroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gruposEntidadesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(736, 400);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // idGrupoEntidadDataGridViewTextBoxColumn
            // 
            this.idGrupoEntidadDataGridViewTextBoxColumn.DataPropertyName = "IdGrupoEntidad";
            this.idGrupoEntidadDataGridViewTextBoxColumn.HeaderText = "IdGrupoEntidad";
            this.idGrupoEntidadDataGridViewTextBoxColumn.Name = "idGrupoEntidadDataGridViewTextBoxColumn";
            this.idGrupoEntidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            this.comentarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus";
            this.estatusDataGridViewTextBoxColumn.HeaderText = "Estatus";
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            this.estatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noEliminableDataGridViewTextBoxColumn
            // 
            this.noEliminableDataGridViewTextBoxColumn.DataPropertyName = "NoEliminable";
            this.noEliminableDataGridViewTextBoxColumn.HeaderText = "NoEliminable";
            this.noEliminableDataGridViewTextBoxColumn.Name = "noEliminableDataGridViewTextBoxColumn";
            this.noEliminableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaRegistroDataGridViewTextBoxColumn
            // 
            this.fechaRegistroDataGridViewTextBoxColumn.DataPropertyName = "FechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn.HeaderText = "FechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn.Name = "fechaRegistroDataGridViewTextBoxColumn";
            this.fechaRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gruposEntidadesBindingSource
            // 
            this.gruposEntidadesBindingSource.DataMember = "GruposEntidades";
            this.gruposEntidadesBindingSource.DataSource = this.sellPointDataSet;
            // 
            // sellPointDataSet
            // 
            this.sellPointDataSet.DataSetName = "SellPointDataSet";
            this.sellPointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.42105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.57895F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 418F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.findGrupoEntidadButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.idGrupoEntidadTextBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(754, 30);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grupos de Entidades";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // findGrupoEntidadButton
            // 
            this.findGrupoEntidadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findGrupoEntidadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(89)))));
            this.findGrupoEntidadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findGrupoEntidadButton.Image = global::WindowsFormsApp.Properties.Resources.buscar;
            this.findGrupoEntidadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findGrupoEntidadButton.Location = new System.Drawing.Point(3, 3);
            this.findGrupoEntidadButton.Name = "findGrupoEntidadButton";
            this.findGrupoEntidadButton.Size = new System.Drawing.Size(40, 24);
            this.findGrupoEntidadButton.TabIndex = 0;
            this.findGrupoEntidadButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.findGrupoEntidadButton.UseVisualStyleBackColor = false;
            this.findGrupoEntidadButton.Click += new System.EventHandler(this.findGrupoEntidadButton_Click);
            // 
            // idGrupoEntidadTextBox
            // 
            this.idGrupoEntidadTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idGrupoEntidadTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idGrupoEntidadTextBox.Location = new System.Drawing.Point(49, 3);
            this.idGrupoEntidadTextBox.Name = "idGrupoEntidadTextBox";
            this.idGrupoEntidadTextBox.Size = new System.Drawing.Size(111, 20);
            this.idGrupoEntidadTextBox.TabIndex = 1;
            // 
            // gruposEntidadesTableAdapter
            // 
            this.gruposEntidadesTableAdapter.ClearBeforeFill = true;
            // 
            // GruposEntidadesPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 462);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GruposEntidadesPopup";
            this.Text = "GruposEntidades";
            this.Load += new System.EventHandler(this.GruposEntidadesPopup_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposEntidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellPointDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findGrupoEntidadButton;
        private System.Windows.Forms.TextBox idGrupoEntidadTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ComentarioTextBox;
        private System.Windows.Forms.Label descripcion_label;
        private System.Windows.Forms.Label comentario_label;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox eliminableCheckBox;
        private System.Windows.Forms.CheckBox statusCheckBox;
        private System.Windows.Forms.Button modifyGrupoEntidadButton;
        private System.Windows.Forms.Button deleteGrupoEntidadButton;
        private System.Windows.Forms.DateTimePicker fechaRegistroDatePicker;
        private System.Windows.Forms.Button clearControlsButton;
        private SellPointDataSet sellPointDataSet;
        private System.Windows.Forms.BindingSource gruposEntidadesBindingSource;
        private SellPointDataSetTableAdapters.GruposEntidadesTableAdapter gruposEntidadesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGrupoEntidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noEliminableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistroDataGridViewTextBoxColumn;
    }
}