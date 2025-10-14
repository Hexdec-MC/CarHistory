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
    public class tbRepuestoDAL : claseCadenaConexion
    {
        string resultado = "Error";
        public string InsTbRepuesto(tbRepuesto Repuesto)
        {
            try
            {
                using (var oConexion = new SqlConnection(CadenaDeConexion()))
                {
                    oConexion.Open();
                    using (SqlCommand oCommand = new SqlCommand("proInsTbRepuesto", oConexion))
                    {
                        oCommand.CommandType = CommandType.StoredProcedure;

                        oCommand.Parameters.Add(new SqlParameter("@repuNombre", Repuesto.repuNombre));
                        oCommand.Parameters.Add(new SqlParameter("@repuDescripcion", Repuesto.repuDescripcion));
                        oCommand.Parameters.Add(new SqlParameter("@repuImagen", Repuesto.repuImagen));
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
        public string UpTbRepuesto(tbRepuesto Repuesto)
        {
            try
            {
                using (var oConexion = new SqlConnection(CadenaDeConexion()))
                {
                    oConexion.Open();
                    using (SqlCommand oCommand = new SqlCommand("proUpTbRepuesto", oConexion))
                    {
                        oCommand.CommandType = CommandType.StoredProcedure;
                        oCommand.Parameters.Add(new SqlParameter("@repuId", Repuesto.repuId));
                        oCommand.Parameters.Add(new SqlParameter("@repuNombre", Repuesto.repuNombre));
                        oCommand.Parameters.Add(new SqlParameter("@repuDescripcion", Repuesto.repuDescripcion));
                        oCommand.Parameters.Add(new SqlParameter("@repuImagen", Repuesto.repuImagen));
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
        public string DelTbRepuesto(int repuId)
        {
            try
            {
                using (var oConexion = new SqlConnection(CadenaDeConexion()))
                {
                    oConexion.Open();
                    using (SqlCommand oCommand = new SqlCommand("proDelTbRepuesto", oConexion))
                    {
                        oCommand.CommandType = CommandType.StoredProcedure;
                        oCommand.Parameters.Add(new SqlParameter("@repuId", repuId));

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

        public tbRepuesto VerTbRepuestoByRepuId(int repuId)
        {
            tbRepuesto item = new tbRepuesto();

            using (var oConexion = new SqlConnection(CadenaDeConexion()))
            {
                oConexion.Open();
                using (SqlCommand oCommand = new SqlCommand("proVerTbRepuestoByRepuId", oConexion))
                {
                    oCommand.CommandType = CommandType.StoredProcedure;
                    oCommand.Parameters.Add(new SqlParameter("@repuId", repuId));

                    IDataReader reader = oCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        item.repuId = Convert.ToInt32(reader["repuId"]);
                        item.repuNombre = Convert.ToString(reader["repuNombre"]);
                        item.repuDescripcion = Convert.ToString(reader["repuDescripcion"]);
                        item.repuImagen = (byte[])(reader["repuImagen"]);

                        break;
                    }
                    reader.Close();
                }
                oConexion.Close();
            }
            return item;
        }

        public List<tbRepuesto> VerTbRepuestoLikeRepuNombre(string repuNombre)
        {
            List<tbRepuesto> lista = new List<tbRepuesto>();
            tbRepuesto item;
            try
            {
                using (var oConexion = new SqlConnection(CadenaDeConexion()))
                {
                    oConexion.Open();
                    using (SqlCommand oCommand = new SqlCommand("proVerTbRepuestoLikeNombre", oConexion))
                    {
                        oCommand.CommandType = CommandType.StoredProcedure;
                        oCommand.Parameters.Add(new SqlParameter("@repuNombre", repuNombre));

                        IDataReader reader = oCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            item = new tbRepuesto();
                            item.repuId = Convert.ToInt32(reader["repuId"]);
                            item.repuNombre = Convert.ToString(reader["repuNombre"]);
                            item.repuDescripcion = Convert.ToString(reader["repuDescripcion"]);

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
