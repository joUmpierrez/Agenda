using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using System.Data.SqlClient;

namespace DAL
{
    public class ContactoService
    {
        public static readonly String cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""Base de Datos - Agenda"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private static ContactoService instance;
        public static ContactoService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ContactoService();
                }
                return instance;
            }
        }

        // Guarda un Contacto en la Base de Datos
        public void Guardar(Contacto contacto)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                const String query = "INSERT INTO Contactos (nombre, fechaNacimiento, pais, agenda, activo) VALUES (@nombre, @fechaNacimiento, @pais, @agenda, @activo)";
                connection.Open();
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@nombre", contacto.Nombre);
                comando.Parameters.AddWithValue("@fechaNacimiento", contacto.FecNac);
                comando.Parameters.AddWithValue("@pais", contacto.Pais);
                comando.Parameters.AddWithValue("@agenda", contacto.Agenda.Nombre);
                comando.Parameters.AddWithValue("@activo", true);
            }
        }

        // Modifica la Fecha de Nacimiento de un Contacto en la Base de Datos
        public void ModificarecNac (DateTime fecNac, Agenda agenda)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                const String query = "UPDATE Contactos SET fecNac = @fecNac WHERE agenda = @agenda";
                connection.Open();
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@nombre", agenda.Nombre);
                comando.Parameters.AddWithValue("@fecNac", fecNac);
            }
        }

        // Modifica el Pais de un Contacto en la Base de Datos
        public void ModificarPais (String pais, Agenda agenda)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                const String query = "UPDATE Contactos SET pais = @pais WHERE agenda = @agenda";
                connection.Open();
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@nombre", agenda.Nombre);
                comando.Parameters.AddWithValue("@pais", pais);
            }
        }

        // Borrado Logico de una Agenda
        public void Borrar (Contacto contacto)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                const String query = "UPDATE Contactos SET activo = @activo WHERE nombre = @nombre";
                connection.Open();
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@nombre", contacto.Nombre);
                comando.Parameters.AddWithValue("@activo", false);
            }
        }

        // Muestra todos los Contactos vinculados a la Agenda en la Base de Datos
        public List<Contacto> MostrarContactos(Agenda agenda)
        {
            List<Contacto> contactos = new List<Contacto>();

            return contactos;
        }

        // Busca un contacto con dicho mail (o parecido) vinculado a una Agenda
        public List<Contacto> BuscarContacto(String nombre, Agenda agenda)
        {
            List<Contacto> contactos = new List<Contacto>();

            return contactos;
        }

        // Busca todos los contactos de un pais en la agenda
        public List<Contacto> MostrarContactoPais(String pais, Agenda agenda)
        {
            List<Contacto> contactos = new List<Contacto>();

            return contactos;
        }
    }
}
