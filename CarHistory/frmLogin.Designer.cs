namespace CarHistory
{
    partial class frmLogin
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
            pictureBox1 = new PictureBox();
            btnAceptar = new Button();
            label1 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            txtContrasenia = new TextBox();
            lblArriba = new Label();
            lblDerecha = new Label();
            lblIzquierda = new Label();
            lblAbajo = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoCardHistory;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 9F);
            btnAceptar.ForeColor = Color.Navy;
            btnAceptar.Location = new Point(56, 200);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(120, 30);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(38, 145);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.GradientInactiveCaption;
            txtUsuario.ForeColor = Color.Navy;
            txtUsuario.Location = new Point(94, 142);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 0;
            txtUsuario.Text = "rroman";
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(18, 174);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 3;
            label2.Text = "Contraseña:";
            // 
            // txtContrasenia
            // 
            txtContrasenia.BackColor = SystemColors.GradientInactiveCaption;
            txtContrasenia.ForeColor = Color.Navy;
            txtContrasenia.Location = new Point(94, 171);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(100, 23);
            txtContrasenia.TabIndex = 1;
            txtContrasenia.Text = "20107879";
            txtContrasenia.TextAlign = HorizontalAlignment.Center;
            // 
            // lblArriba
            // 
            lblArriba.BackColor = Color.Silver;
            lblArriba.Dock = DockStyle.Top;
            lblArriba.ForeColor = Color.FromArgb(222, 241, 243);
            lblArriba.Location = new Point(0, 0);
            lblArriba.Name = "lblArriba";
            lblArriba.Size = new Size(221, 3);
            lblArriba.TabIndex = 21;
            lblArriba.Text = "label1";
            // 
            // lblDerecha
            // 
            lblDerecha.BackColor = Color.Silver;
            lblDerecha.Dock = DockStyle.Right;
            lblDerecha.ForeColor = Color.FromArgb(222, 241, 243);
            lblDerecha.Location = new Point(221, 0);
            lblDerecha.Name = "lblDerecha";
            lblDerecha.Size = new Size(3, 241);
            lblDerecha.TabIndex = 20;
            lblDerecha.Text = "label1";
            // 
            // lblIzquierda
            // 
            lblIzquierda.BackColor = Color.Silver;
            lblIzquierda.Dock = DockStyle.Left;
            lblIzquierda.ForeColor = Color.FromArgb(224, 224, 224);
            lblIzquierda.Location = new Point(0, 3);
            lblIzquierda.Name = "lblIzquierda";
            lblIzquierda.Size = new Size(3, 235);
            lblIzquierda.TabIndex = 23;
            lblIzquierda.Text = "label1";
            // 
            // lblAbajo
            // 
            lblAbajo.BackColor = Color.Silver;
            lblAbajo.Dock = DockStyle.Bottom;
            lblAbajo.ForeColor = Color.FromArgb(224, 224, 224);
            lblAbajo.Location = new Point(0, 238);
            lblAbajo.Name = "lblAbajo";
            lblAbajo.Size = new Size(221, 3);
            lblAbajo.TabIndex = 22;
            lblAbajo.Text = "label1";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(224, 241);
            Controls.Add(lblIzquierda);
            Controls.Add(lblAbajo);
            Controls.Add(lblArriba);
            Controls.Add(lblDerecha);
            Controls.Add(txtContrasenia);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnAceptar;
        private Label label1;
        private TextBox txtUsuario;
        private Label label2;
        private TextBox txtContrasenia;
        private Label lblArriba;
        private Label lblDerecha;
        private Label lblIzquierda;
        private Label lblAbajo;
    }
}