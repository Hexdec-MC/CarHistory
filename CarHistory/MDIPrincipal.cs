using CarHistory.BusinessEntities;
using CarHistory.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarHistory
{
    public partial class MDIPrincipal : Form
    {
        tbUsuario usuario;
        List<tbMenu> verTbMenu;
        public MDIPrincipal()
        {
            InitializeComponent();
            usuario = new tbUsuario();
        }

        private void MDIPrincipal_Shown(object sender, EventArgs e)
        {
            this.ValidarLogin();
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void ValidarLogin()
        {
            if (this.usuario.usuId == 0)
            {
                frmLogin form = new frmLogin();
                try
                {
                    form.ShowDialog();
                    if (form.usuario.usuId == 0)
                    {
                        MessageBox.Show("Usuario incorrecto vuelva a acceder a la Aplicación !!!!!");
                        this.Close();
                        form.ShowDialog();

                    }
                    else
                    {
                        this.usuario = form.usuario;
                        //insTbInicioSesion();
                        generarMenu();
                        this.toolStripStatusUsuario.Text = "Bienvenido: " + this.usuario.usuUsuario + " - " + this.usuario.usuDescripcion;
                        //SetUsuario(form.usuario);
                    }
                }
                catch (Exception)
                {
                    ;
                }
                finally
                {
                    form = null;
                }
            }
        }
        private void generarMenu()
        {
            try
            {
                this.verTbMenu = (new claseSeguridadBL()).verTbMenuByUsuario(this.usuario.usuId);
                List<tbMenu> titulos = this.verTbMenu.FindAll(x => x.menuId.Substring(2, 4) == "0000");
                foreach (tbMenu mnuTitulo in titulos)
                {
                    ToolStripMenuItem item = new ToolStripMenuItem();

                    //string imagen = "";
                    //switch (imagen)
                    //{
                    //    //case "uno":
                    //    //    item.Image = global::sistecno.Properties.Resources.Estudiante;
                    //    //    break;
                    //    //case "dos":
                    //    //    item.Image = global::sistecno.Properties.Resources.grupo1;
                    //    //    break;
                    //}
                    //item.Image = global::sistecno.Properties.Resources.grupo1;
                    item.Name = mnuTitulo.menuNomControl;
                    item.Text = mnuTitulo.menuNombre;
                    if (mnuTitulo.menuNomFormulario != string.Empty)
                        item.Click += new EventHandler(opcionDeMenu_Click);
                    /* Mivel 2*/
                    string niveo1 = mnuTitulo.menuId.Substring(0, 2);
                    List<tbMenu> nive2 = this.verTbMenu.FindAll(x => x.menuId.Substring(0, 2) == niveo1);
                    foreach (tbMenu mnuNivel2 in nive2)
                    {
                        if (mnuNivel2.menuId.Substring(2, 4) != "0000")
                        {
                            ToolStripMenuItem item2 = new ToolStripMenuItem();
                            item2.Name = mnuNivel2.menuNomControl;
                            item2.Text = mnuNivel2.menuNombre;
                            item2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                            if (mnuNivel2.menuNomFormulario != string.Empty)
                                item2.Click += new EventHandler(opcionDeMenu_Click);
                            item.DropDown.Items.Add(item2);
                        }
                    }
                    menuPrincipal.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

        }
        private void opcionDeMenu_Click(object sender, EventArgs e)
        {
            tbMenu obj = this.verTbMenu.Find(x => x.menuNomControl == ((ToolStripMenuItem)sender).Name);
            if (obj != null)
            {
                if (obj.menuNomFormulario == string.Empty)
                {
                    MessageBox.Show("UPSS...\nEl formulario que desea ver aún no está disponible.", "OPCIÓN NO DISPONIBLE", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                //    menu_seleccionado = obj;
                string nombreForm = string.Concat(obj.menuNomNameSpace, ".", obj.menuNomFormulario);
                string tituloForm = "<< " + obj.menuNombre + " >>";

                /* Si el formulario esta abierto se pone en el TOP */
                Form form = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x.Text == tituloForm);
                if (form != null)
                {
                    this.statusFormulario.Text = tituloForm;
                    form.BringToFront();
                    return;
                }

                /* Si no está abierto, se inicializa el formulario */
                Assembly asm = typeof(MDIPrincipal).Assembly;
                Type tForm = asm.GetType(nombreForm);
                object o;
                try
                {
                    o = Activator.CreateInstance(tForm, usuario, obj);

                    if (!(o is Form))
                    {
                        MessageBox.Show(nombreForm + ", no es un formulario", "Mostrar formulario maestro.",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.statusFormulario.Text = tituloForm;
                        form = (Form)o;
                        form.MdiParent = this;
                        form.StartPosition = FormStartPosition.CenterScreen;
                        form.Text = tituloForm;
                        form.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\nEs posible que no exista el formulario '" +
                                   nombreForm + "'.\nRevise sus datos.", "Mostrar formulario",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
