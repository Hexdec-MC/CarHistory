namespace CarHistory.form.Repuesto
{
    partial class frmRepuesto
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
            picRepuImagen = new PictureBox();
            txtRepuDescripcion = new TextBox();
            label2 = new Label();
            txtInicio = new TextBox();
            txtRepuNombre = new TextBox();
            label1 = new Label();
            picInicio = new PictureBox();
            btnNuevo = new Button();
            groupLista = new GroupBox();
            dgridLista = new DataGridView();
            repuId = new DataGridViewTextBoxColumn();
            repuNombre = new DataGridViewTextBoxColumn();
            repuDescripcion = new DataGridViewTextBoxColumn();
            btnActualizar = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            groupItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRepuImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInicio).BeginInit();
            groupLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgridLista).BeginInit();
            SuspendLayout();
            //
            // groupItem
            //
            groupItem.Controls.Add(btnFoto);
            groupItem.Controls.Add(picRepuImagen);
            groupItem.Controls.Add(txtRepuDescripcion);
            groupItem.Controls.Add(label2);
            groupItem.Controls.Add(txtInicio);
            groupItem.Controls.Add(txtRepuNombre);
            groupItem.Controls.Add(label1);
            groupItem.Controls.Add(picInicio);
            groupItem.ForeColor = Color.Navy;
            groupItem.Location = new Point(12, 12);
            groupItem.Name = "groupItem";
            groupItem.Size = new Size(300, 459);
            groupItem.TabIndex = 1;
            groupItem.TabStop = false;
            groupItem.Text = "Detalles del Repuesto";
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
            // picRepuImagen
            //
            picRepuImagen.Image = Properties.Resources.logoCardHistory;
            picRepuImagen.Location = new Point(9, 141);
            picRepuImagen.Name = "picRepuImagen";
            picRepuImagen.Size = new Size(276, 276);
            picRepuImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            picRepuImagen.TabIndex = 10;
            picRepuImagen.TabStop = false;
            //
            // txtRepuDescripcion
            //
            txtRepuDescripcion.BackColor = SystemColors.GradientInactiveCaption;
            txtRepuDescripcion.ForeColor = Color.Navy;
            txtRepuDescripcion.Location = new Point(85, 51);
            txtRepuDescripcion.Multiline = true;
            txtRepuDescripcion.Name = "txtRepuDescripcion";
            txtRepuDescripcion.Size = new Size(200, 84);
            txtRepuDescripcion.TabIndex = 1;
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
            // txtRepuNombre
            //
            txtRepuNombre.BackColor = SystemColors.GradientInactiveCaption;
            txtRepuNombre.ForeColor = Color.Navy;
            txtRepuNombre.Location = new Point(85, 22);
            txtRepuNombre.Name = "txtRepuNombre";
            txtRepuNombre.Size = new Size(200, 23);
            txtRepuNombre.TabIndex = 0;
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
            groupLista.Text = "Lista de Repuestos";
            //
            // dgridLista
            //
            dgridLista.AllowUserToAddRows = false;
            dgridLista.AllowUserToDeleteRows = false;
            dgridLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridLista.Columns.AddRange(new DataGridViewColumn[] { repuId, repuNombre, repuDescripcion });
            dgridLista.Location = new Point(6, 22);
            dgridLista.Name = "dgridLista";
            dgridLista.ReadOnly = true;
            dgridLista.RowHeadersVisible = false;
            dgridLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgridLista.Size = new Size(652, 539);
            dgridLista.TabIndex = 0;
            dgridLista.SelectionChanged += dgridLista_SelectionChanged;
            //
            // repuId
            //
            repuId.DataPropertyName = "repuId";
            repuId.HeaderText = "repuId";
            repuId.Name = "repuId";
            repuId.ReadOnly = true;
            repuId.Visible = false;
            //
            // repuNombre
            //
            repuNombre.DataPropertyName = "repuNombre";
            repuNombre.HeaderText = "Repuesto";
            repuNombre.Name = "repuNombre";
            repuNombre.ReadOnly = true;
            repuNombre.Width = 200;
            //
            // repuDescripcion
            //
            repuDescripcion.DataPropertyName = "repuDescripcion";
            repuDescripcion.HeaderText = "Descripción";
            repuDescripcion.Name = "repuDescripcion";
            repuDescripcion.ReadOnly = true;
            repuDescripcion.Width = 420;
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
            // frmRepuesto
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
            Name = "frmRepuesto";
            Text = "frmRepuesto";
            groupItem.ResumeLayout(false);
            groupItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRepuImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInicio).EndInit();
            groupLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgridLista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupItem;
        private TextBox txtRepuDescripcion;
        private Label label2;
        private TextBox txtRepuNombre;
        private Label label1;
        private Button btnNuevo;
        private GroupBox groupLista;
        private DataGridView dgridLista;
        private Button btnActualizar;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnCancelar;
        private PictureBox picRepuImagen;
        private TextBox txtInicio;
        private Button btnFoto;
        private DataGridViewTextBoxColumn repuId;
        private DataGridViewTextBoxColumn repuNombre;
        private DataGridViewTextBoxColumn repuDescripcion;
        private PictureBox picInicio;
    }
}
