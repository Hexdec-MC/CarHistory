using CarHistory.BusinessEntities;
using CarHistory.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarHistory
{
    public partial class frmLogin : Form
    {
        public tbUsuario usuario;
        public frmLogin()
        {
            InitializeComponent();
            usuario = new tbUsuario();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            usuario = (new claseSeguridadBL()).verUsuarioPassword(new tbUsuario()
            {
                usuUsuario = this.txtUsuario.Text,
                usuPassword = this.txtContrasenia.Text
            });

            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
