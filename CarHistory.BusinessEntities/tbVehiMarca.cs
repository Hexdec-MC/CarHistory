using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHistory.BusinessEntities
{
    public class tbVehiMarca
    {
        public int vehiMarId { get; set; }
        public string vehiMarNombre { get; set; }
        public string vehiMarDescripcion { get; set; }
        public byte[] vehiMarLogo { get; set; }
        public int vehiMarEstado { get; set; }
     
        public tbVehiMarca()
        {
            vehiMarId = 0;
            vehiMarNombre = string.Empty;
            vehiMarDescripcion = string.Empty;
            vehiMarLogo = new byte[0];
            vehiMarEstado = 0;
        }
    }
}
