using System;

namespace CarHistory.BusinessEntities
{
    public class tbCliente
    {
        public int clieId { get; set; }                // ID principal (IDENTITY)
        public int? usuId { get; set; }                // FK a tbUsuario
        public string clieDocTipo { get; set; }        // Tipo de documento
        public string clieDocNumero { get; set; }      // Número de documento
        public string clieApePaterno { get; set; }     // Apellido paterno
        public string clieApeMaterno { get; set; }     // Apellido materno
        public string clieNombre { get; set; }         // Nombres
        public string clieNombreApellidos { get; set; }// Nombre completo
        public string clieSexo { get; set; }           // Sexo
        public DateTime? clieFechaNac { get; set; }    // Fecha de nacimiento
        public string clieEmail { get; set; }          // Correo electrónico
        public string clieCelular { get; set; }        // Teléfono o celular
        public string cliePais { get; set; }           // País
        public string clieCiudad { get; set; }         // Ciudad
        public byte[] clieImagen { get; set; }         // Imagen (campo image en SQL)
        public int? clieEstado { get; set; }           // Estado (activo/inactivo)

        // Constructor con valores predeterminados
        public tbCliente()
        {
            clieId = 0;
            usuId = null;
            clieDocTipo = string.Empty;
            clieDocNumero = string.Empty;
            clieApePaterno = string.Empty;
            clieApeMaterno = string.Empty;
            clieNombre = string.Empty;
            clieNombreApellidos = string.Empty;
            clieSexo = string.Empty;
            clieFechaNac = null;
            clieEmail = string.Empty;
            clieCelular = string.Empty;
            cliePais = string.Empty;
            clieCiudad = string.Empty;
            clieImagen = new byte[0];
            clieEstado = null;
        }
    }
}
