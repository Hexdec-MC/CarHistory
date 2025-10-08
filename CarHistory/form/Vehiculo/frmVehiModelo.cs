using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarHistory.BusinessEntities;
using CarHistory.BusinessLogic;
using CarHistory.tools;

namespace CarHistory.form.Vehiculo
{
    public partial class frmVehiModelo : frmBase
    {
        int posDataGrid = 0;
        int posDataGridGuardar = 0;
        int _vehiModeId = 0;
        string accion = "";
        string rutaFoto = "";
        string resultado = "Error";
        tbVehiMarca VehiMarca = new tbVehiMarca();
        public frmVehiModelo(tbUsuario usuario, tbMenu menu) : base(usuario, menu)
        {
            InitializeComponent();
            darFormato(Controls);

            List<tbVehiMarca> listaMarca = (new tbVehiMarcaBL()).VerTbVehiMarcaLikeVehiMarNombre("");
            this.cmbVehiMarId.ValueMember = "vehiMarId";
            this.cmbVehiMarId.DisplayMember = "vehiMarNombre";
            this.cmbVehiMarId.DataSource = listaMarca;

            List<tbVehiCategoria> listaCategoria = (new tbVehiCategoriaBL()).VerTbVehiCategoriaLikeNombre("");
            this.cmbVehiCateId.ValueMember = "vehiCateId";
            this.cmbVehiCateId.DisplayMember = "vehiCateNombre";
            this.cmbVehiCateId.DataSource = listaCategoria;

            List<tbVehiModelo> listaCombustible = (new tbVehiModeloBL()).VerTbVehiModeloCombustible();
            this.cmbVehiModeCombustible.ValueMember = "vehiModeCombId";
            this.cmbVehiModeCombustible.DisplayMember = "vehiModeCombNombre";
            this.cmbVehiModeCombustible.DataSource = listaCombustible;

            List<tbVehiModelo> listaAro = (new tbVehiModeloBL()).VerTbVehiModeloAro();
            this.cmbVehiModeAro.ValueMember = "vehiModeAroId";
            this.cmbVehiModeAro.DisplayMember = "vehiModeAroNombre";
            this.cmbVehiModeAro.DataSource = listaAro;

            List<tbVehiModelo> listaRodaje = (new tbVehiModeloBL()).VerTbVehiModeloRodaje();
            this.cmbVehiModeRodaje.ValueMember = "vehiModeRodaId";
            this.cmbVehiModeRodaje.DisplayMember = "vehiModeRodaNombre";
            this.cmbVehiModeRodaje.DataSource = listaRodaje;

            ListarVehiculo();
            desactivarControles();
        }

