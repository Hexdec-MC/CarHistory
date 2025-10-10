using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHistory.BusinessEntities
{
    public class tbRepuMarca
    {
        public int repuMarId { get; set; }
        public string repuMarNombre { get; set; }
        public string repuMarPais { get; set; }
        public byte[] repuMarLogo { get; set; }

        public tbRepuMarca()
        {
            repuMarId = 0;
            repuMarNombre = string.Empty;
            repuMarPais = string.Empty;
            repuMarLogo = new byte[0];
        }
    }
}
