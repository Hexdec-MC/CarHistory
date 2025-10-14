namespace CarHistory.form.Repuesto
{
    partial class frmRepuestoMarca
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
            picRepuMarLogo = new PictureBox();
            txtRepuMarPais = new TextBox();
            label3 = new Label();
            txtInicio = new TextBox();
            txtRepuMarNombre = new TextBox();
            label1 = new Label();
            picInicio = new PictureBox();
            btnNuevo = new Button();
            groupLista = new GroupBox();
            dgridLista = new DataGridView();
            repuMarId = new DataGridViewTextBoxColumn();
            repuMarNombre = new DataGridViewTextBoxColumn();
            repuMarPais = new DataGridViewTextBoxColumn();
            btnActualizar = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            groupItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRepuMarLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInicio).BeginInit();
            groupLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgridLista).BeginInit();
            SuspendLayout();
            //
            // groupItem
            //
            groupItem.Controls.Add(btnFoto);
            groupItem.Controls.Add(picRepuMarLogo);
            groupItem.Controls.Add(txtRepuMarPais);
            groupItem.Controls.Add(label3);
            groupItem.Controls.Add(txtInicio);
            groupItem.Controls.Add(txtRepuMarNombre);
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
            btnFoto.TabIndex = 2;
            btnFoto.Text = "Sel. Foto";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            //
            // picRepuMarLogo
            //
            picRepuMarLogo.Image = Properties.Resources.logoCardHistory;
            picRepuMarLogo.Location = new Point(9, 141);
            picRepuMarLogo.Name = "picRepuMarLogo";
            picRepuMarLogo.Size = new Size(276, 276);
            picRepuMarLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picRepuMarLogo.TabIndex = 10;
            picRepuMarLogo.TabStop = false;
            //
            // txtRepuMarPais
            //
            txtRepuMarPais.BackColor = SystemColors.GradientInactiveCaption;
            txtRepuMarPais.ForeColor = Color.Navy;
            txtRepuMarPais.Location = new Point(85, 51);
            txtRepuMarPais.Multiline = true;
            txtRepuMarPais.Name = "txtRepuMarPais";
            txtRepuMarPais.Size = new Size(200, 84);
            txtRepuMarPais.TabIndex = 1;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(9, 54);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 7;
            label3.Text = "País";
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
            // txtRepuMarNombre
            //
            txtRepuMarNombre.BackColor = SystemColors.GradientInactiveCaption;
            txtRepuMarNombre.ForeColor = Color.Navy;
            txtRepuMarNombre.Location = new Point(85, 22);
            txtRepuMarNombre.Name = "txtRepuMarNombre";
            txtRepuMarNombre.Size = new Size(200, 23);
            txtRepuMarNombre.TabIndex = 0;
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
            dgridLista.Columns.AddRange(new DataGridViewColumn[] { repuMarId, repuMarNombre, repuMarPais });
            dgridLista.Location = new Point(6, 22);
            dgridLista.Name = "dgridLista";
            dgridLista.ReadOnly = true;
            dgridLista.RowHeadersVisible = false;
            dgridLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgridLista.Size = new Size(652, 539);
            dgridLista.TabIndex = 0;
            dgridLista.SelectionChanged += dgridLista_SelectionChanged;
            //
            // repuMarId
            //
            repuMarId.DataPropertyName = "repuMarId";
            repuMarId.HeaderText = "repuMarId";
            repuMarId.Name = "repuMarId";
            repuMarId.ReadOnly = true;
            repuMarId.Visible = false;
            //
            // repuMarNombre
            //
            repuMarNombre.DataPropertyName = "repuMarNombre";
            repuMarNombre.HeaderText = "Marca";
            repuMarNombre.Name = "repuMarNombre";
            repuMarNombre.ReadOnly = true;
            repuMarNombre.Width = 200;
            //
            // repuMarPais
            //
            repuMarPais.DataPropertyName = "repuMarPais";
            repuMarPais.HeaderText = "País";
            repuMarPais.Name = "repuMarPais";
            repuMarPais.ReadOnly = true;
            repuMarPais.Width = 420;
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
            // frmRepuestoMarca
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
            Name = "frmRepuestoMarca";
            Text = "frmRepuestoMarca";
            groupItem.ResumeLayout(false);
            groupItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRepuMarLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInicio).EndInit();
            groupLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgridLista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupItem;
        private TextBox txtRepuMarPais;
        private Label label3;
        private TextBox txtRepuMarNombre;
        private Label label1;
        private Button btnNuevo;
        private GroupBox groupLista;
        private DataGridView dgridLista;
        private Button btnActualizar;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnCancelar;
        private PictureBox picRepuMarLogo;
        private TextBox txtInicio;
        private Button btnFoto;
        private DataGridViewTextBoxColumn repuMarId;
        private DataGridViewTextBoxColumn repuMarNombre;
        private DataGridViewTextBoxColumn repuMarPais;
        private PictureBox picInicio;
    }
}
