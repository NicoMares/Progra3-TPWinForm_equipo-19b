using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Actividad_2.Dominio
{
    public class MarcaRepository
    {
        private readonly string cs = @"Server=.\SQLEXPRESS;Database=CATALOGO_P3_DB;Integrated Security=True";

        private SqlConnection conexion;
        private SqlCommand comando;

        public List<Marca> Listar()
        {
            var list = new List<Marca>();
            using (var cn = new SqlConnection(cs))
            using (var cmd = new SqlCommand("SELECT Id, Descripcion FROM Marcas ORDER BY Descripcion", cn))
            {
                cn.Open();
                using (var rd = cmd.ExecuteReader())
                    while (rd.Read())
                        list.Add(new Marca { Id = rd.GetInt32(0), Descripcion = rd.GetString(1) });
            }
            return list;
        }

        public void agregarMarca(Marca nuevo)
        {
            conexion = new SqlConnection(cs);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = ("insert into MARCAS(Descripcion)values(@Descripcion)");
            comando.Parameters.AddWithValue("@Descripcion", nuevo.Descripcion);
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }

        }



        public void modificar(Marca marca)
        {
            conexion = new SqlConnection(cs);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = ("UPDATE MARCAS SET Descripcion = @descripcion where id = @id");
            comando.Parameters.AddWithValue("@Descripcion", marca.Descripcion);
            comando.Parameters.AddWithValue("@id", marca.Id);
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void Eliminar(int id)
        {
            conexion = new SqlConnection(cs);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = ("DELETE FROM MARCAS WHERE id = @id");
            comando.Parameters.AddWithValue("@id", id);
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
    }

}
