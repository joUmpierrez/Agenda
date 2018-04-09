using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using System.Data.SqlClient;

namespace DAL
{
    public class EmailsService
    {
        #region Singleton
        private static EmailsService instance;
        public static EmailsService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmailsService();
                }
                return instance;
            }
        }
        #endregion

        public static readonly String cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""Base de Datos - Agenda"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // Guarda un Telefono para un Contacto en la Base de Datos
        public void Crear(Emails email)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                const String query = "INSERT INTO Emails (contacto, email, activo) VALUES (@contacto, @email, @activo)";
                connection.Open();
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@contacto", email.Contacto);
                comando.Parameters.AddWithValue("@email", email.Email);
                comando.Parameters.AddWithValue("@activo", true);
            }
        }

        // Modifica el Email de un Contacto en la Base de Datos
        public void ModificarEmail(String email, Contacto contacto)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                const String query = "UPDATE Emails SET email = @email WHERE contacto = @contacto";
                connection.Open();
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@contacto", contacto.Nombre);
                comando.Parameters.AddWithValue("@email", email);
            }
        }

        // Elimina el Telefono de un Contacto de la Base de Datos
        public void Borrar(Emails email)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                const String query = "UPDATE Emails SET activo = @activo WHERE contacto = @contacto";
                connection.Open();
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@contacto", email.Contacto);
                comando.Parameters.AddWithValue("@activo", false);
            }
        }

        // Muestra los email de un Contacto
        public List<Emails> Mostrar(Contacto contacto)
        {
            List<Emails> emails = new List<Emails>();

            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                const String query = "SELECT (contacto, email) FROM Emails WHERE contacto = @contacto AND activo = @activo";
                connection.Open();
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@contacto", contacto.Nombre);
                comando.Parameters.AddWithValue("@activo", true);
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    int posContacto = reader.GetOrdinal("contacto");
                    int posEmail = reader.GetOrdinal("email");
                    while (reader.Read())
                    {
                        Emails email = new Emails();
                        email.Contacto = reader.GetString(posContacto);
                        email.Email = reader.GetString(posEmail);

                        emails.Add(email);
                    }
                }
            }

            return emails;
        }
    }
}
