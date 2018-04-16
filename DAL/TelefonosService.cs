using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using System.Data.SqlClient;

namespace DAL
{
    public class TelefonosService
    {
        #region Singleton
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
        #endregion

        public static readonly String cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BaseDeDatos-Agenda;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // Guarda un Telefono para un Contacto en la Base de Datos
        public void Guardar(Telefonos telefono)
        {
           
        }

        // Modifica el Tipo de Telefono de un Contacto
        public void ModificarTipo(String tipoTelefono, Contacto contacto)
        {
            
        }

        // Modifica el Telefono de un Contacto
        public void ModificarTelefono(String telefono, Contacto contacto)
        {
            
        }

        // Elimina el Telefono de un Contacto de la Base de Datos
        public void Borrar(Telefonos telefono)
        {
           
        }

        // Muestra los telefonos de un Contacto
        //public List<Telefonos> Mostrar(Contacto contacto)

    }
}
