using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using DAL;

namespace BLL
{
    public class ContactoController
    {
        #region Singleton
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
        #endregion

        ContactoService contactoService = ContactoService.Instance;
        EmailsService emailsService = EmailsService.Instance;
        TelefonosService telefonosService = TelefonosService.Instance;
        AgendaController agendaController = AgendaController.Instance;
        public static Agenda Agenda { get; set; }

        // Crea un Contacto
        public void Crear(Contacto contacto)
        {
            contacto.Agenda = Agenda.Nombre;
            contactoService.Guardar(contacto);
        }

        // Modifica un Contacto
        public void Modificar(DateTime fecNac, String pais, Agenda agenda)
        {
            if (fecNac != null && pais != null)
            {
                contactoService.ModificarecNac(fecNac, agenda);
                contactoService.ModificarPais(pais, agenda);
            }
            else
            {
                if(fecNac != null)
                {
                    contactoService.ModificarecNac(fecNac, agenda);
                }

                if (pais != null)
                {
                    contactoService.ModificarPais(pais, agenda);
                }
            }
        }

        // Borra un Contacto
        public void Borrar (Contacto contacto)
        {
            List<Telefonos> telefonos = telefonosService.Mostrar(contacto);
            List<Emails> emails = emailsService.Mostrar(contacto);

            foreach (Telefonos telefono in telefonos)
            {
                telefonosService.Borrar(telefono);
            }

            foreach (Emails email in emails)
            {
                emailsService.Borrar(email);
            }

            contactoService.Borrar(contacto);
        }

        // Muestra todos los Contanctos de una Agenda
        public List<Contacto> Mostrar(Agenda agenda)
        {
            List<Contacto> contactos = contactoService.MostrarContactos(agenda);
            return contactos;
        }

        // Busca Contactos
        public List<Contacto> Buscar(String nombre, Agenda agenda)
        {
            List<Contacto> contactos = contactoService.BuscarContacto(nombre, agenda);
            return contactos;
        }

        // Busca Contactos segun su Pais
        public List<Contacto> BuscarPorPais(String pais, Agenda agenda)
        {
            List<Contacto> contactos = contactoService.MostrarContactoPais(pais, agenda);
            return contactos;
        }

        // Selecciona un Agenda
        public void SeleccionarAgenda(Agenda agenda)
        {
            Agenda = agenda;
        }
    }
}
