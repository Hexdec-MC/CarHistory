using CarHistory.BusinessEntities;
using CarHistory.BusinessLogic;
using CarHistory.tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarHistory.form.Vehiculo
{
    public partial class frmVehiMarca : frmBase
    {
        int posDataGrid = 0;
        int posDataGridGuardar = 0;
        int _vehiMarId = 0;
        string accion = "";
        string rutaFoto = "";
        string resultado = "Error";
        tbVehiMarca VehiMarca = new tbVehiMarca();
        public frmVehiMarca(tbUsuario usuario, tbMenu menu) : base(usuario, menu)
        {
            InitializeComponent();
            darFormato(Controls);

            ListarVehiculo();
            desactivarControles();
        }

        private void dgridLista_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgridLista.SelectedRows.Count > 0)
            {
                posDataGrid = this.dgridLista.SelectedRows[0].Index;
                DataGridViewRow row = this.dgridLista.Rows[posDataGrid];

                _vehiMarId = Convert.ToInt32(row.Cells["vehiMarId"].Value.ToString());

                RellenarItem();
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            activarControles();
            limpiarControles();

            accion = "nuevo";

            txtVehiMarNombre.ReadOnly = false;
            txtVehiMarNombre.BackColor = txtVehiMarDescripcion.BackColor;
            txtVehiMarNombre.Focus();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            activarControles();
            accion = "actualizar";

            txtVehiMarNombre.ReadOnly = true;
            txtVehiMarNombre.BackColor = txtInicio.BackColor;
            txtVehiMarDescripcion.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtVehiMarNombre.Text == String.Empty)
            {
                MessageBox.Show("Tiene que ingresar la Marca del Vehículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVehiMarNombre.Focus();
                return;
            }
            if (txtVehiMarDescripcion.Text == String.Empty)
            {
                MessageBox.Show("Tiene que ingresar la Descripción de la Marca", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVehiMarDescripcion.Focus();
                return;
            }
            if (accion == "nuevo")
            {
                int VehiMarEstado = 0;
                if (this.cmbVehiMarEstado.Text == "Activo")
                {
                    VehiMarEstado = 1;
                }
                tbVehiMarca nuevoMarca = new tbVehiMarca();
                nuevoMarca.vehiMarNombre = this.txtVehiMarNombre.Text;
                nuevoMarca.vehiMarDescripcion = this.txtVehiMarDescripcion.Text;
                nuevoMarca.vehiMarEstado = VehiMarEstado;
                Image img = picVehiMarLogo.Image;
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    nuevoMarca.vehiMarLogo = ms.ToArray();
                }

                resultado = (new tbVehiMarcaBL()).InsTbVehiMarca(nuevoMarca);

                if (resultado == "")
                {
                    MessageBox.Show("Se ingresó correctamente la Marca del Vehículo !!!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    desactivarControles();
                    posDataGridGuardar = posDataGrid;
                    ListarVehiculo();
                }
                else
                {
                    MessageBox.Show("No se pudo ingresar la Marca del Vehículo !!!\n" + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                int VehiMarEstado = 0;
                if (this.cmbVehiMarEstado.Text == "Activo")
                {
                    VehiMarEstado = 1;
                }

                VehiMarca.vehiMarDescripcion = this.txtVehiMarDescripcion.Text;
                VehiMarca.vehiMarEstado = VehiMarEstado;
                Image img = picVehiMarLogo.Image;
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    VehiMarca.vehiMarLogo = ms.ToArray();
                }


                resultado = (new tbVehiMarcaBL()).UpTbVehiMarca(VehiMarca);

                if (resultado == "")
                {
                    MessageBox.Show("Se actualizó correctamente la Marca del Vehículo !!!", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    desactivarControles();
                    posDataGridGuardar = posDataGrid;
                    ListarVehiculo();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la Marca del Vehículo !!!\n" + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgridLista.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Esta seguro de eliminar la Marca del Vehículo?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    resultado = (new tbVehiMarcaBL()).DelTbVehiMarca(_vehiMarId);

                    if (resultado == "")
                    {
                        MessageBox.Show("Se eliminó correctamente la Marca del Vehículo !!!", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        desactivarControles();
                        ListarVehiculo();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la Marca del Vehículo !!!\n" + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desactivarControles();
            posDataGridGuardar = posDataGrid;
            ListarVehiculo();

            txtVehiMarNombre.ReadOnly = true;
            txtVehiMarNombre.BackColor = txtInicio.BackColor;
        }
        private void btnFoto_Click(object sender, EventArgs e)
        {
            rutaFoto = cargarArchivos.SolicitarArchivo(cargarArchivos.filtroJpg);
            if (rutaFoto != string.Empty)
            {
                try
                {
                    this.picVehiMarLogo.Image = Image.FromFile(rutaFoto);
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
            txtVehiMarNombre.Text = "";
            txtVehiMarDescripcion.Text = "";
            cmbVehiMarEstado.SelectedIndex = 0;
            picVehiMarLogo.Image=picInicio.Image;
        }
        private void RellenarItem()
        {
            string estado = "Activo";
            VehiMarca = (new tbVehiMarcaBL()).VerTbVehiMarcaByVehiMarId(_vehiMarId);
            this.txtVehiMarNombre.Text = VehiMarca.vehiMarNombre;
            this.txtVehiMarDescripcion.Text = VehiMarca.vehiMarDescripcion;
            Byte[] image;
            image = VehiMarca.vehiMarLogo;
            MemoryStream stream = new MemoryStream(image);
            this.picVehiMarLogo.Image = Image.FromStream(stream);

            if (VehiMarca.vehiMarEstado == 0)
            {
                estado = "Inactivo";
            }
            cmbVehiMarEstado.Text = estado;
        }
        private void ListarVehiculo()
        {
            try
            {
                dgridLista.AutoGenerateColumns = false;
                List<tbVehiMarca> lista = (new tbVehiMarcaBL()).VerTbVehiMarcaLikeVehiMarNombre("");
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
