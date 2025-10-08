using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHistory.BusinessEntities
{
    public class tbUsuario
    {
        public int usuId { get; set; }
        public int rolId { get; set; }
        public string usuUsuario { get; set; }
        public string usuPassword { get; set; }
        public int usuEstado { get; set; }
        public string usuDescripcion { get; set; }
        public DateTime fecServidor { get; set; }

        public tbUsuario()
        {
            usuId = 0;
            rolId = 0;
            usuUsuario = string.Empty;
            usuPassword = string.Empty;
            usuEstado = 0;
            usuDescripcion = string.Empty;
            fecServidor = DateTime.Now;
        }
    }
}
