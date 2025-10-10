using System;

namespace CarHistory.BusinessEntities
{
    public class tbVehiculo
    {
        public int vehiId { get; set; }                       // ID del vehículo (IDENTITY)
        public int? vehiModeId { get; set; }                  // FK a tbVehiModelo
        public string vehiPais { get; set; }                  // País de registro
        public string vehiPlaca { get; set; }                 // Placa del vehículo
        public DateTime? vehiFechaRegistro { get; set; }      // Fecha de registro
        public int? vehiEstado { get; set; }                  // Estado (activo/inactivo)

        // Propiedad de navegación (opcional si usas Entity Framework)
        public tbVehiModelo VehiModelo { get; set; }

        // Constructor con valores por defecto
        public tbVehiculo()
        {
            vehiId = 0;
            vehiModeId = null;
            vehiPais = string.Empty;
            vehiPlaca = string.Empty;
            vehiFechaRegistro = null;
            vehiEstado = null;
            VehiModelo = null;
        }
    }
}
