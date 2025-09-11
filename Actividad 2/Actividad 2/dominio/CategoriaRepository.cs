using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Actividad_2.Dominio
{
   
    public class CategoriaRepository
    {
        private readonly string cs = @"Server=.\SQLEXPRESS;Database=CATALOGO_P3_DB;Integrated Security=True";
        
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public List<Categoria> Listar()
        {
            var list = new List<Categoria>();
            using (var cn = new SqlConnection(cs))
            using (var cmd = new SqlCommand("SELECT Id, Descripcion FROM Categorias ORDER BY Descripcion", cn))
            {
                cn.Open();
                using (var rd = cmd.ExecuteReader())
                    while (rd.Read())
                        list.Add(new Categoria { Id = rd.GetInt32(0), Descripcion = rd.GetString(1) });
            }
            return list;
        }

        public void agregarCategoria(Categoria nuevo)
        {
            conexion = new SqlConnection(cs);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = ("insert into CATEGORIAS(Descripcion)values(@Descripcion)");
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
    }
}
