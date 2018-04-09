using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using System.Data.SqlClient;

namespace DAL
{
    public class TelefonosService
    {
        public static readonly String cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = MegaAgenda; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // Guarda un Telefono para un Contacto en la Base de Datos
        public void Guardar(Telefonos telefono)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                const String query = "INSERT INTO Telefonos (contacto, tipoTelefono, telefono, activo) VALUES (@contacto, @tipoTelefono, @telefono, @activo)";
                connection.Open();
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@contacto", telefono.Contacto.Nombre);
                comando.Parameters.AddWithValue("@tipoTelefono", telefono.TipoTelefono);
                comando.Parameters.AddWithValue("@telefono", telefono.Telefono);
                comando.Parameters.AddWithValue("@activo", true);
            }
        }

        // Modifica el Telefono de un Contacto en la Base de Datos
        public void Modificar(String tipoTelefono, String telefono)
        {

        }

        // Elimina el Telefono de un Contacto de la Base de Datos
        public void Borrar(Telefonos telefono)
        {

        }
    }
}
