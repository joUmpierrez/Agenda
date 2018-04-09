using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace DAL
{
    public class ContactoService
    {
        // Guarda un Contacto en la Base de Datos
        public void Guardar(Contacto contacto)
        {

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
