using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2.Dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public float Precio { get; set; }

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {

            List<Articulo> lista = new List<Articulo>();

            ConexionSql datos = new ConexionSql();

            try
            {
                string consulta = "SELECT a.Id, a.Codigo, a.Nombre, a.Descripcion,a.IdMarca, m.Descripcion AS MarcaDescripcion,a.IdCategoria, c.Descripcion AS CategoriaDescripcion,a.Precio FROM Articulos a JOIN Marcas m ON m.Id = a.IdMarca JOIN Categorias c ON c.Id = a.IdCategoria";
                switch (campo)
                {
                    case "Codigo":
                        break;

                    case "Precio":

                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += "Precio > " + filtro;

                                break;
                            case "Menor a":

                                consulta += "Precio < " + filtro;


                                break;
                            case "Igual a":

                                consulta += "Precio = " + filtro;

                                break;
                            default:
                                break;
                        }

                        break;

                    case "Nombre":

                    case "Contiene":
                        consulta += "Nombre like '%" + filtro + "%'";

                        break;
                    case "Comienza con":

                        consulta += "Nombre like '" + filtro + " % '";


                        break;
                    case "Termina con ":

                        consulta += "Nombre like '%" + filtro + " '";

                        break;
                    default:
                        break;


                }
                datos.Consulta(consulta);
                datos.Ejecutar();

                while (datos.Lector.Read())
                {
                    var art = new Articulo
                    {
                        Id = datos.Lector.GetInt32(0),
                        Codigo = datos.Lector.GetString(1),
                        Nombre = datos.Lector.GetString(2),
                        Descripcion = datos.Lector.GetString(3),
                        Marca = new Marca
                        {
                            Id = datos.Lector.GetInt32(4),
                            Descripcion = datos.Lector.GetString(5)
                        },

                        Categoria = new Categoria
                        {
                            Id = datos.Lector.GetInt32(6),
                            Descripcion = datos.Lector.GetString(7)
                        },
                        Precio = (float)datos.Lector.GetDecimal(8)
                    };
                    lista.Add(art);
                }


                return lista;
            }


            catch (Exception ex)
            {

                throw ex;
            }
      
        
        finally
        {   datos.Lector.Close();
            }


    }
}
  }