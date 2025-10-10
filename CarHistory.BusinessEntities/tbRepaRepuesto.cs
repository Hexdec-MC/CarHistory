using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHistory.BusinessEntities
{
    public class tbRepaRepuesto
    {
        public int repaId { get; set; }
        public int repuId { get; set; }
        public int repuMarId { get; set; }
        public decimal repaRepuCantidad { get; set; }
        public string repaRepuDescripcion { get; set; }
        public string repaRepuCompatible { get; set; }

        public tbRepaRepuesto()
        {
            repaId = 0;
            repuId = 0;
            repuMarId = 0;
            repaRepuCantidad = 0m;
            repaRepuDescripcion = string.Empty;
            repaRepuCompatible = string.Empty;
        }
    }
}
