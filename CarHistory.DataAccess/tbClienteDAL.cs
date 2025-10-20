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
    public class tbClienteDAL : claseCadenaConexion
    {
        string resultado = "Error";

        public string InsTbCliente(tbCliente Cliente)
        {
            try
            {
                using (var oConexion = new SqlConnection(CadenaDeConexion()))
                {
                    oConexion.Open();
                    using (SqlCommand oCommand = new SqlCommand("proInsTbCliente", oConexion))
                    {
                        oCommand.CommandType = CommandType.StoredProcedure;

                        oCommand.Parameters.Add(new SqlParameter("@usuId", Cliente.usuId));
                        oCommand.Parameters.Add(new SqlParameter("@clieDocTipo", Cliente.clieDocTipo));
                        oCommand.Parameters.Add(new SqlParameter("@clieDocNumero", Cliente.clieDocNumero));
                        oCommand.Parameters.Add(new SqlParameter("@clieApePaterno", Cliente.clieApePaterno));
                        oCommand.Parameters.Add(new SqlParameter("@clieApeMaterno", Cliente.clieApeMaterno));
                        oCommand.Parameters.Add(new SqlParameter("@clieNombre", Cliente.clieNombre));
                        oCommand.Parameters.Add(new SqlParameter("@clieNombreApellidos", Cliente.clieNombreApellidos));
                        oCommand.Parameters.Add(new SqlParameter("@clieSexo", Cliente.clieSexo));
                        oCommand.Parameters.Add(new SqlParameter("@clieFechaNac", Cliente.clieFechaNac));
                        oCommand.Parameters.Add(new SqlParameter("@clieEmail", Cliente.clieEmail));
                        oCommand.Parameters.Add(new SqlParameter("@clieCelular", Cliente.clieCelular));
                        oCommand.Parameters.Add(new SqlParameter("@cliePais", Cliente.cliePais));
                        oCommand.Parameters.Add(new SqlParameter("@clieCiudad", Cliente.clieCiudad));
                        oCommand.Parameters.Add(new SqlParameter("@clieImagen", Cliente.clieImagen));
                        oCommand.Parameters.Add(new SqlParameter("@clieEstado", Cliente.clieEstado));
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

        public string UpTbCliente(tbCliente Cliente)
        {
            try
            {
                using (var oConexion = new SqlConnection(CadenaDeConexion()))
                {
                    oConexion.Open();
                    using (SqlCommand oCommand = new SqlCommand("proUpTbCliente", oConexion))
                    {
                        oCommand.CommandType = CommandType.StoredProcedure;
                        oCommand.Parameters.Add(new SqlParameter("@usuId", Cliente.usuId));
                        oCommand.Parameters.Add(new SqlParameter("@clieId", Cliente.clieId));
                        oCommand.Parameters.Add(new SqlParameter("@clieDocTipo", Cliente.clieDocTipo));
                        oCommand.Parameters.Add(new SqlParameter("@clieDocNumero", Cliente.clieDocNumero));
                        oCommand.Parameters.Add(new SqlParameter("@clieApePaterno", Cliente.clieApePaterno));
                        oCommand.Parameters.Add(new SqlParameter("@clieApeMaterno", Cliente.clieApeMaterno));
                        oCommand.Parameters.Add(new SqlParameter("@clieNombre", Cliente.clieNombre));
                        oCommand.Parameters.Add(new SqlParameter("@clieNombreApellidos", Cliente.clieNombreApellidos));
                        oCommand.Parameters.Add(new SqlParameter("@clieSexo", Cliente.clieSexo));
                        oCommand.Parameters.Add(new SqlParameter("@clieFechaNac", Cliente.clieFechaNac));
                        oCommand.Parameters.Add(new SqlParameter("@clieEmail", Cliente.clieEmail));
                        oCommand.Parameters.Add(new SqlParameter("@clieCelular", Cliente.clieCelular));
                        oCommand.Parameters.Add(new SqlParameter("@cliePais", Cliente.cliePais));
                        oCommand.Parameters.Add(new SqlParameter("@clieCiudad", Cliente.clieCiudad));
                        oCommand.Parameters.Add(new SqlParameter("@clieImagen", Cliente.clieImagen));
                        oCommand.Parameters.Add(new SqlParameter("@clieEstado", Cliente.clieEstado));
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

        public string DelTbCliente(int clieId)
        {
            try
            {
                using (var oConexion = new SqlConnection(CadenaDeConexion()))
                {
                    oConexion.Open();
                    using (SqlCommand oCommand = new SqlCommand("proDelTbCliente", oConexion))
                    {
                        oCommand.CommandType = CommandType.StoredProcedure;
                        oCommand.Parameters.Add(new SqlParameter("@clieId", clieId));

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

        public tbCliente VerTbClienteByClieId(int clieId)
        {
            tbCliente item = new tbCliente();

            using (var oConexion = new SqlConnection(CadenaDeConexion()))
            {
                oConexion.Open();
                using (SqlCommand oCommand = new SqlCommand("proVerTbClienteByClieId", oConexion))
                {
                    oCommand.CommandType = CommandType.StoredProcedure;
                    oCommand.Parameters.Add(new SqlParameter("@clieId", clieId));

                    IDataReader reader = oCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        item.clieId = Convert.ToInt32(reader["clieId"]);
                        item.usuId = reader["usuId"] != DBNull.Value ? Convert.ToInt32(reader["usuId"]) : (int?)null;
                        item.clieDocTipo = Convert.ToString(reader["clieDocTipo"]);
                        item.clieDocNumero = Convert.ToString(reader["clieDocNumero"]);
                        item.clieApePaterno = Convert.ToString(reader["clieApePaterno"]);
                        item.clieApeMaterno = Convert.ToString(reader["clieApeMaterno"]);
                        item.clieNombre = Convert.ToString(reader["clieNombre"]);
                        item.clieNombreApellidos = Convert.ToString(reader["clieNombreApellidos"]);
                        item.clieSexo = Convert.ToString(reader["clieSexo"]);
                        item.clieFechaNac = reader["clieFechaNac"] != DBNull.Value ? Convert.ToDateTime(reader["clieFechaNac"]) : (DateTime?)null;
                        item.clieEmail = Convert.ToString(reader["clieEmail"]);
                        item.clieCelular = Convert.ToString(reader["clieCelular"]);
                        item.cliePais = Convert.ToString(reader["cliePais"]);
                        item.clieCiudad = Convert.ToString(reader["clieCiudad"]);
                        item.clieImagen = (byte[])(reader["clieImagen"]);
                        item.clieEstado = reader["clieEstado"] != DBNull.Value ? Convert.ToInt32(reader["clieEstado"]) : (int?)null;

                        break;
                    }
                    reader.Close();
                }
                oConexion.Close();
            }
            return item;
        }

        public List<tbCliente> VerTbClienteLikeClieDocNumero(string clieDocNumero)
        {
            List<tbCliente> lista = new List<tbCliente>();
            tbCliente item;
            try
            {
                using (var oConexion = new SqlConnection(CadenaDeConexion()))
                {
                    oConexion.Open();
                    using (SqlCommand oCommand = new SqlCommand("proVerTbClienteLikeClieDocNumero", oConexion))
                    {
                        oCommand.CommandType = CommandType.StoredProcedure;
                        oCommand.Parameters.Add(new SqlParameter("@clieDocNumero", clieDocNumero));

                        IDataReader reader = oCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            item = new tbCliente();
                            item.clieId = Convert.ToInt32(reader["clieId"]);
                            item.clieDocTipo = Convert.ToString(reader["clieDocTipo"]);
                            item.clieDocNumero = Convert.ToString(reader["clieDocNumero"]);
                            item.clieNombreApellidos = Convert.ToString(reader["clieNombreApellidos"]);
                            item.clieSexo = Convert.ToString(reader["clieSexo"]);
                            item.clieEmail = Convert.ToString(reader["clieEmail"]);
                            item.clieCelular = Convert.ToString(reader["clieCelular"]);
                            item.clieEstado = reader["clieEstado"] != DBNull.Value ? Convert.ToInt32(reader["clieEstado"]) : (int?)null;

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
