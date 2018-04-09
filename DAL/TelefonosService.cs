using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using System.Data.SqlClient;

namespace DAL
{
    public class TelefonosService
    {
        public static readonly String cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""Base de Datos - Agenda"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private static TelefonosService instance;
        public static TelefonosService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TelefonosService();
                }
                return instance;
            }
        }

        // Guarda un Telefono para un Contacto en la Base de Datos
        public void Guardar(Telefonos telefono)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                const String query = "INSERT INTO Telefonos (contacto, tipoTelefono, telefono, activo) VALUES (@contacto, @tipoTelefono, @telefono, @activo)";
                connection.Open();
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@contacto", telefono.Contacto);
                comando.Parameters.AddWithValue("@tipoTelefono", telefono.TipoTelefono);
                comando.Parameters.AddWithValue("@telefono", telefono.Telefono);
                comando.Parameters.AddWithValue("@activo", true);
            }
        }

        // Modifica el Tipo de Telefono de un Contacto
        public void ModificarTipo(String tipoTelefono, Contacto contacto)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                const String query = "UPDATE Telefonos SET tipoTelefono = @tipoTelefono WHERE contacto = @contacto";
                connection.Open();
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@contacto", contacto.Nombre);
                comando.Parameters.AddWithValue("@tipoTelefono", tipoTelefono);
            }
        }

        // Modifica el Telefono de un Contacto
        public void ModificarTelefono(String telefono, Contacto contacto)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                const String query = "UPDATE Telefonos SET telefono = @telefono WHERE contacto = @contacto";
                connection.Open();
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@contacto", contacto.Nombre);
                comando.Parameters.AddWithValue("@telefono", telefono);
            }
        }

        // Elimina el Telefono de un Contacto de la Base de Datos
        public void Borrar(Telefonos telefono)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                const String query = "UPDATE Telefonos SET activo = @activo WHERE contacto = @contacto";
                connection.Open();
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@contacto", telefono.Contacto);
                comando.Parameters.AddWithValue("@activo", false);
            }
        }

        // Muestra los telefonos de un Contacto
        public List<Telefonos> Mostrar(Contacto contacto)
        {
            List<Telefonos> telefonos = new List<Telefonos>();

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                const String query = "SELECT (contacto, tipoTelefono, telefono) FROM Telefonos WHERE contacto = @contacto AND activo = @activo";
                connection.Open();
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@contacto", contacto.Nombre);
                comando.Parameters.AddWithValue("@activo", true);
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    int posContacto = reader.GetOrdinal("contacto");
                    int posTipoTelefono = reader.GetOrdinal("tipoTelefono");
                    int posTelefono = reader.GetOrdinal("telefono");
                    while (reader.Read())
                    {
                        Telefonos telefono = new Telefonos();
                        telefono.Contacto = reader.GetString(posContacto);
                        telefono.TipoTelefono = reader.GetString(posTipoTelefono);
                        telefono.Telefono = reader.GetString(posTelefono);

                        telefonos.Add(telefono);
                    }
                }
            }

            return telefonos;
        }
    }
}
