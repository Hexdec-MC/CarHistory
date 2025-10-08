namespace CarHistory.form.Vehiculo
{
    partial class frmVehiMarca
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
            groupItem = new GroupBox();
            btnFoto = new Button();
            picVehiMarLogo = new PictureBox();
            cmbVehiMarEstado = new ComboBox();
            txtVehiMarDescripcion = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtInicio = new TextBox();
            txtVehiMarNombre = new TextBox();
            label1 = new Label();
            picInicio = new PictureBox();
            btnNuevo = new Button();
            groupLista = new GroupBox();
            dgridLista = new DataGridView();
            vehiMarId = new DataGridViewTextBoxColumn();
            vehiMarNombre = new DataGridViewTextBoxColumn();
            vehiMarDescripcion = new DataGridViewTextBoxColumn();
            vehiMarEstado = new DataGridViewCheckBoxColumn();
            btnActualizar = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            groupItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picVehiMarLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInicio).BeginInit();
            groupLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgridLista).BeginInit();
            SuspendLayout();
            // 
            // groupItem
            // 
            groupItem.Controls.Add(btnFoto);
            groupItem.Controls.Add(picVehiMarLogo);
            groupItem.Controls.Add(cmbVehiMarEstado);
            groupItem.Controls.Add(txtVehiMarDescripcion);
            groupItem.Controls.Add(label3);
            groupItem.Controls.Add(label2);
            groupItem.Controls.Add(txtInicio);
            groupItem.Controls.Add(txtVehiMarNombre);
            groupItem.Controls.Add(label1);
            groupItem.Controls.Add(picInicio);
            groupItem.ForeColor = Color.Navy;
            groupItem.Location = new Point(12, 12);
            groupItem.Name = "groupItem";
            groupItem.Size = new Size(300, 459);
            groupItem.TabIndex = 1;
            groupItem.TabStop = false;
            groupItem.Text = "Detalles de la Marca";
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
            // picVehiMarLogo
            // 
            picVehiMarLogo.Image = Properties.Resources.logoCardHistory;
            picVehiMarLogo.Location = new Point(9, 177);
            picVehiMarLogo.Name = "picVehiMarLogo";
            picVehiMarLogo.Size = new Size(276, 276);
            picVehiMarLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picVehiMarLogo.TabIndex = 10;
            picVehiMarLogo.TabStop = false;
            // 
            // cmbVehiMarEstado
            // 
            cmbVehiMarEstado.BackColor = SystemColors.GradientInactiveCaption;
            cmbVehiMarEstado.FormattingEnabled = true;
            cmbVehiMarEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbVehiMarEstado.Location = new Point(85, 148);
            cmbVehiMarEstado.Name = "cmbVehiMarEstado";
            cmbVehiMarEstado.Size = new Size(100, 23);
            cmbVehiMarEstado.TabIndex = 2;
            // 
            // txtVehiMarDescripcion
            // 
            txtVehiMarDescripcion.BackColor = SystemColors.GradientInactiveCaption;
            txtVehiMarDescripcion.ForeColor = Color.Navy;
            txtVehiMarDescripcion.Location = new Point(85, 51);
            txtVehiMarDescripcion.Multiline = true;
            txtVehiMarDescripcion.Name = "txtVehiMarDescripcion";
            txtVehiMarDescripcion.Size = new Size(200, 91);
            txtVehiMarDescripcion.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(6, 151);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 7;
            label3.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(9, 54);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 7;
            label2.Text = "Descripción";
            // 
            // txtInicio
            // 
            txtInicio.BackColor = Color.FromArgb(224, 224, 224);
            txtInicio.ForeColor = Color.Navy;
            txtInicio.Location = new Point(9, 89);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(69, 23);
            txtInicio.TabIndex = 4;
            txtInicio.Visible = false;
            // 
            // txtVehiMarNombre
            // 
            txtVehiMarNombre.BackColor = SystemColors.GradientInactiveCaption;
            txtVehiMarNombre.ForeColor = Color.Navy;
            txtVehiMarNombre.Location = new Point(85, 22);
            txtVehiMarNombre.Name = "txtVehiMarNombre";
            txtVehiMarNombre.Size = new Size(200, 23);
            txtVehiMarNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(9, 25);
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
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 9F);
            btnNuevo.ForeColor = Color.Navy;
            btnNuevo.Location = new Point(12, 477);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(145, 30);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // groupLista
            // 
            groupLista.Controls.Add(dgridLista);
            groupLista.ForeColor = Color.Navy;
            groupLista.Location = new Point(318, 12);
            groupLista.Name = "groupLista";
            groupLista.Size = new Size(664, 567);
            groupLista.TabIndex = 0;
            groupLista.TabStop = false;
            groupLista.Text = "Lista de Marcas";
            // 
            // dgridLista
            // 
            dgridLista.AllowUserToAddRows = false;
            dgridLista.AllowUserToDeleteRows = false;
            dgridLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridLista.Columns.AddRange(new DataGridViewColumn[] { vehiMarId, vehiMarNombre, vehiMarDescripcion, vehiMarEstado });
            dgridLista.Location = new Point(6, 22);
            dgridLista.Name = "dgridLista";
            dgridLista.ReadOnly = true;
            dgridLista.RowHeadersVisible = false;
            dgridLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgridLista.Size = new Size(652, 539);
            dgridLista.TabIndex = 0;
            dgridLista.SelectionChanged += dgridLista_SelectionChanged;
            // 
            // vehiMarId
            // 
            vehiMarId.DataPropertyName = "vehiMarId";
            vehiMarId.HeaderText = "vehiMarId";
            vehiMarId.Name = "vehiMarId";
            vehiMarId.ReadOnly = true;
            vehiMarId.Visible = false;
            // 
            // vehiMarNombre
            // 
            vehiMarNombre.DataPropertyName = "vehiMarNombre";
            vehiMarNombre.HeaderText = "Marca";
            vehiMarNombre.Name = "vehiMarNombre";
            vehiMarNombre.ReadOnly = true;
            vehiMarNombre.Width = 150;
            // 
            // vehiMarDescripcion
            // 
            vehiMarDescripcion.DataPropertyName = "vehiMarDescripcion";
            vehiMarDescripcion.HeaderText = "Descripción";
            vehiMarDescripcion.Name = "vehiMarDescripcion";
            vehiMarDescripcion.ReadOnly = true;
            vehiMarDescripcion.Width = 390;
            // 
            // vehiMarEstado
            // 
            vehiMarEstado.DataPropertyName = "vehiMarEstado";
            vehiMarEstado.HeaderText = "Estado";
            vehiMarEstado.Name = "vehiMarEstado";
            vehiMarEstado.ReadOnly = true;
            vehiMarEstado.Width = 80;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 9F);
            btnActualizar.ForeColor = Color.Navy;
            btnActualizar.Location = new Point(167, 477);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(145, 30);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9F);
            btnGuardar.ForeColor = Color.Navy;
            btnGuardar.Location = new Point(12, 513);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(145, 30);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9F);
            btnEliminar.ForeColor = Color.Navy;
            btnEliminar.Location = new Point(167, 513);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(145, 30);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.Red;
            btnCancelar.Location = new Point(12, 549);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(300, 30);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmVehiMarca
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
            Name = "frmVehiMarca";
            Text = "frmVehiMarca";
            groupItem.ResumeLayout(false);
            groupItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picVehiMarLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInicio).EndInit();
            groupLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgridLista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupItem;
        private TextBox txtVehiMarDescripcion;
        private Label label2;
        private TextBox txtVehiMarNombre;
        private Label label1;
        private Button btnNuevo;
        private GroupBox groupLista;
        private DataGridView dgridLista;
        private Button btnActualizar;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnCancelar;
        private ComboBox cmbVehiMarEstado;
        private Label label3;
        private PictureBox picVehiMarLogo;
        private TextBox txtInicio;
        private Button btnFoto;
        private DataGridViewTextBoxColumn vehiMarId;
        private DataGridViewTextBoxColumn vehiMarNombre;
        private DataGridViewTextBoxColumn vehiMarDescripcion;
        private DataGridViewCheckBoxColumn vehiMarEstado;
        private PictureBox picInicio;
    }
}