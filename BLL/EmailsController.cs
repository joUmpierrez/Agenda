using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using DAL;

namespace BLL
{
    public class EmailsController
    {
        public Contacto Contacto { get; set; }

        private static EmailsController instance;
        public static EmailsController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmailsController();
                }
                return instance;
            }
        }

        // Crea un Mail para un Contacto
        public void Crear(Emails email)
        {

        }

        // Modifica el Mail de un Contacto
        public void Modificar(String email, Contacto contacto)
        {

        }

        // Elimina el Mail de un Contacto
        public void Borrar(Emails email)
        {

        }

        // Muestra los email de un Contacto
        public List<Emails> Mostrar(Contacto contacto)
        {
            List<Emails> emails = new List<Emails>();

            return emails;
        }
    }
}
