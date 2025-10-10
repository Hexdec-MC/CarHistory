using System;

namespace CarHistory.BusinessEntities
{
    public class tbClienteVehiculo
    {
        public int clieId { get; set; }                       // FK a tbCliente
        public int vehiId { get; set; }                       // FK a tbVehiculo
        public DateTime? clieVehiFechaRegistro { get; set; }  // Fecha de registro
        public int? clieVehiEstado { get; set; }              // Estado (activo/inactivo)

        // Propiedades de navegación (opcional si usas Entity Framework)
        public tbCliente Cliente { get; set; }
        public tbVehiculo Vehiculo { get; set; }

        // Constructor con valores predeterminados
        public tbClienteVehiculo()
        {
            clieId = 0;
            vehiId = 0;
            clieVehiFechaRegistro = null;
            clieVehiEstado = null;
            Cliente = null;
            Vehiculo = null;
        }
    }
}
