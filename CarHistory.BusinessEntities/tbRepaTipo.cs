using System;

namespace CarHistory.BusinessEntities
{
    public class tbRepaTipo
    {
        public int repaTipoId { get; set; }               // ID del tipo de reparación (IDENTITY)
        public string repaTipoNombre { get; set; }        // Nombre del tipo de reparación
        public string repaTipoDescripcion { get; set; }   // Descripción detallada del tipo

        // Constructor con valores por defecto
        public tbRepaTipo()
        {
            repaTipoId = 0;
            repaTipoNombre = string.Empty;
            repaTipoDescripcion = string.Empty;
        }
    }
}
