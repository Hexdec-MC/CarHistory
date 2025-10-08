using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarHistory.BusinessEntities;
using Microsoft.Data.SqlClient;

namespace CarHistory.DataAccess
{
    public class tbVehiMarcaDAL : claseCadenaConexion
    {
        string resultado = "Error";
        public string InsTbVehiMarca(tbVehiMarca Marca)
        {
            try
            {
                using (var oConexion = new SqlConnection(CadenaDeConexion()))
                {
                    oConexion.Open();
                    using (SqlCommand oCommand = new SqlCommand("proInsTbVehiMarca", oConexion))
                    {
                        oCommand.CommandType = CommandType.StoredProcedure;

                        oCommand.Parameters.Add(new SqlParameter("@vehiMarNombre", Marca.vehiMarNombre));
                        oCommand.Parameters.Add(new SqlParameter("@vehiMarDescripcion", Marca.vehiMarDescripcion));
                        oCommand.Parameters.Add(new SqlParameter("@vehiMarLogo", Marca.vehiMarLogo));
                        oCommand.Parameters.Add(new SqlParameter("@vehiMarEstado", Marca.vehiMarEstado));
                        oCommand.ExecuteNonQuery();

                        resultado = "";
                    }
                    oConexion.Close();
                }
            }
            catch (Exception e)
            {
                resultado = Convert.ToString(e.Message);
            }

            return resultado;
        }
        public string UpTbVehiMarca(tbVehiMarca Marca)
        {
            try
            {
                using (var oConexion = new SqlConnection(CadenaDeConexion()))
                {
                    oConexion.Open();
                    using (SqlCommand oCommand = new SqlCommand("proUpTbVehiMarca", oConexion))
                    {
                        oCommand.CommandType = CommandType.StoredProcedure;
                        oCommand.Parameters.Add(new SqlParameter("@vehiMarId", Marca.vehiMarId));
                        oCommand.Parameters.Add(new SqlParameter("@vehiMarNombre", Marca.vehiMarNombre));
                        oCommand.Parameters.Add(new SqlParameter("@vehiMarDescripcion", Marca.vehiMarDescripcion));
                        oCommand.Parameters.Add(new SqlParameter("@vehiMarLogo", Marca.vehiMarLogo));
                        oCommand.Parameters.Add(new SqlParameter("@vehiMarEstado", Marca.vehiMarEstado));
                        oCommand.ExecuteNonQuery();

                        resultado = "";
                    }
                    oConexion.Close();
                }
            }
            catch (Exception e)
            {
                resultado = Convert.ToString(e.Message);
            }

            return resultado;
        }
        public string DelTbVehiMarca(int vehiMarId)
        {
            try
            {
                using (var oConexion = new SqlConnection(CadenaDeConexion()))
                {
                    oConexion.Open();
                    using (SqlCommand oCommand = new SqlCommand("proDelTbVehiMarca", oConexion))
                    {
                        oCommand.CommandType = CommandType.StoredProcedure;
                        oCommand.Parameters.Add(new SqlParameter("@vehiMarId", vehiMarId));

                        oCommand.ExecuteNonQuery();
                        resultado = "";
                    }
                    oConexion.Close();
                }
            }
            catch (Exception e)
            {
                resultado = Convert.ToString(e.Message);
            }
            return resultado;
        }

        public tbVehiMarca VerTbVehiMarcaByVehiMarId(int vehiMarId)
        {
            tbVehiMarca item = new tbVehiMarca();

            using (var oConexion = new SqlConnection(CadenaDeConexion()))
            {
                oConexion.Open();
                using (SqlCommand oCommand = new SqlCommand("proVerTbVehiMarcaByVehiMarId", oConexion))
                {
                    oCommand.CommandType = CommandType.StoredProcedure;
                    oCommand.Parameters.Add(new SqlParameter("@vehiMarId", vehiMarId));

                    IDataReader reader = oCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        item.vehiMarId = Convert.ToInt32(reader["vehiMarId"]);
                        item.vehiMarNombre = Convert.ToString(reader["vehiMarNombre"]);
                        item.vehiMarDescripcion = Convert.ToString(reader["vehiMarDescripcion"]);
                        item.vehiMarLogo = (byte[])(reader["vehiMarLogo"]);
                        item.vehiMarEstado = Convert.ToInt32(reader["vehiMarEstado"]);

                        break;
                    }
                    reader.Close();
                }
                oConexion.Close();
            }
            return item;
        }

        public List<tbVehiMarca> VerTbVehiMarcaLikeVehiMarNombre(string vehiMarNombre)
        {
            List<tbVehiMarca> lista = new List<tbVehiMarca>();
            tbVehiMarca item;
            try
            {
                using (var oConexion = new SqlConnection(CadenaDeConexion()))
                {
                    oConexion.Open();
                    using (SqlCommand oCommand = new SqlCommand("proVerTbVehiMarcaLikeVehiMarNombre", oConexion))
                    {
                        oCommand.CommandType = CommandType.StoredProcedure;
                        oCommand.Parameters.Add(new SqlParameter("@vehiMarNombre", vehiMarNombre));

                        IDataReader reader = oCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            item = new tbVehiMarca();
                            item.vehiMarId = Convert.ToInt32(reader["vehiMarId"]);
                            item.vehiMarNombre = Convert.ToString(reader["vehiMarNombre"]);
                            item.vehiMarDescripcion = Convert.ToString(reader["vehiMarDescripcion"]);
                            item.vehiMarEstado = Convert.ToInt32(reader["vehiMarEstado"]);

                            lista.Add(item);
                        }
                        reader.Close();
                    }
                    oConexion.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }
    }
}
