using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHistory.BusinessEntities
{
    public class tbVehiCategoria
    {
        public int vehiCateId { get; set; }
        public string vehiCateNombre { get; set; }
        public string vehiCateDescripcion { get; set; }
        public int vehiCateEstado { get; set; }

        public tbVehiCategoria()
        {
            vehiCateId = 0;
            vehiCateNombre = string.Empty;
            vehiCateDescripcion = string.Empty;
            vehiCateEstado = 0;
        }
    }
}
