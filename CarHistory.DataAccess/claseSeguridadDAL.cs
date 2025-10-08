using CarHistory.BusinessEntities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHistory.DataAccess
{
    public class claseSeguridadDAL : claseCadenaConexion
    {
        public tbUsuario verUsuarioPassword(tbUsuario usuario)
        {
            tbUsuario item = new tbUsuario();

            using (var oConexion = new SqlConnection(CadenaDeConexion()))
            {
                oConexion.Open();
                using (SqlCommand oCommand = new SqlCommand("proVerUsuarioPassword", oConexion))
                {
                    oCommand.CommandType = CommandType.StoredProcedure;

                    oCommand.Parameters.Add(new SqlParameter("@usuUsuario", usuario.usuUsuario));
                    oCommand.Parameters.Add(new SqlParameter("@usuPassword", usuario.usuPassword));

                    IDataReader reader = oCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        item.usuId = Convert.ToInt32(reader["usuId"]);
                        item.rolId = Convert.ToInt32(reader["rolId"]);
                        item.usuUsuario = Convert.ToString(reader["usuUsuario"]);
                        item.usuPassword = Convert.ToString(reader["usuPassword"]);
                        item.usuDescripcion = Convert.ToString(reader["usuDescripcion"]);
                        item.usuEstado = Convert.ToInt32(reader["usuEstado"]);
                        //item.rolNombre = Convert.ToString(reader["rolNombre"]);
                        //item.rolDescripcion = Convert.ToString(reader["rolDescripcion"]);
                        //item.fecServidor = Convert.ToDateTime(reader["fecServidor"]);

                        break;
                    }
                    reader.Close();
                }
                oConexion.Close();
            }
            return item;
        }

        public List<tbMenu> verTbMenuByUsuario(int usuId)
        {
            List<tbMenu> listResult = new List<tbMenu>();
            tbMenu item;
            using (var oConexion = new SqlConnection(CadenaDeConexion()))
            {
                oConexion.Open();
                using (SqlCommand oCommand = new SqlCommand("proVerTbMenuByUsuario", oConexion))
                {

                    oCommand.CommandType = CommandType.StoredProcedure;
                    oCommand.Parameters.Add(new SqlParameter("@usuId", usuId));

                    IDataReader reader = oCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        item = new tbMenu();

                        item.menuId = Convert.ToString(reader["menuId"]);
                        item.menuNombre = Convert.ToString(reader["menuNombre"]);
                        item.menuNomControl = Convert.ToString(reader["menuNomControl"]);
                        item.menuNomNameSpace = Convert.ToString(reader["menuNomNameSpace"]);
                        item.menuNomFormulario = Convert.ToString(reader["menuNomFormulario"]);
                        item.menuActividad = Convert.ToString(reader["menuActividad"]);
                        item.menuEstado = Convert.ToInt32(reader["menuEstado"]);

                        listResult.Add(item);
                    }
                    reader.Close();
                }
                oConexion.Close();
            }
            return listResult;
        }
    }
}
