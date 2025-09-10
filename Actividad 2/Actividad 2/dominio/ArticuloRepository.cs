using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Actividad_2.Dominio
{
    public class ArticuloRepository
    {
        private readonly string connectionString =
            @"Server=.\SQLEXPRESS;Database=CATALOGO_P3_DB;Integrated Security=True";

        public List<Articulo> Listar()
        {
            var lista = new List<Articulo>();

            using (var conexion = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(
                "SELECT Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio FROM Articulos", conexion))
            {
                conexion.Open();
                using (var lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        var art = new Articulo
                        {
                            Id = lector.GetInt32(0),
                            Codigo = lector.GetString(1),
                            Nombre = lector.GetString(2),
                            Descripcion = lector.GetString(3),
                            IdMarca = lector.GetInt32(4),
                            IdCategoria = lector.GetInt32(5),
                            Precio = (float)lector.GetDecimal(6)
                        };
                        lista.Add(art);
                    }
                }
            }

            return lista;
        }
        public void Actualizar(Articulo a)
        {
            using (var cn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand(
                @"UPDATE Articulos
                  SET Codigo = @Codigo,
                      Nombre = @Nombre,
                      Descripcion = @Descripcion,
                      IdMarca = @IdMarca,
                      IdCategoria = @IdCategoria,
                      Precio = @Precio
                  WHERE Id = @Id", cn))
            {
                cmd.Parameters.AddWithValue("@Codigo", a.Codigo ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Nombre", a.Nombre ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Descripcion", a.Descripcion ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@IdMarca", a.IdMarca);
                cmd.Parameters.AddWithValue("@IdCategoria", a.IdCategoria);
                cmd.Parameters.AddWithValue("@Precio", a.Precio); // float en C#
                cmd.Parameters.AddWithValue("@Id", a.Id);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (var cn = new SqlConnection(connectionString))
            {
                cn.Open();
                using (var tx = cn.BeginTransaction())
                {
                    try
                    {
                        // 1) borro imágenes (si existen)
                        using (var cmdImg = new SqlCommand(
                            "DELETE FROM Imagenes WHERE IdArticulo = @id", cn, tx))
                        {
                            cmdImg.Parameters.AddWithValue("@id", id);
                            cmdImg.ExecuteNonQuery();
                        }

                        // 2) borro artículo
                        using (var cmdArt = new SqlCommand(
                            "DELETE FROM Articulos WHERE Id = @id", cn, tx))
                        {
                            cmdArt.Parameters.AddWithValue("@id", id);
                            int rows = cmdArt.ExecuteNonQuery();
                            if (rows == 0)
                                throw new InvalidOperationException("El artículo no existe o ya fue eliminado.");
                        }

                        tx.Commit();
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}