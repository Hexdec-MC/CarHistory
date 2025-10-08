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
    public class tbVehiCategoriaDAL : claseCadenaConexion
    {
        string resultado = "Error";
        public string InsTbVehiCategoria(tbVehiCategoria Categoria)
        {
            try
            {
                using (var oConexion = new SqlConnection(CadenaDeConexion()))
                {
                    oConexion.Open();
                    using (SqlCommand oCommand = new SqlCommand("proInsTbVehiCategoria", oConexion))
                    {
                        oCommand.CommandType = CommandType.StoredProcedure;

                        oCommand.Parameters.Add(new SqlParameter("@vehiCateNombre", Categoria.vehiCateNombre));
                        oCommand.Parameters.Add(new SqlParameter("@vehiCateDescripcion", Categoria.vehiCateDescripcion));
                        oCommand.Parameters.Add(new SqlParameter("@vehiCateEstado", Categoria.vehiCateEstado));
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
        public string UpTbVehiCategoria(tbVehiCategoria Categoria)
        {
            try
            {
                using (var oConexion = new SqlConnection(CadenaDeConexion()))
                {
                    oConexion.Open();
                    using (SqlCommand oCommand = new SqlCommand("proUpTbVehiCategoria", oConexion))
                    {
                        oCommand.CommandType = CommandType.StoredProcedure;
                        oCommand.Parameters.Add(new SqlParameter("@vehiCateId", Categoria.vehiCateId));
                        oCommand.Parameters.Add(new SqlParameter("@vehiCateNombre", Categoria.vehiCateNombre));
                        oCommand.Parameters.Add(new SqlParameter("@vehiCateDescripcion", Categoria.vehiCateDescripcion));
                        oCommand.Parameters.Add(new SqlParameter("@vehiCateEstado", Categoria.vehiCateEstado));
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
        public string DelTbVehiCategoria(int vehiCateId)
        {
            try
            {
                using (var oConexion = new SqlConnection(CadenaDeConexion()))
                {
                    oConexion.Open();
                    using (SqlCommand oCommand = new SqlCommand("proDelTbVehiCategoria", oConexion))
                    {
                        oCommand.CommandType = CommandType.StoredProcedure;
                        oCommand.Parameters.Add(new SqlParameter("@vehiCateId", vehiCateId));

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

        public tbVehiCategoria VerTbVehiCategoriaByVehiCateId(int vehiCateId)
        {
            tbVehiCategoria item = new tbVehiCategoria();

            using (var oConexion = new SqlConnection(CadenaDeConexion()))
            {
                oConexion.Open();
                using (SqlCommand oCommand = new SqlCommand("proVerTbVehiCategoriaByVehiCateId", oConexion))
                {
                    oCommand.CommandType = CommandType.StoredProcedure;
                    oCommand.Parameters.Add(new SqlParameter("@vehiCateId", vehiCateId));

                    IDataReader reader = oCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        item.vehiCateId = Convert.ToInt32(reader["vehiCateId"]);
                        item.vehiCateNombre = Convert.ToString(reader["vehiCateNombre"]);
                        item.vehiCateDescripcion = Convert.ToString(reader["vehiCateDescripcion"]);
                        item.vehiCateEstado = Convert.ToInt32(reader["vehiCateEstado"]);

                        break;
                    }
                    reader.Close();
                }
                oConexion.Close();
            }
            return item;
        }

        public List<tbVehiCategoria> VerTbVehiCategoriaLikeNombre(string vehiCateNombre)
        {
            List<tbVehiCategoria> lista = new List<tbVehiCategoria>();
            tbVehiCategoria item;
            try
            {
                using (var oConexion = new SqlConnection(CadenaDeConexion()))
                {
                    oConexion.Open();
                    using (SqlCommand oCommand = new SqlCommand("proVerTbVehiCategoriaLikeNombre", oConexion))
                    {
                        oCommand.CommandType = CommandType.StoredProcedure;
                        oCommand.Parameters.Add(new SqlParameter("@vehiCateNombre", vehiCateNombre));

                        IDataReader reader = oCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            item = new tbVehiCategoria();
                            item.vehiCateId = Convert.ToInt32(reader["vehiCateId"]);
                            item.vehiCateNombre = Convert.ToString(reader["vehiCateNombre"]);
                            item.vehiCateDescripcion = Convert.ToString(reader["vehiCateDescripcion"]);
                            item.vehiCateEstado = Convert.ToInt32(reader["vehiCateEstado"]);

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
