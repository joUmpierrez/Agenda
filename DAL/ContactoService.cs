using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using System.Data.SqlClient;

namespace DAL
{
    public class ContactoService
    {
        #region Singleton
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
        #endregion

        public static readonly String cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BaseDeDatos-Agenda;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // Guarda un Contacto en la Base de Datos
        public void Guardar(Contacto contacto)
        {
            
        }

        // Modifica la Fecha de Nacimiento de un Contacto en la Base de Datos
        public void ModificarecNac (DateTime fecNac, Agenda agenda)
        {
           
        }

        // Modifica el Pais de un Contacto en la Base de Datos
        public void ModificarPais (String pais, Agenda agenda)
        {
           
        }

        // Borrado Logico de una Agenda
        public void Borrar (Contacto contacto)
        {
           
        }

        // Muestra todos los Contactos vinculados a la Agenda en la Base de Datos
        //public List<Contacto> MostrarContactos(Agenda agenda)


        // Busca un contacto con dicho mail (o parecido) vinculado a una Agenda
        //public List<Contacto> BuscarContacto(String nombre, Agenda agenda)


        // Busca todos los contactos de un pais en la agenda
        //public List<Contacto> MostrarContactoPais(String pais, Agenda agenda)

    }
}
