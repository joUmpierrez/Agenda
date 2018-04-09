using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using System.Data.SqlClient;

namespace DAL
{
    public class ContactoService
    {
        public static readonly String cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = MegaAgenda; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

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

        // Modifica un Contacto en la Base de Datos
        public void Modificar (DateTime fecNac, String pais)
        {

        }

        // Borrado Logico de una Agenda
        public void Borrar (Contacto contacto)
        {

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
