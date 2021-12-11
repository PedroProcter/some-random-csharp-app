
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clearControlsButton = new System.Windows.Forms.Button();
            this.fechaRegistroDatePicker = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.eliminableCheckBox = new System.Windows.Forms.CheckBox();
            this.statusCheckBox = new System.Windows.Forms.CheckBox();
            this.ComentarioTextBox = new System.Windows.Forms.TextBox();
            this.descripcion_label = new System.Windows.Forms.Label();
            this.comentario_label = new System.Windows.Forms.Label();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id_grupo_entidad_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(-1, 38);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 556);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.clearControlsButton);
            this.tabPage1.Controls.Add(this.fechaRegistroDatePicker);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.ComentarioTextBox);
            this.tabPage1.Controls.Add(this.descripcion_label);
            this.tabPage1.Controls.Add(this.comentario_label);
            this.tabPage1.Controls.Add(this.descripcionTextBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.id_grupo_entidad_textBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(992, 527);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modificador";
            // 
            // clearControlsButton
            // 
            this.clearControlsButton.Location = new System.Drawing.Point(643, 473);
            this.clearControlsButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearControlsButton.Name = "clearControlsButton";
            this.clearControlsButton.Size = new System.Drawing.Size(100, 28);
            this.clearControlsButton.TabIndex = 30;
            this.clearControlsButton.Text = "Clear";
            this.clearControlsButton.UseVisualStyleBackColor = true;
            this.clearControlsButton.Click += new System.EventHandler(this.clearControlsButton_Click);
            // 
            // fechaRegistroDatePicker
            // 
            this.fechaRegistroDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaRegistroDatePicker.Location = new System.Drawing.Point(32, 169);
            this.fechaRegistroDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.fechaRegistroDatePicker.Name = "fechaRegistroDatePicker";
            this.fechaRegistroDatePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fechaRegistroDatePicker.Size = new System.Drawing.Size(193, 22);
            this.fechaRegistroDatePicker.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(752, 473);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 28;
            this.button3.Text = "Modify";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(860, 473);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 27;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.eliminableCheckBox);
            this.panel5.Controls.Add(this.statusCheckBox);
            this.panel5.Location = new System.Drawing.Point(32, 393);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(160, 57);
            this.panel5.TabIndex = 26;
            // 
            // eliminableCheckBox
            // 
            this.eliminableCheckBox.AutoSize = true;
            this.eliminableCheckBox.Location = new System.Drawing.Point(0, 32);
            this.eliminableCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.eliminableCheckBox.Name = "eliminableCheckBox";
            this.eliminableCheckBox.Size = new System.Drawing.Size(112, 21);
            this.eliminableCheckBox.TabIndex = 29;
            this.eliminableCheckBox.Text = "NoEliminable";
            this.eliminableCheckBox.UseVisualStyleBackColor = true;
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.AutoSize = true;
            this.statusCheckBox.Location = new System.Drawing.Point(0, 4);
            this.statusCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(70, 21);
            this.statusCheckBox.TabIndex = 28;
            this.statusCheckBox.Text = "Status";
            this.statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // ComentarioTextBox
            // 
            this.ComentarioTextBox.Location = new System.Drawing.Point(643, 103);
            this.ComentarioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ComentarioTextBox.Multiline = true;
            this.ComentarioTextBox.Name = "ComentarioTextBox";
            this.ComentarioTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ComentarioTextBox.Size = new System.Drawing.Size(316, 345);
            this.ComentarioTextBox.TabIndex = 25;
            // 
            // descripcion_label
            // 
            this.descripcion_label.AutoSize = true;
            this.descripcion_label.Location = new System.Drawing.Point(268, 84);
            this.descripcion_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descripcion_label.Name = "descripcion_label";
            this.descripcion_label.Size = new System.Drawing.Size(82, 17);
            this.descripcion_label.TabIndex = 22;
            this.descripcion_label.Text = "Descripcion";
            // 
            // comentario_label
            // 
            this.comentario_label.AutoSize = true;
            this.comentario_label.Location = new System.Drawing.Point(639, 84);
            this.comentario_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.comentario_label.Name = "comentario_label";
            this.comentario_label.Size = new System.Drawing.Size(80, 17);
            this.comentario_label.TabIndex = 24;
            this.comentario_label.Text = "Comentario";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(272, 103);
            this.descripcionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descripcionTextBox.Size = new System.Drawing.Size(316, 345);
            this.descripcionTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Registro";
            // 
            // id_grupo_entidad_textBox
            // 
            this.id_grupo_entidad_textBox.Location = new System.Drawing.Point(32, 103);
            this.id_grupo_entidad_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.id_grupo_entidad_textBox.Name = "id_grupo_entidad_textBox";
            this.id_grupo_entidad_textBox.Size = new System.Drawing.Size(193, 22);
            this.id_grupo_entidad_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Grupo Entidad";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(992, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visualizador";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(880, 487);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 30;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(979, 476);
            this.dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.42105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.57895F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 557F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1005, 37);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grupos de Entidades";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(69, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 22);
            this.textBox1.TabIndex = 1;
            // 
            // GruposEntidadesPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 593);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GruposEntidadesPopup";
            this.Text = "GruposEntidades";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id_grupo_entidad_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ComentarioTextBox;
        private System.Windows.Forms.Label descripcion_label;
        private System.Windows.Forms.Label comentario_label;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox eliminableCheckBox;
        private System.Windows.Forms.CheckBox statusCheckBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker fechaRegistroDatePicker;
        private System.Windows.Forms.Button clearControlsButton;
    }
}