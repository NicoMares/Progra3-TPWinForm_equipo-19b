using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Actividad_2.Dominio
{
    public class ConexionSql
    {
        private readonly SqlConnection conexion = new SqlConnection();
        private readonly SqlCommand comando = new SqlCommand();
        private SqlDataReader lector;

        private bool cartelMostrado = false; 

        public SqlDataReader Lector => lector;

        public ConexionSql()
        {
            //conexion = new SqlConnection(@"Server=.\\SQLEXPRESS22;Database=CATALOGO_P3_DB;Integrated Security=True"); // NICO
            conexion.ConnectionString = @"Server=.\\SQLEXPRESS;Database=CATALOGO_P3_DB;Integrated Security=True"; // RESTO

            conexion.StateChange += (s, e) =>
            {
                if (!cartelMostrado && e.CurrentState == ConnectionState.Open)
                {
                    MessageBox.Show("Conexión establecida con la base de datos");
                    cartelMostrado = true;
                }
            };
        }

        public void Consulta(string consulta)
        {
            comando.CommandType = CommandType.Text;
            comando.CommandText = consulta;
        }

        public void Ejecutar()
        {
            comando.Connection = conexion;
            try
            {
                if (conexion.State != ConnectionState.Open)
                    conexion.Open(); 

                lector = comando.ExecuteReader();
            }
            catch (Exception) { throw; }
        }

        public void EjecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                if (conexion.State != ConnectionState.Open)
                    conexion.Open();

                comando.ExecuteNonQuery(); 
            }
            catch (Exception) { throw; }
        }

        public void cerrarConexion()
        {
            try
            {
                lector?.Close();
                conexion.Close();
            }
            catch { throw; }
            finally
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                    conexion.Close();
            }
        }

        public void SetParametros(string nombre, object valor)
        {
            if (!comando.Parameters.Contains(nombre))
                comando.Parameters.AddWithValue(nombre, valor);
            else
                comando.Parameters[nombre].Value = valor;
        }
    }
}
