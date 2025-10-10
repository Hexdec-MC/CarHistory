using System;

namespace CarHistory.BusinessEntities
{
    public class tbMantenimiento
    {
        public string mantId { get; set; }        // Identificador del mantenimiento
        public string mantNombre { get; set; }    // Nombre o tipo de mantenimiento

        // Constructor con valores por defecto
        public tbMantenimiento()
        {
            mantId = string.Empty;
            mantNombre = string.Empty;
        }
    }
}
