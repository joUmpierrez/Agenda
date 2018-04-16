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

        public static readonly String cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BaseDeDatos-Agenda;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // Guarda un Telefono para un Contacto en la Base de Datos
        public void Crear(Emails email)
        {
            
        }

        // Modifica el Email de un Contacto en la Base de Datos
        public void ModificarEmail(String email, Contacto contacto)
        {
          
        }

        // Elimina el Telefono de un Contacto de la Base de Datos
        public void Borrar(Emails email)
        {
           
        }

        // Muestra los email de un Contacto
        //public List<Emails> Mostrar(Contacto contacto)

    }
}
