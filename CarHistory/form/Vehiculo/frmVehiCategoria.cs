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

namespace CarHistory.form.Vehiculo
{
    public partial class frmVehiCategoria : frmBase
    {
        int posDataGrid = 0;
        int posDataGridGuardar = 0;
        int _vehiCateId = 0;
        string accion = "";
        string rutaFoto = "";
        string resultado = "Error";
        tbVehiCategoria VehiCategoria = new tbVehiCategoria();
        public frmVehiCategoria(tbUsuario usuario, tbMenu menu) : base(usuario, menu)
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

                _vehiCateId = Convert.ToInt32(row.Cells["vehiCateId"].Value.ToString());

                RellenarItem();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            activarControles();
            limpiarControles();

            accion = "nuevo";

            txtVehiCateNombre.ReadOnly = false;
            txtVehiCateNombre.BackColor = txtVehiCateDescripcion.BackColor;
            txtVehiCateNombre.Focus();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            activarControles();
            accion = "actualizar";

            txtVehiCateNombre.ReadOnly = true;
            txtVehiCateNombre.BackColor = txtInicio.BackColor;
            txtVehiCateDescripcion.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtVehiCateNombre.Text == String.Empty)
            {
                MessageBox.Show("Tiene que ingresar la Categoría del Vehículo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVehiCateNombre.Focus();
                return;
            }
            if (txtVehiCateDescripcion.Text == String.Empty)
            {
                MessageBox.Show("Tiene que ingresar la Descripción de la Categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtVehiCateDescripcion.Focus();
                return;
            }
            if (accion == "nuevo")
            {
                int VehiCateEstado = 0;
                if (this.cmbVehiCateEstado.Text == "Activo")
                {
                    VehiCateEstado = 1;
                }
                tbVehiCategoria nuevoCategoria = new tbVehiCategoria();
                nuevoCategoria.vehiCateNombre = this.txtVehiCateNombre.Text;
                nuevoCategoria.vehiCateDescripcion = this.txtVehiCateDescripcion.Text;
                nuevoCategoria.vehiCateEstado = VehiCateEstado;
                
                resultado = (new tbVehiCategoriaBL()).InsTbVehiCategoria(nuevoCategoria);

                if (resultado == "")
                {
                    MessageBox.Show("Se ingresó correctamente la Categoría del Vehículo !!!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    desactivarControles();
                    posDataGridGuardar = posDataGrid;
                    ListarVehiculo();
                }
                else
                {
                    MessageBox.Show("No se pudo ingresar la Categoría del Vehículo !!!\n" + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                int VehiCateEstado = 0;
                if (this.cmbVehiCateEstado.Text == "Activo")
                {
                    VehiCateEstado = 1;
                }

                VehiCategoria.vehiCateDescripcion = this.txtVehiCateDescripcion.Text;
                VehiCategoria.vehiCateEstado = VehiCateEstado;
               
                resultado = (new tbVehiCategoriaBL()).UpTbVehiCategoria(VehiCategoria);

                if (resultado == "")
                {
                    MessageBox.Show("Se actualizó correctamente la Categoría del Vehículo !!!", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    desactivarControles();
                    posDataGridGuardar = posDataGrid;
                    ListarVehiculo();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la Categoría del Vehículo !!!\n" + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgridLista.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Esta seguro de eliminar la Categoría del Vehículo?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    resultado = (new tbVehiCategoriaBL()).DelTbVehiCategoria(_vehiCateId);

                    if (resultado == "")
                    {
                        MessageBox.Show("Se eliminó correctamente la Categoría del Vehículo !!!", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        desactivarControles();
                        ListarVehiculo();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la Categoría del Vehículo !!!\n" + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desactivarControles();
            posDataGridGuardar = posDataGrid;
            ListarVehiculo();

            txtVehiCateNombre.ReadOnly = true;
            txtVehiCateNombre.BackColor = txtInicio.BackColor;
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
            txtVehiCateNombre.Text = "";
            txtVehiCateDescripcion.Text = "";
            cmbVehiCateEstado.SelectedIndex = 0;
        }
        private void RellenarItem()
        {
            string estado = "Activo";
            VehiCategoria = (new tbVehiCategoriaBL()).VerTbVehiCategoriaByVehiCateId(_vehiCateId);
            this.txtVehiCateNombre.Text = VehiCategoria.vehiCateNombre;
            this.txtVehiCateDescripcion.Text = VehiCategoria.vehiCateDescripcion;
            
            if (VehiCategoria.vehiCateEstado == 0)
            {
                estado = "Inactivo";
            }
            cmbVehiCateEstado.Text = estado;
        }
        private void ListarVehiculo()
        {
            try
            {
                dgridLista.AutoGenerateColumns = false;
                List<tbVehiCategoria> lista = (new tbVehiCategoriaBL()).VerTbVehiCategoriaLikeNombre("");
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
