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
    public class tbRepuMarcaDAL : claseCadenaConexion
    {
        string resultado = "Error";
        public string InsTbRepuMarca(tbRepuMarca Marca)
        {
            try
            {
                using (var oConexion = new SqlConnection(CadenaDeConexion()))
                {
                    oConexion.Open();
                    using (SqlCommand oCommand = new SqlCommand("proInsTbRepuestoMarca", oConexion))
                    {
                        oCommand.CommandType = CommandType.StoredProcedure;

                        oCommand.Parameters.Add(new SqlParameter("@repuMarNombre", Marca.repuMarNombre));
                        oCommand.Parameters.Add(new SqlParameter("@repuMarPais", Marca.repuMarPais));
                        oCommand.Parameters.Add(new SqlParameter("@repuMarLogo", Marca.repuMarLogo));
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
        public string UpTbRepuMarca(tbRepuMarca Marca)
        {
            try
            {
                using (var oConexion = new SqlConnection(CadenaDeConexion()))
                {
                    oConexion.Open();
                    using (SqlCommand oCommand = new SqlCommand("proUpTbRepuestoMarca", oConexion))
                    {
                        oCommand.CommandType = CommandType.StoredProcedure;
                        oCommand.Parameters.Add(new SqlParameter("@repuMarId", Marca.repuMarId));
                        oCommand.Parameters.Add(new SqlParameter("@repuMarNombre", Marca.repuMarNombre));
                        oCommand.Parameters.Add(new SqlParameter("@repuMarPais", Marca.repuMarPais));
                        oCommand.Parameters.Add(new SqlParameter("@repuMarLogo", Marca.repuMarLogo));
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
        public string DelTbRepuMarca(int repuMarId)
        {
            try
            {
                using (var oConexion = new SqlConnection(CadenaDeConexion()))
                {
                    oConexion.Open();
                    using (SqlCommand oCommand = new SqlCommand("proDelTbRepuestoMarca", oConexion))
                    {
                        oCommand.CommandType = CommandType.StoredProcedure;
                        oCommand.Parameters.Add(new SqlParameter("@repuMarId", repuMarId));

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

        public tbRepuMarca VerTbRepuMarcaByRepuMarId(int repuMarId)
        {
            tbRepuMarca item = new tbRepuMarca();

            using (var oConexion = new SqlConnection(CadenaDeConexion()))
            {
                oConexion.Open();
                using (SqlCommand oCommand = new SqlCommand("proVerTbRepuestoMarcaByRepuMarId", oConexion))
                {
                    oCommand.CommandType = CommandType.StoredProcedure;
                    oCommand.Parameters.Add(new SqlParameter("@repuMarId", repuMarId));

                    IDataReader reader = oCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        item.repuMarId = Convert.ToInt32(reader["repuMarId"]);
                        item.repuMarNombre = Convert.ToString(reader["repuMarNombre"]);
                        item.repuMarPais = Convert.ToString(reader["repuMarPais"]);
                        item.repuMarLogo = (byte[])(reader["repuMarLogo"]);

                        break;
                    }
                    reader.Close();
                }
                oConexion.Close();
            }
            return item;
        }

        public List<tbRepuMarca> VerTbRepuMarcaLikeRepuMarNombre(string repuMarNombre)
        {
            List<tbRepuMarca> lista = new List<tbRepuMarca>();
            tbRepuMarca item;
            try
            {
                using (var oConexion = new SqlConnection(CadenaDeConexion()))
                {
                    oConexion.Open();
                    using (SqlCommand oCommand = new SqlCommand("proVerTbRepuestoMarcaLikeNombre", oConexion))
                    {
                        oCommand.CommandType = CommandType.StoredProcedure;
                        oCommand.Parameters.Add(new SqlParameter("@repuMarNombre", repuMarNombre));

                        IDataReader reader = oCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            item = new tbRepuMarca();
                            item.repuMarId = Convert.ToInt32(reader["repuMarId"]);
                            item.repuMarNombre = Convert.ToString(reader["repuMarNombre"]);
                            item.repuMarPais = Convert.ToString(reader["repuMarPais"]);

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
