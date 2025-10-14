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

namespace CarHistory.form.Repuesto
{
    public partial class frmRepuesto : frmBase
    {
        int posDataGrid = 0;
        int posDataGridGuardar = 0;
        int _repuId = 0;
        string accion = "";
        string rutaFoto = "";
        string resultado = "Error";
        tbRepuesto Repuesto = new tbRepuesto();
        public frmRepuesto(tbUsuario usuario, tbMenu menu) : base(usuario, menu)
        {
            InitializeComponent();
            darFormato(Controls);

            ListarRepuesto();
            desactivarControles();
        }

        private void dgridLista_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgridLista.SelectedRows.Count > 0)
            {
                posDataGrid = this.dgridLista.SelectedRows[0].Index;
                DataGridViewRow row = this.dgridLista.Rows[posDataGrid];

                _repuId = Convert.ToInt32(row.Cells["repuId"].Value.ToString());

                RellenarItem();
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            activarControles();
            limpiarControles();

            accion = "nuevo";

            txtRepuNombre.ReadOnly = false;
            txtRepuNombre.BackColor = txtRepuDescripcion.BackColor;
            txtRepuNombre.Focus();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            activarControles();
            accion = "actualizar";

            txtRepuNombre.ReadOnly = true;
            txtRepuNombre.BackColor = txtInicio.BackColor;
            txtRepuDescripcion.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtRepuNombre.Text == String.Empty)
            {
                MessageBox.Show("Tiene que ingresar el Nombre del Repuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRepuNombre.Focus();
                return;
            }
            if (txtRepuDescripcion.Text == String.Empty)
            {
                MessageBox.Show("Tiene que ingresar la Descripción del Repuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRepuDescripcion.Focus();
                return;
            }
            if (accion == "nuevo")
            {
                tbRepuesto nuevoRepuesto = new tbRepuesto();
                nuevoRepuesto.repuNombre = this.txtRepuNombre.Text;
                nuevoRepuesto.repuDescripcion = this.txtRepuDescripcion.Text;
                Image img = picRepuImagen.Image;
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    nuevoRepuesto.repuImagen = ms.ToArray();
                }

                resultado = (new tbRepuestoBL()).InsTbRepuesto(nuevoRepuesto);

                if (resultado == "")
                {
                    MessageBox.Show("Se ingresó correctamente el Repuesto !!!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    desactivarControles();
                    posDataGridGuardar = posDataGrid;
                    ListarRepuesto();
                }
                else
                {
                    MessageBox.Show("No se pudo ingresar el Repuesto !!!\n" + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Repuesto.repuDescripcion = this.txtRepuDescripcion.Text;
                Image img = picRepuImagen.Image;
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    Repuesto.repuImagen = ms.ToArray();
                }


                resultado = (new tbRepuestoBL()).UpTbRepuesto(Repuesto);

                if (resultado == "")
                {
                    MessageBox.Show("Se actualizó correctamente el Repuesto !!!", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    desactivarControles();
                    posDataGridGuardar = posDataGrid;
                    ListarRepuesto();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el Repuesto !!!\n" + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgridLista.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Esta seguro de eliminar el Repuesto?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    resultado = (new tbRepuestoBL()).DelTbRepuesto(_repuId);

                    if (resultado == "")
                    {
                        MessageBox.Show("Se eliminó correctamente el Repuesto !!!", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        desactivarControles();
                        ListarRepuesto();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el Repuesto !!!\n" + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desactivarControles();
            posDataGridGuardar = posDataGrid;
            ListarRepuesto();

            txtRepuNombre.ReadOnly = true;
            txtRepuNombre.BackColor = txtInicio.BackColor;
        }
        private void btnFoto_Click(object sender, EventArgs e)
        {
            rutaFoto = cargarArchivos.SolicitarArchivo(cargarArchivos.filtroJpg);
            if (rutaFoto != string.Empty)
            {
                try
                {
                    this.picRepuImagen.Image = Image.FromFile(rutaFoto);
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
            txtRepuNombre.Text = "";
            txtRepuDescripcion.Text = "";
            picRepuImagen.Image = picInicio.Image;
        }
        private void RellenarItem()
        {
            Repuesto = (new tbRepuestoBL()).VerTbRepuestoByRepuId(_repuId);
            this.txtRepuNombre.Text = Repuesto.repuNombre;
            this.txtRepuDescripcion.Text = Repuesto.repuDescripcion;
            Byte[] image;
            image = Repuesto.repuImagen;
            MemoryStream stream = new MemoryStream(image);
            this.picRepuImagen.Image = Image.FromStream(stream);
        }
        private void ListarRepuesto()
        {
            try
            {
                dgridLista.AutoGenerateColumns = false;
                List<tbRepuesto> lista = (new tbRepuestoBL()).VerTbRepuestoLikeRepuNombre("");
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
