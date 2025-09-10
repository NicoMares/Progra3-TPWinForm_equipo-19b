using System.Collections.Generic;
using System.Data.SqlClient;

namespace Actividad_2.Dominio
{
   
    public class CategoriaRepository
    {
        private readonly string cs = @"Server=.\SQLEXPRESS;Database=CATALOGO_P3_DB;Integrated Security=True";

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
    }
}
