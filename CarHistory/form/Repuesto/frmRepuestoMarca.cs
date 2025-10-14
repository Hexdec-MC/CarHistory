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
    public partial class frmRepuestoMarca : frmBase
    {
        int posDataGrid = 0;
        int posDataGridGuardar = 0;
        int _repuMarId = 0;
        string accion = "";
        string rutaFoto = "";
        string resultado = "Error";
        tbRepuMarca RepuMarca = new tbRepuMarca();
        public frmRepuestoMarca(tbUsuario usuario, tbMenu menu) : base(usuario, menu)
        {
            InitializeComponent();
            darFormato(Controls);

            ListarRepuestoMarca();
            desactivarControles();
        }

        private void dgridLista_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgridLista.SelectedRows.Count > 0)
            {
                posDataGrid = this.dgridLista.SelectedRows[0].Index;
                DataGridViewRow row = this.dgridLista.Rows[posDataGrid];

                _repuMarId = Convert.ToInt32(row.Cells["repuMarId"].Value.ToString());

                RellenarItem();
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            activarControles();
            limpiarControles();

            accion = "nuevo";

            txtRepuMarNombre.ReadOnly = false;
            txtRepuMarNombre.BackColor = txtRepuMarPais.BackColor;
            txtRepuMarNombre.Focus();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            activarControles();
            accion = "actualizar";

            txtRepuMarNombre.ReadOnly = true;
            txtRepuMarNombre.BackColor = txtInicio.BackColor;
            txtRepuMarPais.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtRepuMarNombre.Text == String.Empty)
            {
                MessageBox.Show("Tiene que ingresar la Marca del Repuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRepuMarNombre.Focus();
                return;
            }
            if (txtRepuMarPais.Text == String.Empty)
            {
                MessageBox.Show("Tiene que ingresar el País de la Marca", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRepuMarPais.Focus();
                return;
            }
            if (accion == "nuevo")
            {
                tbRepuMarca nuevoMarca = new tbRepuMarca();
                nuevoMarca.repuMarNombre = this.txtRepuMarNombre.Text;
                nuevoMarca.repuMarPais = this.txtRepuMarPais.Text;
                Image img = picRepuMarLogo.Image;
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    nuevoMarca.repuMarLogo = ms.ToArray();
                }

                resultado = (new tbRepuMarcaBL()).InsTbRepuMarca(nuevoMarca);

                if (resultado == "")
                {
                    MessageBox.Show("Se ingresó correctamente la Marca del Repuesto !!!", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    desactivarControles();
                    posDataGridGuardar = posDataGrid;
                    ListarRepuestoMarca();
                }
                else
                {
                    MessageBox.Show("No se pudo ingresar la Marca del Repuesto !!!\n" + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                RepuMarca.repuMarPais = this.txtRepuMarPais.Text;
                Image img = picRepuMarLogo.Image;
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    RepuMarca.repuMarLogo = ms.ToArray();
                }


                resultado = (new tbRepuMarcaBL()).UpTbRepuMarca(RepuMarca);

                if (resultado == "")
                {
                    MessageBox.Show("Se actualizó correctamente la Marca del Repuesto !!!", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    desactivarControles();
                    posDataGridGuardar = posDataGrid;
                    ListarRepuestoMarca();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la Marca del Repuesto !!!\n" + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgridLista.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Esta seguro de eliminar la Marca del Repuesto?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    resultado = (new tbRepuMarcaBL()).DelTbRepuMarca(_repuMarId);

                    if (resultado == "")
                    {
                        MessageBox.Show("Se eliminó correctamente la Marca del Repuesto !!!", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        desactivarControles();
                        ListarRepuestoMarca();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la Marca del Repuesto !!!\n" + resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desactivarControles();
            posDataGridGuardar = posDataGrid;
            ListarRepuestoMarca();

            txtRepuMarNombre.ReadOnly = true;
            txtRepuMarNombre.BackColor = txtInicio.BackColor;
        }
        private void btnFoto_Click(object sender, EventArgs e)
        {
            rutaFoto = cargarArchivos.SolicitarArchivo(cargarArchivos.filtroJpg);
            if (rutaFoto != string.Empty)
            {
                try
                {
                    this.picRepuMarLogo.Image = Image.FromFile(rutaFoto);
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
            txtRepuMarNombre.Text = "";
            txtRepuMarPais.Text = "";
            picRepuMarLogo.Image = picInicio.Image;
        }
        private void RellenarItem()
        {
            RepuMarca = (new tbRepuMarcaBL()).VerTbRepuMarcaByRepuMarId(_repuMarId);
            this.txtRepuMarNombre.Text = RepuMarca.repuMarNombre;
            this.txtRepuMarPais.Text = RepuMarca.repuMarPais;
            Byte[] image;
            image = RepuMarca.repuMarLogo;
            MemoryStream stream = new MemoryStream(image);
            this.picRepuMarLogo.Image = Image.FromStream(stream);
        }
        private void ListarRepuestoMarca()
        {
            try
            {
                dgridLista.AutoGenerateColumns = false;
                List<tbRepuMarca> lista = (new tbRepuMarcaBL()).VerTbRepuMarcaLikeRepuMarNombre("");
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
