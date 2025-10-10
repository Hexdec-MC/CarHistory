using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHistory.BusinessEntities
{
    public class tbRepuesto
    {
        public int repuId { get; set; }
        public string repuNombre { get; set; }
        public string repuDescripcion { get; set; }
        public byte[] repuImagen { get; set; }

        public tbRepuesto()
        {
            repuId = 0;
            repuNombre = string.Empty;
            repuDescripcion = string.Empty;
            repuImagen = new byte[0];
        }
    }
}
