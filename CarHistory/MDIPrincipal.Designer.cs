namespace CarHistory
{
    partial class MDIPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            menuPrincipal = new MenuStrip();
            statusFormulario = new StatusStrip();
            toolStripStatusUsuario = new ToolStripStatusLabel();
            statusFormulario.SuspendLayout();
            SuspendLayout();
            // 
            // menuPrincipal
            // 
            menuPrincipal.Location = new Point(0, 0);
            menuPrincipal.Name = "menuPrincipal";
            menuPrincipal.Size = new Size(737, 24);
            menuPrincipal.TabIndex = 4;
            menuPrincipal.Text = "menuStrip1";
            // 
            // statusFormulario
            // 
            statusFormulario.Items.AddRange(new ToolStripItem[] { toolStripStatusUsuario });
            statusFormulario.Location = new Point(0, 501);
            statusFormulario.Name = "statusFormulario";
            statusFormulario.Size = new Size(737, 22);
            statusFormulario.TabIndex = 5;
            statusFormulario.Text = "statusStrip1";
            // 
            // toolStripStatusUsuario
            // 
            toolStripStatusUsuario.AutoSize = false;
            toolStripStatusUsuario.Name = "toolStripStatusUsuario";
            toolStripStatusUsuario.Size = new Size(500, 17);
            toolStripStatusUsuario.Text = "Estado";
            // 
            // MDIPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 523);
            Controls.Add(statusFormulario);
            Controls.Add(menuPrincipal);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MDIPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MDIPrincipal";
            WindowState = FormWindowState.Maximized;
            FormClosing += MDIPrincipal_FormClosing;
            Shown += MDIPrincipal_Shown;
            statusFormulario.ResumeLayout(false);
            statusFormulario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuPrincipal;
        private StatusStrip statusFormulario;
        private ToolStripStatusLabel toolStripStatusUsuario;
    }
}



