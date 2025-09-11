using System.Collections.Generic;
using System.Data.SqlClient;

namespace Actividad_2.Dominio
{
    public class ImagenRepository
    {
        // tu misma connection string
        private const string CS = @"Server=.\SQLEXPRESS;Database=CATALOGO_P3_DB;Integrated Security=True";

        public List<Imagen> ListarPorArticulo(int idArticulo)
        {
            var list = new List<Imagen>();
            using (var cn = new SqlConnection(CS))
            using (var cmd = new SqlCommand("SELECT Id, IdArticulo, ImagenURL FROM IMAGENES WHERE IdArticulo=@id", cn))
            {
                cmd.Parameters.AddWithValue("@id", idArticulo);
                cn.Open();
                using (var rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        list.Add(new Imagen
                        {
                            Id = rd.GetInt32(0),
                            IdArticulo = rd.GetInt32(1),
                            ImagenURL = rd.GetString(2)
                        });
                    }
                }
            }
            return list;
        }
    }
}
