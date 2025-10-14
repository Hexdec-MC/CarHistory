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

namespace CarHistory.form.Repuesto
{
    public partial class frmRepuestoMarca : frmBase
    {
        public frmRepuestoMarca(tbUsuario usuario, tbMenu menu) : base(usuario, menu)
        {
            InitializeComponent();
            darFormato(Controls);
        }
    }
}
