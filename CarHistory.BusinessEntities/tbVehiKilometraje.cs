using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHistory.BusinessEntities
{
    public class tbVehiKilometraje
    {
        public int vehiKiloId { get; set; }
        public int vehiId { get; set; }
        public decimal vehiKiloValor { get; set; }
        public DateTime vehiKiloFecha { get; set; }

        public tbVehiKilometraje()
        {
            vehiKiloId = 0;
            vehiId = 0;
            vehiKiloValor = 0m;
            vehiKiloFecha = DateTime.Now;
        }
    }
}
