using System.Collections.Generic;
using System.Data.SqlClient;

namespace Actividad_2.Dominio
{
    public class MarcaRepository
    {
        private readonly string cs = @"Server=.\SQLEXPRESS;Database=CATALOGO_P3_DB;Integrated Security=True";

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
    }

}
