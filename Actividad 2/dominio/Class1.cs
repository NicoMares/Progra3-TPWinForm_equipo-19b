using System.Collections.Generic;
using System.Data.SqlClient;

namespace dominio
{
    public class ArticuloRepository
    {
        private readonly string connectionString = @"Server=.\SQLEXPRESS;Database=DISCOS_DB;Integrated Security=True";

        public List<Articulo> Listar()
        {
            var lista = new List<Articulo>();
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio FROM ARTICULOS",
                    conexion);

                conexion.Open();
                SqlDataReader lector = cmd.ExecuteReader();

                while (lector.Read())
                {
                    Articulo art = new Articulo
                    {
                        Id = (int)lector["Id"],
                        Codigo = (string)lector["Codigo"],
                        Nombre = (string)lector["Nombre"],
                        Descripcion = (string)lector["Descripcion"],
                        IdMarca = (int)lector["IdMarca"],
                        IdCategoria = (int)lector["IdCategoria"],
                        Precio = (float)lector["Precio"]
                    };
                    lista.Add(art);
                }
            }
            return lista;
        }
    }
}
