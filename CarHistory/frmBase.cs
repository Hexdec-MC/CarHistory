using CarHistory.BusinessEntities;
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
    public partial class frmBase : Form
    {
        public tbUsuario usuarioActual = new tbUsuario();
        public tbMenu menuSeleccionado = new tbMenu();
        public frmBase()
        {
            InitializeComponent();
        }
        public frmBase(tbUsuario usuario, tbMenu menu)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
            this.menuSeleccionado = menu;
        }
        ~frmBase()
        {
            usuarioActual = null;
            menuSeleccionado = null;
        }
        public string tituloFotmulario()
        {
            //try
            //{
            return string.Concat("<< ", menuSeleccionado.menuNombre, " >>");
            //}
            //catch
            //{
            //    return "";
            //}

        }

        public void formularioActivo(object sender, EventArgs e)
        {
            //StatusStrip objStatus = (StatusStrip)this.MdiParent.Controls["MDIPrincipalStatus"];
            //objStatus.Items["statusFormulario"].Text = menuSeleccionado.menuNombre;
        }

        public void darFormato(Control.ControlCollection controles)
        {
            // Microsoft Sans Serif; 8.25pt
            //Font newFontTitle = new Font("Microsoft Sans Serif",  8, FontStyle.Regular, GraphicsUnit.Point);
            //Font newFontDetail = new Font("Microsoft Sans Serif", 8, FontStyle.Regular, GraphicsUnit.Point);

            //var groupBoxList = controles.OfType<GroupBox>().ToList();



            var LabelList = controles.OfType<Label>().ToList();
            foreach (Label obj in LabelList)
            {
                //obj.Font = newFontDetail;


                //obj.BackColor = Color.Red;

                switch ((obj.Tag ?? string.Empty).ToString())
                {
                    case "lblTituloPrincipal":
                        {
                            obj.BackColor = Color.Blue;
                            obj.ForeColor = Color.White;
                            obj.Font = new Font("Times New Roman", 12, FontStyle.Bold, GraphicsUnit.Point);
                            break;
                        }
                    case "lblDescripcion":
                        {

                            obj.ForeColor = SystemColors.HotTrack;
                            obj.Font = new Font("Times New Roman", 10, FontStyle.Regular, GraphicsUnit.Point);
                            break;
                        }
                    default:
                        break;
                }
            }

        }
    }
}
