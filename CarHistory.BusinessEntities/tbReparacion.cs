using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHistory.BusinessEntities
{
    public class tbReparacion
    {
        public int repaId { get; set; }
        public int vehiId { get; set; }
        public int usuId { get; set; }
        public int repaTipoId { get; set; }
        public DateTime repaFecha { get; set; }
        public string repaDescripcion { get; set; }
        public decimal repaCosto { get; set; }
        public decimal repaKilometraje { get; set; }
        public string repaMantenimiento { get; set; }

        public tbReparacion()
        {
            repaId = 0;
            vehiId = 0;
            usuId = 0;
            repaTipoId = 0;
            repaFecha = DateTime.Now;
            repaDescripcion = string.Empty;
            repaCosto = 0m;
            repaKilometraje = 0m;
            repaMantenimiento = string.Empty;
        }
    }
}
