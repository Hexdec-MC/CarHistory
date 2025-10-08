using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHistory.BusinessEntities
{
    public class tbVehiModelo
    {
        public int vehiModeId { get; set; }
        public int vehiMarId { get; set; }
        public int vehiCateId { get; set; }
        public string vehiModeNombre { get; set; }
        public string vehiModeDescripcion { get; set; }
        public string vehiModeCombustible { get; set; }
        public string vehiModeRodaje { get; set; }
        public string vehiModeAro { get; set; }
        public string vehiModeAnio { get; set; }
        public byte[] vehiModeImagen { get; set; }
        public int vehiModeEstado { get; set; }

        public int vehiModeCombId { get; set; }
        public string vehiModeCombNombre { get; set; }
        public string vehiModeCombDescripcion { get; set; }

        public int vehiModeAroId { get; set; }
        public string vehiModeAroNombre { get; set; }
        public string vehiModeAroDescripcion { get; set; }

        public int vehiModeRodaId { get; set; }
        public string vehiModeRodaNombre { get; set; }
        public string vehiModeRodaDescripcion { get; set; }

        public tbVehiModelo()
        {
            vehiModeId = 0;
            vehiMarId = 0;
            vehiCateId = 0;
            vehiModeNombre = string.Empty;
            vehiModeDescripcion = string.Empty;
            vehiModeCombustible = string.Empty;
            vehiModeRodaje = string.Empty;
            vehiModeAro = string.Empty;
            vehiModeAnio = string.Empty;
            vehiModeImagen = new byte[0];
            vehiModeEstado = 0;

            vehiModeCombId = 0;
            vehiModeCombNombre = string.Empty;
            vehiModeCombDescripcion = string.Empty;

            vehiModeAroId = 0;
            vehiModeAroNombre = string.Empty;
            vehiModeAroDescripcion = string.Empty;

            vehiModeRodaId = 0;
            vehiModeRodaNombre = string.Empty;
            vehiModeRodaDescripcion = string.Empty;
        }
    }
}
