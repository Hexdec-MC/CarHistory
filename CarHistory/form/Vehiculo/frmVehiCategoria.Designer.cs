namespace CarHistory.form.Vehiculo
{
    partial class frmVehiCategoria
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
            groupLista = new GroupBox();
            dgridLista = new DataGridView();
            groupItem = new GroupBox();
            cmbVehiCateEstado = new ComboBox();
            txtVehiCateDescripcion = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtInicio = new TextBox();
            txtVehiCateNombre = new TextBox();
            label1 = new Label();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            vehiCateId = new DataGridViewTextBoxColumn();
            vehiCateNombre = new DataGridViewTextBoxColumn();
            vehiCateDescripcion = new DataGridViewTextBoxColumn();
            vehiCateEstado = new DataGridViewCheckBoxColumn();
            groupLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgridLista).BeginInit();
            groupItem.SuspendLayout();
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
            groupLista.Text = "Lista de Categorías";
            // 
            // dgridLista
            // 
            dgridLista.AllowUserToAddRows = false;
            dgridLista.AllowUserToDeleteRows = false;
            dgridLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridLista.Columns.AddRange(new DataGridViewColumn[] { vehiCateId, vehiCateNombre, vehiCateDescripcion, vehiCateEstado });
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
            groupItem.Controls.Add(cmbVehiCateEstado);
            groupItem.Controls.Add(txtVehiCateDescripcion);
            groupItem.Controls.Add(label3);
            groupItem.Controls.Add(label2);
            groupItem.Controls.Add(txtInicio);
            groupItem.Controls.Add(txtVehiCateNombre);
            groupItem.Controls.Add(label1);
            groupItem.ForeColor = Color.Navy;
            groupItem.Location = new Point(12, 12);
            groupItem.Name = "groupItem";
            groupItem.Size = new Size(300, 179);
            groupItem.TabIndex = 8;
            groupItem.TabStop = false;
            groupItem.Text = "Detalles de la Categoría";
            // 
            // cmbVehiCateEstado
            // 
            cmbVehiCateEstado.BackColor = SystemColors.GradientInactiveCaption;
            cmbVehiCateEstado.FormattingEnabled = true;
            cmbVehiCateEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbVehiCateEstado.Location = new Point(85, 148);
            cmbVehiCateEstado.Name = "cmbVehiCateEstado";
            cmbVehiCateEstado.Size = new Size(100, 23);
            cmbVehiCateEstado.TabIndex = 9;
            // 
            // txtVehiCateDescripcion
            // 
            txtVehiCateDescripcion.BackColor = SystemColors.GradientInactiveCaption;
            txtVehiCateDescripcion.ForeColor = Color.Navy;
            txtVehiCateDescripcion.Location = new Point(85, 51);
            txtVehiCateDescripcion.Multiline = true;
            txtVehiCateDescripcion.Name = "txtVehiCateDescripcion";
            txtVehiCateDescripcion.Size = new Size(200, 91);
            txtVehiCateDescripcion.TabIndex = 5;
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
            // txtVehiCateNombre
            // 
            txtVehiCateNombre.BackColor = SystemColors.GradientInactiveCaption;
            txtVehiCateNombre.ForeColor = Color.Navy;
            txtVehiCateNombre.Location = new Point(85, 22);
            txtVehiCateNombre.Name = "txtVehiCateNombre";
            txtVehiCateNombre.Size = new Size(200, 23);
            txtVehiCateNombre.TabIndex = 4;
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
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9F);
            btnEliminar.ForeColor = Color.Navy;
            btnEliminar.Location = new Point(167, 233);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(145, 30);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 9F);
            btnActualizar.ForeColor = Color.Navy;
            btnActualizar.Location = new Point(167, 197);
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
            btnCancelar.Location = new Point(12, 269);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(300, 30);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9F);
            btnGuardar.ForeColor = Color.Navy;
            btnGuardar.Location = new Point(12, 233);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(145, 30);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 9F);
            btnNuevo.ForeColor = Color.Navy;
            btnNuevo.Location = new Point(12, 197);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(145, 30);
            btnNuevo.TabIndex = 13;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // vehiCateId
            // 
            vehiCateId.DataPropertyName = "vehiCateId";
            vehiCateId.HeaderText = "vehiCateId";
            vehiCateId.Name = "vehiCateId";
            vehiCateId.ReadOnly = true;
            vehiCateId.Visible = false;
            // 
            // vehiCateNombre
            // 
            vehiCateNombre.DataPropertyName = "vehiCateNombre";
            vehiCateNombre.HeaderText = "Categoría";
            vehiCateNombre.Name = "vehiCateNombre";
            vehiCateNombre.ReadOnly = true;
            vehiCateNombre.Width = 150;
            // 
            // vehiCateDescripcion
            // 
            vehiCateDescripcion.DataPropertyName = "vehiCateDescripcion";
            vehiCateDescripcion.HeaderText = "Descripción";
            vehiCateDescripcion.Name = "vehiCateDescripcion";
            vehiCateDescripcion.ReadOnly = true;
            vehiCateDescripcion.Width = 390;
            // 
            // vehiCateEstado
            // 
            vehiCateEstado.DataPropertyName = "vehiCateEstado";
            vehiCateEstado.HeaderText = "Estado";
            vehiCateEstado.Name = "vehiCateEstado";
            vehiCateEstado.ReadOnly = true;
            vehiCateEstado.Width = 80;
            // 
            // frmVehiCategoria
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
            Name = "frmVehiCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmVehiCategoria";
            groupLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgridLista).EndInit();
            groupItem.ResumeLayout(false);
            groupItem.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupLista;
        private DataGridView dgridLista;
        private GroupBox groupItem;
        private ComboBox cmbVehiCateEstado;
        private TextBox txtVehiCateDescripcion;
        private Label label3;
        private Label label2;
        private TextBox txtInicio;
        private TextBox txtVehiCateNombre;
        private Label label1;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnNuevo;
        private DataGridViewTextBoxColumn vehiCateId;
        private DataGridViewTextBoxColumn vehiCateNombre;
        private DataGridViewTextBoxColumn vehiCateDescripcion;
        private DataGridViewCheckBoxColumn vehiCateEstado;
    }
}