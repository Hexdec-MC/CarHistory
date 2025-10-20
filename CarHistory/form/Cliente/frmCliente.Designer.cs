namespace CarHistory.form.Cliente
{
    partial class frmCliente
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
            picClieImagen = new PictureBox();
            cmbClieEstado = new ComboBox();
            txtClieCiudad = new TextBox();
            label9 = new Label();
            txtCliePais = new TextBox();
            label8 = new Label();
            txtClieCelular = new TextBox();
            label7 = new Label();
            txtClieEmail = new TextBox();
            label6 = new Label();
            dtpClieFechaNac = new DateTimePicker();
            label5 = new Label();
            cmbClieSexo = new ComboBox();
            label4 = new Label();
            txtClieApeMaterno = new TextBox();
            label3 = new Label();
            txtClieApePaterno = new TextBox();
            label2 = new Label();
            txtClieNombre = new TextBox();
            label11 = new Label();
            txtClieDocNumero = new TextBox();
            label10 = new Label();
            cmbClieDocTipo = new ComboBox();
            label12 = new Label();
            txtInicio = new TextBox();
            label1 = new Label();
            picInicio = new PictureBox();
            btnNuevo = new Button();
            groupLista = new GroupBox();
            dgridLista = new DataGridView();
            clieId = new DataGridViewTextBoxColumn();
            clieDocNumero = new DataGridViewTextBoxColumn();
            clieNombreApellidos = new DataGridViewTextBoxColumn();
            clieEmail = new DataGridViewTextBoxColumn();
            clieCelular = new DataGridViewTextBoxColumn();
            btnActualizar = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            groupItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picClieImagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInicio).BeginInit();
            groupLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgridLista).BeginInit();
            SuspendLayout();
            // 
            // groupItem
            // 
            groupItem.Controls.Add(btnFoto);
            groupItem.Controls.Add(picClieImagen);
            groupItem.Controls.Add(cmbClieEstado);
            groupItem.Controls.Add(txtClieCiudad);
            groupItem.Controls.Add(label9);
            groupItem.Controls.Add(txtCliePais);
            groupItem.Controls.Add(label8);
            groupItem.Controls.Add(txtClieCelular);
            groupItem.Controls.Add(label7);
            groupItem.Controls.Add(txtClieEmail);
            groupItem.Controls.Add(label6);
            groupItem.Controls.Add(dtpClieFechaNac);
            groupItem.Controls.Add(label5);
            groupItem.Controls.Add(cmbClieSexo);
            groupItem.Controls.Add(label4);
            groupItem.Controls.Add(txtClieApeMaterno);
            groupItem.Controls.Add(label3);
            groupItem.Controls.Add(txtClieApePaterno);
            groupItem.Controls.Add(label2);
            groupItem.Controls.Add(txtClieNombre);
            groupItem.Controls.Add(label11);
            groupItem.Controls.Add(txtClieDocNumero);
            groupItem.Controls.Add(label10);
            groupItem.Controls.Add(cmbClieDocTipo);
            groupItem.Controls.Add(label12);
            groupItem.Controls.Add(txtInicio);
            groupItem.Controls.Add(label1);
            groupItem.Controls.Add(picInicio);
            groupItem.ForeColor = Color.Navy;
            groupItem.Location = new Point(12, 12);
            groupItem.Name = "groupItem";
            groupItem.Size = new Size(350, 460);
            groupItem.TabIndex = 1;
            groupItem.TabStop = false;
            groupItem.Text = "Detalles del Cliente";
            // 
            // btnFoto
            // 
            btnFoto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFoto.ForeColor = Color.Navy;
            btnFoto.Location = new Point(237, 424);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(98, 30);
            btnFoto.TabIndex = 13;
            btnFoto.Text = "Sel. Foto";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // picClieImagen
            // 
            picClieImagen.Image = Properties.Resources.logoCardHistory;
            picClieImagen.Location = new Point(185, 324);
            picClieImagen.Name = "picClieImagen";
            picClieImagen.Size = new Size(150, 130);
            picClieImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            picClieImagen.TabIndex = 10;
            picClieImagen.TabStop = false;
            // 
            // cmbClieEstado
            // 
            cmbClieEstado.BackColor = SystemColors.GradientInactiveCaption;
            cmbClieEstado.FormattingEnabled = true;
            cmbClieEstado.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbClieEstado.Location = new Point(9, 424);
            cmbClieEstado.Name = "cmbClieEstado";
            cmbClieEstado.Size = new Size(150, 23);
            cmbClieEstado.TabIndex = 12;
            // 
            // txtClieCiudad
            // 
            txtClieCiudad.BackColor = SystemColors.GradientInactiveCaption;
            txtClieCiudad.ForeColor = Color.Navy;
            txtClieCiudad.Location = new Point(176, 290);
            txtClieCiudad.Name = "txtClieCiudad";
            txtClieCiudad.Size = new Size(155, 23);
            txtClieCiudad.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(176, 272);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 7;
            label9.Text = "Ciudad";
            // 
            // txtCliePais
            // 
            txtCliePais.BackColor = SystemColors.GradientInactiveCaption;
            txtCliePais.ForeColor = Color.Navy;
            txtCliePais.Location = new Point(9, 290);
            txtCliePais.Name = "txtCliePais";
            txtCliePais.Size = new Size(161, 23);
            txtCliePais.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(9, 272);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 7;
            label8.Text = "País";
            // 
            // txtClieCelular
            // 
            txtClieCelular.BackColor = SystemColors.GradientInactiveCaption;
            txtClieCelular.ForeColor = Color.Navy;
            txtClieCelular.Location = new Point(226, 242);
            txtClieCelular.Name = "txtClieCelular";
            txtClieCelular.Size = new Size(105, 23);
            txtClieCelular.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(226, 224);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 7;
            label7.Text = "Celular";
            // 
            // txtClieEmail
            // 
            txtClieEmail.BackColor = SystemColors.GradientInactiveCaption;
            txtClieEmail.ForeColor = Color.Navy;
            txtClieEmail.Location = new Point(9, 242);
            txtClieEmail.Name = "txtClieEmail";
            txtClieEmail.Size = new Size(211, 23);
            txtClieEmail.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(9, 224);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 7;
            label6.Text = "Email";
            // 
            // dtpClieFechaNac
            // 
            dtpClieFechaNac.CalendarMonthBackground = SystemColors.GradientInactiveCaption;
            dtpClieFechaNac.Format = DateTimePickerFormat.Short;
            dtpClieFechaNac.Location = new Point(9, 194);
            dtpClieFechaNac.Name = "dtpClieFechaNac";
            dtpClieFechaNac.Size = new Size(322, 23);
            dtpClieFechaNac.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(9, 176);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 7;
            label5.Text = "Fecha Nacimiento";
            // 
            // cmbClieSexo
            // 
            cmbClieSexo.BackColor = SystemColors.GradientInactiveCaption;
            cmbClieSexo.FormattingEnabled = true;
            cmbClieSexo.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cmbClieSexo.Location = new Point(176, 146);
            cmbClieSexo.Name = "cmbClieSexo";
            cmbClieSexo.Size = new Size(155, 23);
            cmbClieSexo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(176, 128);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 7;
            label4.Text = "Sexo";
            // 
            // txtClieApeMaterno
            // 
            txtClieApeMaterno.BackColor = SystemColors.GradientInactiveCaption;
            txtClieApeMaterno.ForeColor = Color.Navy;
            txtClieApeMaterno.Location = new Point(9, 146);
            txtClieApeMaterno.Name = "txtClieApeMaterno";
            txtClieApeMaterno.Size = new Size(161, 23);
            txtClieApeMaterno.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(9, 128);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 7;
            label3.Text = "Ape. Materno";
            // 
            // txtClieApePaterno
            // 
            txtClieApePaterno.BackColor = SystemColors.GradientInactiveCaption;
            txtClieApePaterno.ForeColor = Color.Navy;
            txtClieApePaterno.Location = new Point(176, 98);
            txtClieApePaterno.Name = "txtClieApePaterno";
            txtClieApePaterno.Size = new Size(155, 23);
            txtClieApePaterno.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(176, 80);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 7;
            label2.Text = "Ape. Paterno";
            // 
            // txtClieNombre
            // 
            txtClieNombre.BackColor = SystemColors.GradientInactiveCaption;
            txtClieNombre.ForeColor = Color.Navy;
            txtClieNombre.Location = new Point(9, 98);
            txtClieNombre.Name = "txtClieNombre";
            txtClieNombre.Size = new Size(161, 23);
            txtClieNombre.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(9, 80);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 8;
            label11.Text = "Nombre";
            // 
            // txtClieDocNumero
            // 
            txtClieDocNumero.BackColor = SystemColors.GradientInactiveCaption;
            txtClieDocNumero.ForeColor = Color.Navy;
            txtClieDocNumero.Location = new Point(176, 50);
            txtClieDocNumero.Name = "txtClieDocNumero";
            txtClieDocNumero.Size = new Size(155, 23);
            txtClieDocNumero.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(176, 32);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 7;
            label10.Text = "Nro. Doc.";
            // 
            // cmbClieDocTipo
            // 
            cmbClieDocTipo.BackColor = SystemColors.GradientInactiveCaption;
            cmbClieDocTipo.FormattingEnabled = true;
            cmbClieDocTipo.Items.AddRange(new object[] { "DNI", "Pasaporte", "Carnet de Extranjería", "RUC" });
            cmbClieDocTipo.Location = new Point(9, 50);
            cmbClieDocTipo.Name = "cmbClieDocTipo";
            cmbClieDocTipo.Size = new Size(130, 23);
            cmbClieDocTipo.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Navy;
            label12.Location = new Point(9, 32);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 7;
            label12.Text = "Tipo Doc.";
            // 
            // txtInicio
            // 
            txtInicio.BackColor = Color.FromArgb(224, 224, 224);
            txtInicio.ForeColor = Color.Navy;
            txtInicio.Location = new Point(9, 80);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(69, 23);
            txtInicio.TabIndex = 4;
            txtInicio.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(9, 406);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 7;
            label1.Text = "Estado";
            // 
            // picInicio
            // 
            picInicio.Image = Properties.Resources.logoCardHistory;
            picInicio.Location = new Point(57, 324);
            picInicio.Name = "picInicio";
            picInicio.Size = new Size(100, 100);
            picInicio.SizeMode = PictureBoxSizeMode.StretchImage;
            picInicio.TabIndex = 24;
            picInicio.TabStop = false;
            picInicio.Visible = false;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 9F);
            btnNuevo.ForeColor = Color.Navy;
            btnNuevo.Location = new Point(12, 478);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(169, 30);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // groupLista
            // 
            groupLista.Controls.Add(dgridLista);
            groupLista.ForeColor = Color.Navy;
            groupLista.Location = new Point(368, 12);
            groupLista.Name = "groupLista";
            groupLista.Size = new Size(620, 568);
            groupLista.TabIndex = 0;
            groupLista.TabStop = false;
            groupLista.Text = "Lista de Clientes";
            // 
            // dgridLista
            // 
            dgridLista.AllowUserToAddRows = false;
            dgridLista.AllowUserToDeleteRows = false;
            dgridLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgridLista.Columns.AddRange(new DataGridViewColumn[] { clieId, clieDocNumero, clieNombreApellidos, clieEmail, clieCelular });
            dgridLista.Location = new Point(6, 22);
            dgridLista.Name = "dgridLista";
            dgridLista.ReadOnly = true;
            dgridLista.RowHeadersVisible = false;
            dgridLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgridLista.Size = new Size(608, 540);
            dgridLista.TabIndex = 0;
            dgridLista.SelectionChanged += dgridLista_SelectionChanged;
            // 
            // clieId
            // 
            clieId.DataPropertyName = "clieId";
            clieId.HeaderText = "clieId";
            clieId.Name = "clieId";
            clieId.ReadOnly = true;
            clieId.Visible = false;
            // 
            // clieDocNumero
            // 
            clieDocNumero.DataPropertyName = "clieDocNumero";
            clieDocNumero.HeaderText = "Nro. Documento";
            clieDocNumero.Name = "clieDocNumero";
            clieDocNumero.ReadOnly = true;
            clieDocNumero.Width = 120;
            // 
            // clieNombreApellidos
            // 
            clieNombreApellidos.DataPropertyName = "clieNombreApellidos";
            clieNombreApellidos.HeaderText = "Nombre y Apellidos";
            clieNombreApellidos.Name = "clieNombreApellidos";
            clieNombreApellidos.ReadOnly = true;
            clieNombreApellidos.Width = 200;
            // 
            // clieEmail
            // 
            clieEmail.DataPropertyName = "clieEmail";
            clieEmail.HeaderText = "Email";
            clieEmail.Name = "clieEmail";
            clieEmail.ReadOnly = true;
            clieEmail.Width = 180;
            // 
            // clieCelular
            // 
            clieCelular.DataPropertyName = "clieCelular";
            clieCelular.HeaderText = "Celular";
            clieCelular.Name = "clieCelular";
            clieCelular.ReadOnly = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 9F);
            btnActualizar.ForeColor = Color.Navy;
            btnActualizar.Location = new Point(193, 478);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(169, 30);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9F);
            btnGuardar.ForeColor = Color.Navy;
            btnGuardar.Location = new Point(12, 514);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(169, 30);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9F);
            btnEliminar.ForeColor = Color.Navy;
            btnEliminar.Location = new Point(193, 514);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(169, 30);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.Red;
            btnCancelar.Location = new Point(12, 550);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(350, 30);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmCliente
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
            Name = "frmCliente";
            Text = "Gestión de Clientes";
            groupItem.ResumeLayout(false);
            groupItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picClieImagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInicio).EndInit();
            groupLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgridLista).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupItem;
        private ComboBox cmbClieDocTipo;
        private Label label12;
        private TextBox txtClieDocNumero;
        private Label label10;
        private TextBox txtClieNombre;
        private Label label11;
        private TextBox txtClieApePaterno;
        private Label label2;
        private TextBox txtClieApeMaterno;
        private Label label3;
        private ComboBox cmbClieSexo;
        private Label label4;
        private DateTimePicker dtpClieFechaNac;
        private Label label5;
        private TextBox txtClieEmail;
        private Label label6;
        private TextBox txtClieCelular;
        private Label label7;
        private TextBox txtCliePais;
        private Label label8;
        private TextBox txtClieCiudad;
        private Label label9;
        private ComboBox cmbClieEstado;
        private Label label1;
        private PictureBox picClieImagen;
        private Button btnFoto;
        private TextBox txtInicio;
        private Button btnNuevo;
        private GroupBox groupLista;
        private DataGridView dgridLista;
        private Button btnActualizar;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnCancelar;
        private PictureBox picInicio;
        private DataGridViewTextBoxColumn clieId;
        private DataGridViewTextBoxColumn clieDocNumero;
        private DataGridViewTextBoxColumn clieNombreApellidos;
        private DataGridViewTextBoxColumn clieEmail;
        private DataGridViewTextBoxColumn clieCelular;
    }
}
