namespace CarHistory.form.Vehiculo
{
    partial class frmVehiModelo
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupLista = new GroupBox();
            dgridLista = new DataGridView();
            groupItem = new GroupBox();
            numVehiModeAnio = new NumericUpDown();
            btnFoto = new Button();
            picVehiModeImagen = new PictureBox();
            cmbVehiMarId = new ComboBox();
            cmbVehiCateId = new ComboBox();
            cmbVehiModeCombustible = new ComboBox();
            cmbVehiModeRodaje = new ComboBox();
            cmbVehiModeAro = new ComboBox();
            label9 = new Label();
            cmbVehiModeEstado = new ComboBox();
            label8 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtVehiModeDescripcion = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtInicio = new TextBox();
            txtVehiModeNombre = new TextBox();
            label1 = new Label();
            picInicio = new PictureBox();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            vehiModeId = new DataGridViewTextBoxColumn();
            vehiModeNombre = new DataGridViewTextBoxColumn();
            vehiModeRodaje = new DataGridViewTextBoxColumn();
            vehiMarNombre = new DataGridViewTextBoxColumn();
            vehiCateINombre = new DataGridViewTextBoxColumn();
            vehiModeCombustible = new DataGridViewTextBoxColumn();
            vehiModeDescripcion = new DataGridViewTextBoxColumn();
            groupLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgridLista).BeginInit();
            groupItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numVehiModeAnio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVehiModeImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInicio).BeginInit();
            SuspendLayout();
            // 
            // groupLista
            // 
            groupLista.Controls.Add(dgridLista);
            groupLista.ForeColor = Color.Navy;
            groupLista.Location = new Point(318, 12);
            groupLista.Name = "groupLista";
            groupLista.Size = new Size(664, 567);
            groupLista.TabIndex = 7;
            groupLista.TabStop = false;
            groupLista.Text = "Lista de Modelos";
            // 
            // dgridLista
            // 
            dgridLista.AllowUserToAddRows = false;
            dgridLista.AllowUserToDeleteRows = false;
            dgridLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridLista.Columns.AddRange(new DataGridViewColumn[] { vehiModeId, vehiModeNombre, vehiModeRodaje, vehiMarNombre, vehiCateINombre, vehiModeCombustible, vehiModeDescripcion });
            dgridLista.Location = new Point(6, 22);
            dgridLista.Name = "dgridLista";
            dgridLista.ReadOnly = true;
            dgridLista.RowHeadersVisible = false;
            dgridLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgridLista.Size = new Size(652, 539);
            dgridLista.TabIndex = 0;
            dgridLista.SelectionChanged += dgridLista_SelectionChanged;
            // 
            // groupItem
            // 
            groupItem.Controls.Add(numVehiModeAnio);
            groupItem.Controls.Add(btnFoto);
            groupItem.Controls.Add(picVehiModeImagen);
            groupItem.Controls.Add(cmbVehiMarId);
            groupItem.Controls.Add(cmbVehiCateId);
            groupItem.Controls.Add(cmbVehiModeCombustible);
            groupItem.Controls.Add(cmbVehiModeRodaje);
            groupItem.Controls.Add(cmbVehiModeAro);
            groupItem.Controls.Add(label9);
            groupItem.Controls.Add(cmbVehiModeEstado);
            groupItem.Controls.Add(label8);
            groupItem.Controls.Add(label4);
            groupItem.Controls.Add(label5);
            groupItem.Controls.Add(label6);
            groupItem.Controls.Add(label7);
            groupItem.Controls.Add(txtVehiModeDescripcion);
            groupItem.Controls.Add(label3);
            groupItem.Controls.Add(label2);
            groupItem.Controls.Add(txtInicio);
            groupItem.Controls.Add(txtVehiModeNombre);
            groupItem.Controls.Add(label1);
            groupItem.Controls.Add(picInicio);
            groupItem.ForeColor = Color.Navy;
            groupItem.Location = new Point(12, 12);
            groupItem.Name = "groupItem";
            groupItem.Size = new Size(300, 459);
            groupItem.TabIndex = 8;
            groupItem.TabStop = false;
            groupItem.Text = "Detalles del Modelo";
            // 
            // numVehiModeAnio
            // 
            numVehiModeAnio.BackColor = SystemColors.GradientInactiveCaption;
            numVehiModeAnio.Location = new Point(87, 263);
            numVehiModeAnio.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            numVehiModeAnio.Minimum = new decimal(new int[] { 1990, 0, 0, 0 });
            numVehiModeAnio.Name = "numVehiModeAnio";
            numVehiModeAnio.Size = new Size(100, 23);
            numVehiModeAnio.TabIndex = 25;
            numVehiModeAnio.TextAlign = HorizontalAlignment.Center;
            numVehiModeAnio.Value = new decimal(new int[] { 1990, 0, 0, 0 });
            // 
            // btnFoto
            // 
            btnFoto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFoto.ForeColor = Color.Navy;
            btnFoto.Location = new Point(187, 423);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(98, 30);
            btnFoto.TabIndex = 3;
            btnFoto.Text = "Sel. Foto";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // picVehiModeImagen
            // 
            picVehiModeImagen.Image = Properties.Resources.logoCardHistory;
            picVehiModeImagen.Location = new Point(9, 320);
            picVehiModeImagen.Name = "picVehiModeImagen";
            picVehiModeImagen.Size = new Size(276, 133);
            picVehiModeImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            picVehiModeImagen.TabIndex = 10;
            picVehiModeImagen.TabStop = false;
            // 
            // cmbVehiMarId
            // 
            cmbVehiMarId.BackColor = SystemColors.GradientInactiveCaption;
            cmbVehiMarId.FormattingEnabled = true;
            cmbVehiMarId.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbVehiMarId.Location = new Point(87, 22);
            cmbVehiMarId.Name = "cmbVehiMarId";
            cmbVehiMarId.Size = new Size(198, 23);
            cmbVehiMarId.TabIndex = 2;
            // 
            // cmbVehiCateId
            // 
            cmbVehiCateId.BackColor = SystemColors.GradientInactiveCaption;
            cmbVehiCateId.FormattingEnabled = true;
            cmbVehiCateId.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbVehiCateId.Location = new Point(87, 51);
            cmbVehiCateId.Name = "cmbVehiCateId";
            cmbVehiCateId.Size = new Size(198, 23);
            cmbVehiCateId.TabIndex = 2;
            // 
            // cmbVehiModeCombustible
            // 
            cmbVehiModeCombustible.BackColor = SystemColors.GradientInactiveCaption;
            cmbVehiModeCombustible.FormattingEnabled = true;
            cmbVehiModeCombustible.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbVehiModeCombustible.Location = new Point(87, 175);
            cmbVehiModeCombustible.Name = "cmbVehiModeCombustible";
            cmbVehiModeCombustible.Size = new Size(100, 23);
            cmbVehiModeCombustible.TabIndex = 2;
            // 
            // cmbVehiModeRodaje
            // 
            cmbVehiModeRodaje.BackColor = SystemColors.GradientInactiveCaption;
            cmbVehiModeRodaje.FormattingEnabled = true;
            cmbVehiModeRodaje.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbVehiModeRodaje.Location = new Point(87, 204);
            cmbVehiModeRodaje.Name = "cmbVehiModeRodaje";
            cmbVehiModeRodaje.Size = new Size(100, 23);
            cmbVehiModeRodaje.TabIndex = 2;
            // 
            // cmbVehiModeAro
            // 
            cmbVehiModeAro.BackColor = SystemColors.GradientInactiveCaption;
            cmbVehiModeAro.FormattingEnabled = true;
            cmbVehiModeAro.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbVehiModeAro.Location = new Point(87, 233);
            cmbVehiModeAro.Name = "cmbVehiModeAro";
            cmbVehiModeAro.Size = new Size(100, 23);
            cmbVehiModeAro.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(8, 25);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 7;
            label9.Text = "Marca";
            // 
            // cmbVehiModeEstado
            // 
            cmbVehiModeEstado.BackColor = SystemColors.GradientInactiveCaption;
            cmbVehiModeEstado.FormattingEnabled = true;
            cmbVehiModeEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbVehiModeEstado.Location = new Point(87, 291);
            cmbVehiModeEstado.Name = "cmbVehiModeEstado";
            cmbVehiModeEstado.Size = new Size(100, 23);
            cmbVehiModeEstado.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(8, 54);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 7;
            label8.Text = "Categoría";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(8, 178);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 7;
            label4.Text = "Combustible";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(8, 207);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 7;
            label5.Text = "Rodaje";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(8, 236);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 7;
            label6.Text = "N° Aro";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(8, 265);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 7;
            label7.Text = "Año";
            // 
            // txtVehiModeDescripcion
            // 
            txtVehiModeDescripcion.BackColor = SystemColors.GradientInactiveCaption;
            txtVehiModeDescripcion.ForeColor = Color.Navy;
            txtVehiModeDescripcion.Location = new Point(87, 109);
            txtVehiModeDescripcion.Multiline = true;
            txtVehiModeDescripcion.Name = "txtVehiModeDescripcion";
            txtVehiModeDescripcion.Size = new Size(200, 60);
            txtVehiModeDescripcion.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(8, 294);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 7;
            label3.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(11, 112);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 7;
            label2.Text = "Descripción";
            // 
            // txtInicio
            // 
            txtInicio.BackColor = Color.FromArgb(224, 224, 224);
            txtInicio.ForeColor = Color.Navy;
            txtInicio.Location = new Point(11, 146);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(69, 23);
            txtInicio.TabIndex = 4;
            txtInicio.Visible = false;
            // 
            // txtVehiModeNombre
            // 
            txtVehiModeNombre.BackColor = SystemColors.GradientInactiveCaption;
            txtVehiModeNombre.ForeColor = Color.Navy;
            txtVehiModeNombre.Location = new Point(87, 80);
            txtVehiModeNombre.Name = "txtVehiModeNombre";
            txtVehiModeNombre.Size = new Size(200, 23);
            txtVehiModeNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(11, 83);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 8;
            label1.Text = "Nombre";
            // 
            // picInicio
            // 
            picInicio.Image = Properties.Resources.logoCardHistory;
            picInicio.Location = new Point(185, 353);
            picInicio.Name = "picInicio";
            picInicio.Size = new Size(100, 100);
            picInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            picInicio.TabIndex = 24;
            picInicio.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9F);
            btnEliminar.ForeColor = Color.Navy;
            btnEliminar.Location = new Point(167, 513);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(145, 30);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 9F);
            btnActualizar.ForeColor = Color.Navy;
            btnActualizar.Location = new Point(167, 477);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(145, 30);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.Red;
            btnCancelar.Location = new Point(12, 549);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(300, 30);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9F);
            btnGuardar.ForeColor = Color.Navy;
            btnGuardar.Location = new Point(12, 513);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(145, 30);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 9F);
            btnNuevo.ForeColor = Color.Navy;
            btnNuevo.Location = new Point(12, 477);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(145, 30);
            btnNuevo.TabIndex = 9;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // vehiModeId
            // 
            vehiModeId.DataPropertyName = "vehiModeId";
            vehiModeId.HeaderText = "vehiModeId";
            vehiModeId.Name = "vehiModeId";
            vehiModeId.ReadOnly = true;
            // 
            // vehiModeNombre
            // 
            vehiModeNombre.DataPropertyName = "vehiModeNombre";
            vehiModeNombre.HeaderText = "Modelo";
            vehiModeNombre.Name = "vehiModeNombre";
            vehiModeNombre.ReadOnly = true;
            // 
            // vehiModeRodaje
            // 
            vehiModeRodaje.DataPropertyName = "vehiModeRodaje";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            vehiModeRodaje.DefaultCellStyle = dataGridViewCellStyle1;
            vehiModeRodaje.HeaderText = "Rodaje";
            vehiModeRodaje.Name = "vehiModeRodaje";
            vehiModeRodaje.ReadOnly = true;
            vehiModeRodaje.Width = 50;
            // 
            // vehiMarNombre
            // 
            vehiMarNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            vehiMarNombre.DataPropertyName = "vehiMarNombre";
            vehiMarNombre.HeaderText = "Marca";
            vehiMarNombre.Name = "vehiMarNombre";
            vehiMarNombre.ReadOnly = true;
            vehiMarNombre.Width = 65;
            // 
            // vehiCateINombre
            // 
            vehiCateINombre.DataPropertyName = "vehiCateINombre";
            vehiCateINombre.HeaderText = "Categoría";
            vehiCateINombre.Name = "vehiCateINombre";
            vehiCateINombre.ReadOnly = true;
            // 
            // vehiModeCombustible
            // 
            vehiModeCombustible.DataPropertyName = "vehiModeCombustible";
            vehiModeCombustible.HeaderText = "Combustible";
            vehiModeCombustible.Name = "vehiModeCombustible";
            vehiModeCombustible.ReadOnly = true;
            // 
            // vehiModeDescripcion
            // 
            vehiModeDescripcion.DataPropertyName = "vehiModeDescripcion";
            vehiModeDescripcion.HeaderText = "Descripción";
            vehiModeDescripcion.Name = "vehiModeDescripcion";
            vehiModeDescripcion.ReadOnly = true;
            vehiModeDescripcion.Width = 390;
            // 
            // frmVehiModelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(994, 591);
            Controls.Add(groupLista);
            Controls.Add(groupItem);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "frmVehiModelo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmVehiModelo";
            groupLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgridLista).EndInit();
            groupItem.ResumeLayout(false);
            groupItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numVehiModeAnio).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVehiModeImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInicio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupLista;
        private DataGridView dgridLista;
        private GroupBox groupItem;
        private Button btnFoto;
        private PictureBox picVehiModeImagen;
        private ComboBox cmbVehiModeEstado;
        private TextBox txtVehiModeDescripcion;
        private Label label3;
        private Label label2;
        private TextBox txtInicio;
        private TextBox txtVehiModeNombre;
        private Label label1;
        private PictureBox picInicio;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnNuevo;
        private ComboBox cmbVehiModeCombustible;
        private ComboBox cmbVehiModeRodaje;
        private ComboBox cmbVehiModeAro;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cmbVehiMarId;
        private ComboBox cmbVehiCateId;
        private Label label9;
        private Label label8;
        private NumericUpDown numVehiModeAnio;
        private DataGridViewTextBoxColumn vehiModeId;
        private DataGridViewTextBoxColumn vehiModeNombre;
        private DataGridViewTextBoxColumn vehiModeRodaje;
        private DataGridViewTextBoxColumn vehiMarNombre;
        private DataGridViewTextBoxColumn vehiCateINombre;
        private DataGridViewTextBoxColumn vehiModeCombustible;
        private DataGridViewTextBoxColumn vehiModeDescripcion;
    }
}