        private void dgridLista_SelectionChanged(object sender, EventArgs e)
        {
            //if (this.dgridLista.SelectedRows.Count > 0)
            //{
            //    posDataGrid = this.dgridLista.SelectedRows[0].Index;
            //    DataGridViewRow row = this.dgridLista.Rows[posDataGrid];

            //    _vehiModeId = Convert.ToInt32(row.Cells["vehiModeId"].Value.ToString());

            //    RellenarItem();
            //}
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            activarControles();
            limpiarControles();

            accion = "nuevo";

            txtVehiModeNombre.ReadOnly = false;
            txtVehiModeNombre.BackColor = txtVehiModeDescripcion.BackColor;
            txtVehiModeNombre.Focus();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            activarControles();
            accion = "actualizar";

            txtVehiModeNombre.ReadOnly = true;
            txtVehiModeNombre.BackColor = txtInicio.BackColor;
            txtVehiModeDescripcion.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtVehiModeNombre.Text == String.Empty)
            {
                MessageBox.Show("Tiene que ingresar el Modelo del Vehículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVehiModeNombre.Focus();
                return;
            }
            if (txtVehiModeDescripcion.Text == String.Empty)
            {
                MessageBox.Show("Tiene que ingresar la Descripción del Modelo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVehiModeDescripcion.Focus();
                return;
            }
            if (accion == "nuevo")
            {
                int VehiModeEstado = 0;
                if (this.cmbVehiModeEstado.Text == "Activo")
                {
                    VehiModeEstado = 1;
                }
                tbVehiModelo nuevoModelo = new tbVehiModelo();


                nuevoModelo.vehiMarId=Convert.ToInt32( cmbVehiMarId.SelectedValue);
                nuevoModelo.vehiCateId = Convert.ToInt32(cmbVehiCateId.SelectedValue);
                nuevoModelo.vehiModeNombre = this.txtVehiModeNombre.Text;
                nuevoModelo.vehiModeDescripcion = this.txtVehiModeDescripcion.Text;

                nuevoModelo.vehiModeCombustible=cmbVehiModeCombustible.Text;
                nuevoModelo.vehiModeRodaje = cmbVehiModeRodaje.Text;
                nuevoModelo.vehiModeAro = cmbVehiModeAro.Text;
                nuevoModelo.vehiModeAnio = numVehiModeAnio.Text;

                nuevoModelo.vehiModeEstado = VehiModeEstado;
                Image img = picVehiModeImagen.Image;
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    nuevoModelo.vehiModeImagen = ms.ToArray();
                }

                resultado = (new tbVehiModeloBL()).InsTbVehiModelo(nuevoModelo);

                if (resultado == "")
                {
                    MessageBox.Show("Se ingresó correctamente el Modelo del Vehículo !!!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    desactivarControles();
                    posDataGridGuardar = posDataGrid;
                    ListarVehiculo();
                }
                else
                {
                    MessageBox.Show("No se pudo ingresar el Modelo del Vehículo !!!\n" + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //else
            //{
            //    int VehiMarEstado = 0;
            //    if (this.cmbVehiModeEstado.Text == "Activo")
            //    {
            //        VehiMarEstado = 1;
            //    }

            //    VehiMarca.vehiMarDescripcion = this.txtVehiModeDescripcion.Text;
            //    VehiMarca.vehiMarEstado = VehiMarEstado;
            //    Image img = picVehiModeImagen.Image;
            //    using (MemoryStream ms = new MemoryStream())
            //    {
            //        img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //        VehiMarca.vehiMarLogo = ms.ToArray();
            //    }


            //    resultado = (new tbVehiMarcaBL()).UpTbVehiMarca(VehiMarca);

            //    if (resultado == "")
            //    {
            //        MessageBox.Show("Se actualizó correctamente la Marca del Vehículo !!!", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        desactivarControles();
            //        posDataGridGuardar = posDataGrid;
            //        ListarVehiculo();
            //    }
            //    else
            //    {
            //        MessageBox.Show("No se pudo actualizar la Marca del Vehículo !!!\n" + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //if (this.dgridLista.SelectedRows.Count > 0)
            //{
            //    if (MessageBox.Show("¿Esta seguro de eliminar la Marca del Vehículo?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        resultado = (new tbVehiMarcaBL()).DelTbVehiMarca(_vehiMarId);

            //        if (resultado == "")
            //        {
            //            MessageBox.Show("Se eliminó correctamente la Marca del Vehículo !!!", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //            desactivarControles();
            //            ListarVehiculo();
            //        }
            //        else
            //        {
            //            MessageBox.Show("No se pudo eliminar la Marca del Vehículo !!!\n" + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desactivarControles();
            posDataGridGuardar = posDataGrid;
            ListarVehiculo();

            txtVehiModeNombre.ReadOnly = true;
            txtVehiModeNombre.BackColor = txtInicio.BackColor;
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            rutaFoto = cargarArchivos.SolicitarArchivo(cargarArchivos.filtroJpg);
            if (rutaFoto != string.Empty)
            {
                try
                {
                    this.picVehiModeImagen.Image = Image.FromFile(rutaFoto);
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
            txtVehiModeNombre.Text = "";
            txtVehiModeDescripcion.Text = "";
            cmbVehiModeEstado.SelectedIndex = 0;
            picVehiModeImagen.Image = picInicio.Image;
        }
        private void RellenarItem()
        {
            //string estado = "Activo";
            //VehiMarca = (new tbVehiMarcaBL()).VerTbVehiMarcaByVehiMarId(_vehiMarId);
            //this.txtVehiModeNombre.Text = VehiMarca.vehiMarNombre;
            //this.txtVehiModeDescripcion.Text = VehiMarca.vehiMarDescripcion;
            //Byte[] image;
            //image = VehiMarca.vehiMarLogo;
            //MemoryStream stream = new MemoryStream(image);
            //this.picVehiModeImagen.Image = Image.FromStream(stream);

            //if (VehiMarca.vehiMarEstado == 0)
            //{
            //    estado = "Inactivo";
            //}
            //cmbVehiModeEstado.Text = estado;
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
