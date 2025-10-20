using CarHistory.BusinessEntities;
using CarHistory.BusinessLogic;
using CarHistory.tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarHistory.form.Cliente
{
    public partial class frmCliente : frmBase
    {
        int posDataGrid = 0;
        int posDataGridGuardar = 0;
        int _clieId = 0;
        string accion = "";
        string rutaFoto = "";
        string resultado = "Error";
        tbCliente Cliente = new tbCliente();

        public frmCliente(tbUsuario usuario, tbMenu menu) : base(usuario, menu)
        {
            InitializeComponent();
            darFormato(Controls);

            ListarCliente();
            desactivarControles();
        }

        private void dgridLista_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgridLista.SelectedRows.Count > 0)
            {
                posDataGrid = this.dgridLista.SelectedRows[0].Index;
                DataGridViewRow row = this.dgridLista.Rows[posDataGrid];

                _clieId = Convert.ToInt32(row.Cells["clieId"].Value.ToString());

                RellenarItem();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            activarControles();
            limpiarControles();

            accion = "nuevo";

            cmbClieDocTipo.Focus();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            activarControles();
            accion = "actualizar";

            cmbClieDocTipo.Enabled = false;
            txtClieDocNumero.ReadOnly = true;
            txtClieDocNumero.BackColor = txtInicio.BackColor;
            txtClieNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (cmbClieDocTipo.Text == String.Empty)
            {
                MessageBox.Show("Tiene que seleccionar el Tipo de Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbClieDocTipo.Focus();
                return;
            }
            if (txtClieDocNumero.Text == String.Empty)
            {
                MessageBox.Show("Tiene que ingresar el Número de Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClieDocNumero.Focus();
                return;
            }
            if (txtClieNombre.Text == String.Empty)
            {
                MessageBox.Show("Tiene que ingresar el Nombre del Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClieNombre.Focus();
                return;
            }
            if (txtClieApePaterno.Text == String.Empty)
            {
                MessageBox.Show("Tiene que ingresar el Apellido Paterno del Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClieApePaterno.Focus();
                return;
            }
            if (txtClieApeMaterno.Text == String.Empty)
            {
                MessageBox.Show("Tiene que ingresar el Apellido Materno del Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClieApeMaterno.Focus();
                return;
            }
            if (cmbClieSexo.Text == String.Empty)
            {
                MessageBox.Show("Tiene que seleccionar el Sexo del Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbClieSexo.Focus();
                return;
            }

            if (accion == "nuevo")
            {
                int ClieEstado = 0;
                if (this.cmbClieEstado.Text == "Activo")
                {
                    ClieEstado = 1;
                }

                tbCliente nuevoCliente = new tbCliente();
                nuevoCliente.usuId = this.usuarioActual.usuId;
                nuevoCliente.clieDocTipo = this.cmbClieDocTipo.Text;
                nuevoCliente.clieDocNumero = this.txtClieDocNumero.Text;
                nuevoCliente.clieApePaterno = this.txtClieApePaterno.Text;
                nuevoCliente.clieApeMaterno = this.txtClieApeMaterno.Text;
                nuevoCliente.clieNombre = this.txtClieNombre.Text;
                nuevoCliente.clieNombreApellidos = $"{this.txtClieNombre.Text} {this.txtClieApePaterno.Text} {this.txtClieApeMaterno.Text}";
                nuevoCliente.clieSexo = this.cmbClieSexo.Text;
                nuevoCliente.clieFechaNac = this.dtpClieFechaNac.Value;
                nuevoCliente.clieEmail = this.txtClieEmail.Text;
                nuevoCliente.clieCelular = this.txtClieCelular.Text;
                nuevoCliente.cliePais = this.txtCliePais.Text;
                nuevoCliente.clieCiudad = this.txtClieCiudad.Text;
                nuevoCliente.clieEstado = ClieEstado;

                Image img = picClieImagen.Image;
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    nuevoCliente.clieImagen = ms.ToArray();
                }

                resultado = (new tbClienteBL()).InsTbCliente(nuevoCliente);

                if (resultado == "")
                {
                    MessageBox.Show("Se ingresó correctamente el Cliente !!!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    desactivarControles();
                    posDataGridGuardar = posDataGrid;
                    ListarCliente();
                }
                else
                {
                    MessageBox.Show("No se pudo ingresar el Cliente !!!\n" + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                int ClieEstado = 0;
                if (this.cmbClieEstado.Text == "Activo")
                {
                    ClieEstado = 1;
                }

                Cliente.clieApePaterno = this.txtClieApePaterno.Text;
                Cliente.clieApeMaterno = this.txtClieApeMaterno.Text;
                Cliente.clieNombre = this.txtClieNombre.Text;
                Cliente.clieNombreApellidos = $"{this.txtClieNombre.Text} {this.txtClieApePaterno.Text} {this.txtClieApeMaterno.Text}";
                Cliente.clieSexo = this.cmbClieSexo.Text;
                Cliente.clieFechaNac = this.dtpClieFechaNac.Value;
                Cliente.clieEmail = this.txtClieEmail.Text;
                Cliente.clieCelular = this.txtClieCelular.Text;
                Cliente.cliePais = this.txtCliePais.Text;
                Cliente.clieCiudad = this.txtClieCiudad.Text;
                Cliente.clieEstado = ClieEstado;

                Image img = picClieImagen.Image;
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    Cliente.clieImagen = ms.ToArray();
                }

                resultado = (new tbClienteBL()).UpTbCliente(Cliente);

                if (resultado == "")
                {
                    MessageBox.Show("Se actualizó correctamente el Cliente !!!", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    desactivarControles();
                    posDataGridGuardar = posDataGrid;
                    ListarCliente();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el Cliente !!!\n" + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgridLista.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Esta seguro de eliminar el Cliente?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    resultado = (new tbClienteBL()).DelTbCliente(_clieId);

                    if (resultado == "")
                    {
                        MessageBox.Show("Se eliminó correctamente el Cliente !!!", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        desactivarControles();
                        ListarCliente();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el Cliente !!!\n" + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desactivarControles();
            posDataGridGuardar = posDataGrid;
            ListarCliente();

            cmbClieDocTipo.Enabled = true;
            txtClieDocNumero.ReadOnly = false;
            txtClieDocNumero.BackColor = SystemColors.GradientInactiveCaption;
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            rutaFoto = cargarArchivos.SolicitarArchivo(cargarArchivos.filtroJpg);
            if (rutaFoto != string.Empty)
            {
                try
                {
                    this.picClieImagen.Image = Image.FromFile(rutaFoto);
                }
                catch
                {
                    MessageBox.Show("El archivo de imagen está corrupto", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void activarControles()
        {
            groupItem.Enabled = true;
            groupLista.Enabled = false;
            groupLista.ForeColor = SystemColors.ControlDarkDark;
            btnGuardar.Enabled = true;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void desactivarControles()
        {
            groupItem.Enabled = false;
            groupLista.Enabled = true;
            groupLista.ForeColor = System.Drawing.Color.Navy;
            btnGuardar.Enabled = false;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            btnNuevo.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void limpiarControles()
        {
            cmbClieDocTipo.SelectedIndex = 0;
            txtClieDocNumero.Text = "";
            txtClieNombre.Text = "";
            txtClieApePaterno.Text = "";
            txtClieApeMaterno.Text = "";
            cmbClieSexo.SelectedIndex = 0;
            dtpClieFechaNac.Value = DateTime.Now;
            txtClieEmail.Text = "";
            txtClieCelular.Text = "";
            txtCliePais.Text = "";
            txtClieCiudad.Text = "";
            cmbClieEstado.SelectedIndex = 0;
            picClieImagen.Image = picInicio.Image;
        }

        private void RellenarItem()
        {
            string estado = "Activo";
            Cliente = (new tbClienteBL()).VerTbClienteByClieId(_clieId);

            this.cmbClieDocTipo.Text = Cliente.clieDocTipo;
            this.txtClieDocNumero.Text = Cliente.clieDocNumero;
            this.txtClieNombre.Text = Cliente.clieNombre;
            this.txtClieApePaterno.Text = Cliente.clieApePaterno;
            this.txtClieApeMaterno.Text = Cliente.clieApeMaterno;
            this.cmbClieSexo.Text = Cliente.clieSexo;

            if (Cliente.clieFechaNac.HasValue)
            {
                this.dtpClieFechaNac.Value = Cliente.clieFechaNac.Value;
            }

            this.txtClieEmail.Text = Cliente.clieEmail;
            this.txtClieCelular.Text = Cliente.clieCelular;
            this.txtCliePais.Text = Cliente.cliePais;
            this.txtClieCiudad.Text = Cliente.clieCiudad;

            if (Cliente.clieImagen != null && Cliente.clieImagen.Length > 0)
            {
                MemoryStream stream = new MemoryStream(Cliente.clieImagen);
                this.picClieImagen.Image = Image.FromStream(stream);
            }

            if (Cliente.clieEstado == 0)
            {
                estado = "Inactivo";
            }
            cmbClieEstado.Text = estado;
        }

        private void ListarCliente()
        {
            try
            {
                dgridLista.AutoGenerateColumns = false;
                List<tbCliente> lista = (new tbClienteBL()).VerTbClienteLikeClieDocNumero("");
                dgridLista.DataSource = lista;

                if (posDataGridGuardar != posDataGrid && posDataGrid == 0)
                {
                    dgridLista.CurrentRow.Selected = false;
                    dgridLista.Rows[posDataGridGuardar].Selected = true;
                }
            }
            catch { }
        }
    }
}
