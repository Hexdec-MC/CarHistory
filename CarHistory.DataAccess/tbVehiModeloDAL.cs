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
    public class tbVehiModeloDAL : claseCadenaConexion
    {
        string resultado = "Error";
        public string InsTbVehiModelo(tbVehiModelo Modelo)
        {
            try
            {
                using (var oConexion = new SqlConnection(CadenaDeConexion()))
                {
                    oConexion.Open();
                    using (SqlCommand oCommand = new SqlCommand("proInsTbVehiModelo", oConexion))
                    {
                        oCommand.CommandType = CommandType.StoredProcedure;

                        oCommand.Parameters.Add(new SqlParameter("@vehiMarId", Modelo.vehiMarId));
                        oCommand.Parameters.Add(new SqlParameter("@vehiCateId", Modelo.vehiCateId));
                        oCommand.Parameters.Add(new SqlParameter("@vehiModeNombre", Modelo.vehiModeNombre));
                        oCommand.Parameters.Add(new SqlParameter("@vehiModeDescripcion", Modelo.vehiModeDescripcion));
                        oCommand.Parameters.Add(new SqlParameter("@vehiModeCombustible", Modelo.vehiModeCombustible));
                        oCommand.Parameters.Add(new SqlParameter("@vehiModeRodaje", Modelo.vehiModeRodaje));
                        oCommand.Parameters.Add(new SqlParameter("@vehiModeAro", Modelo.vehiModeAro));
                        oCommand.Parameters.Add(new SqlParameter("@vehiModeAnio", Modelo.vehiModeAnio));
                        oCommand.Parameters.Add(new SqlParameter("@vehiModeImagen", Modelo.vehiModeImagen));
                        oCommand.Parameters.Add(new SqlParameter("@vehiModeEstado", Modelo.vehiModeEstado));
                        
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


        public tbVehiModelo VerTbVehiModeloByVehiModeId(int vehiModeId)
        {
            tbVehiModelo item = new tbVehiModelo();

            using (var oConexion = new SqlConnection(CadenaDeConexion()))
            {
                oConexion.Open();
                using (SqlCommand oCommand = new SqlCommand("proVerTbVehiModeloByVehiModeId", oConexion))
                {
                    oCommand.CommandType = CommandType.StoredProcedure;
                    oCommand.Parameters.Add(new SqlParameter("@vehiModeId", vehiModeId));

                    IDataReader reader = oCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        item.vehiModeId = Convert.ToInt32(reader["vehiModeId"]);
                        item.vehiMarId = Convert.ToInt32(reader["vehiMarId"]);
                        item.vehiCateId = Convert.ToInt32(reader["vehiCateId"]);
                        item.vehiModeNombre = Convert.ToString(reader["vehiModeNombre"]);
                        item.vehiModeDescripcion = Convert.ToString(reader["vehiModeDescripcion"]);
                        item.vehiModeCombustible = Convert.ToString(reader["vehiModeCombustible"]);
                        item.vehiModeRodaje = Convert.ToString(reader["vehiModeRodaje"]);
                        item.vehiModeAro = Convert.ToString(reader["vehiModeAro"]);
                        item.vehiModeAnio = Convert.ToString(reader["vehiModeAnio"]);
                        item.vehiModeImagen = (byte[])(reader["vehiModeImagen"]);
                        item.vehiModeEstado = Convert.ToInt32(reader["vehiModeEstado"]);

                        // [], [], [], [], [], []

                        break;
                    }
                    reader.Close();
                }
                oConexion.Close();
            }
            return item;
        }

        public List<tbVehiModelo> VerTbVehiModeloCombustible()
        {
            List<tbVehiModelo> lista = new List<tbVehiModelo>();
            tbVehiModelo item;
            try
            {
                using (var oConexion = new SqlConnection(CadenaDeConexion()))
                {
                    oConexion.Open();
                    using (SqlCommand oCommand = new SqlCommand("proVerTbVehiModeloCombustible", oConexion))
                    {
                        oCommand.CommandType = CommandType.StoredProcedure;

                        IDataReader reader = oCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            item = new tbVehiModelo();
                            item.vehiModeCombId = Convert.ToInt32(reader["vehiModeCombId"]);
                            item.vehiModeCombNombre = Convert.ToString(reader["vehiModeCombNombre"]);
                            item.vehiModeCombDescripcion = Convert.ToString(reader["vehiModeCombDescripcion"]);
                           
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
        public List<tbVehiModelo> VerTbVehiModeloAro()
        {
            List<tbVehiModelo> lista = new List<tbVehiModelo>();
            tbVehiModelo item;
            try
            {
                using (var oConexion = new SqlConnection(CadenaDeConexion()))
                {
                    oConexion.Open();
                    using (SqlCommand oCommand = new SqlCommand("proVerTbVehiModeloAro", oConexion))
                    {
                        oCommand.CommandType = CommandType.StoredProcedure;

                        IDataReader reader = oCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            item = new tbVehiModelo();
                            item.vehiModeAroId = Convert.ToInt32(reader["vehiModeAroId"]);
                            item.vehiModeAroNombre = Convert.ToString(reader["vehiModeAroNombre"]);
                            item.vehiModeAroDescripcion = Convert.ToString(reader["vehiModeAroDescripcion"]);
                            
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
        public List<tbVehiModelo> VerTbVehiModeloRodaje()
        {
            List<tbVehiModelo> lista = new List<tbVehiModelo>();
            tbVehiModelo item;
            try
            {
                using (var oConexion = new SqlConnection(CadenaDeConexion()))
                {
                    oConexion.Open();
                    using (SqlCommand oCommand = new SqlCommand("proVerTbVehiModeloRodaje", oConexion))
                    {
                        oCommand.CommandType = CommandType.StoredProcedure;

                        IDataReader reader = oCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            item = new tbVehiModelo();
                            item.vehiModeRodaId = Convert.ToInt32(reader["vehiModeRodaId"]);
                            item.vehiModeRodaNombre = Convert.ToString(reader["vehiModeRodaNombre"]);
                            item.vehiModeRodaDescripcion = Convert.ToString(reader["vehiModeRodaDescripcion"]);

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

        public List<tbVehiModelo> VerTbVehiModeloTodo()
        {
            List<tbVehiModelo> lista = new List<tbVehiModelo>();
            tbVehiModelo item;
            try
            {
                using (var oConexion = new SqlConnection(CadenaDeConexion()))
                {
                    oConexion.Open();
                    using (SqlCommand oCommand = new SqlCommand("proVerTbVehiModeloTodo", oConexion))
                    {
                        oCommand.CommandType = CommandType.StoredProcedure;

                        IDataReader reader = oCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            item = new tbVehiModelo();
                            item.vehiModeId = Convert.ToInt32(reader["vehiModeId"]);
                            item.vehiMarId = Convert.ToInt32(reader["vehiMarId"]);
                            item.vehiCateId = Convert.ToInt32(reader["vehiCateId"]);
                            item.vehiModeNombre = Convert.ToString(reader["vehiModeNombre"]);
                            item.vehiModeDescripcion = Convert.ToString(reader["vehiModeDescripcion"]);
                            item.vehiModeCombustible = Convert.ToString(reader["vehiModeCombustible"]);
                            item.vehiModeRodaje = Convert.ToString(reader["vehiModeRodaje"]);
                            item.vehiModeAro = Convert.ToString(reader["vehiModeAro"]);
                            item.vehiModeAnio = Convert.ToString(reader["vehiModeAnio"]);
                            item.vehiModeEstado = Convert.ToInt32(reader["vehiModeEstado"]);

                            // [], [], [], [], [], [], [], [], [], [vehiModeImagen], []

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
