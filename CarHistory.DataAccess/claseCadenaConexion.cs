using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHistory.DataAccess
{
    public class claseCadenaConexion
    {
        public string CadenaDeConexion()
        {
            //string cadenaConexion = "Data Source=ServerSantaRosa;Initial Catalog=SIASantaRosa;User Id=sa;Password=20107879;";

            //string cadenaConexion = "Data Source=Servidor\\MSSQLSERVER01;Initial Catalog=SIACetpro2024;User Id=sa;Password=20107879;";

            string cadenaConexion = "Data Source=SQL8011.site4now.net;Initial Catalog=db_aabba1_carhistory;User Id=db_aabba1_carhistory_admin;Password=C@rdhistory2025;";

            return cadenaConexion;
        }
    }
}
