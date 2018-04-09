using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using DAL;

namespace BLL
{
    public class ContactoController
    {
        public static Agenda Agenda { get; set; }

        private static ContactoController instance;
        public static ContactoController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ContactoController();
                }
                return instance;
            }
        }

        // Crea un Contacto
        public void Crear(Contacto contacto)
        {

        }

        // Modifica un Contacto
        public void Modificar(DateTime fecNac, String pais, Agenda agenda)
        {

        }

        // Borra un Contacto
        public void Borrar (Contacto contacto)
        {

        }

        // Muestra todos los Contanctos de una Agenda
        public List<Contacto> Mostrar(Agenda agenda)
        {
            List<Contacto> contactos = new List<Contacto>();

            return contactos;
        }

        // Busca Contactos
        public List<Contacto> Buscar(String nombre, Agenda agenda)
        {
            List<Contacto> contactos = new List<Contacto>();

            return contactos;
        }

        // Busca Contactos segun su Pais
        public List<Contacto> BuscarPorPais(String pais, Agenda agenda)
        {
            List<Contacto> contactos = new List<Contacto>();

            return contactos;
        }
    }
}
