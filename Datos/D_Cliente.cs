using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class D_Cliente
    {
        private readonly string connectionString = "Data Source=RADELIN-PC;Initial Catalog=Inicio_de_Sesion;Persist Security Info=True;User ID=sa;Password=12345678;";

        public string Guardar_Cliente(int estadoGuardado, E_Cliente cliente)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_GuardarCliente2", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NombreCompleto", cliente.NombreCompleto);
                        cmd.Parameters.AddWithValue("@Correo", cliente.Correo);
                        cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                        cmd.Parameters.AddWithValue("@Direccion", cliente.Direcccion);
      

                        cmd.ExecuteNonQuery();
                    }
                }
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message; // Devuelve el mensaje de error
            }
        }

        public DataTable ListarCliente()
        {
            DataTable dataTable = new DataTable(); // Crear un DataTable para almacenar los usuarios

            try
            {
                // Crear una nueva conexión utilizando la cadena de conexión
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Abrir la conexión
                    connection.Open();

                    // Definir la consulta SQL para obtener los usuarios
                    string query = "SELECT * FROM Cliente"; // Reemplaza 'Usuarios' con el nombre de tu tabla de usuarios

                    // Crear un SqlDataAdapter para ejecutar la consulta y llenar el DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    // Llenar el DataTable con los resultados de la consulta
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra y lanzarla nuevamente
                throw new Exception("Error al listar el cliente: " + ex.Message);
            }

            // Devolver el DataTable con los usuarios
            return dataTable;
        }


        public bool EliminarCliente(int IdCliente)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Cliente WHERE IdCliente = @IdCliente";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdCliente", IdCliente);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el cliente: " + ex.Message);
            }
        }


    }
}
