using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using System.Data.SqlClient;

namespace DAL
{
    public class EmailsService
    {
        public static readonly String cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = MegaAgenda; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // Guarda un Telefono para un Contacto en la Base de Datos
        public void Crear(Emails email)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                const String query = "INSERT INTO Emails (contacto, email, activo) VALUES (@contacto, @email, @activo)";
                connection.Open();
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@contacto", email.Contacto.Nombre);
                comando.Parameters.AddWithValue("@email", email.Email);
                comando.Parameters.AddWithValue("@activo", true);
            }
        }

        // Modifica el Telefono de un Contacto en la Base de Datos
        public void Modificar(String email)
        {

        }

        // Elimina el Telefono de un Contacto de la Base de Datos
        public void Borrar(Emails email)
        {

        }
    }
}
