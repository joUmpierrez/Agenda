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
        CitaService citaService = CitaService.Instance;
        AgendaController agendaController = AgendaController.Instance;
        public static Agenda Agenda { get; set; }

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
        //public List<Contacto> Mostrar(Agenda agenda)


        // Busca Contactos
        //public List<Contacto> Buscar(String nombre, Agenda agenda)


        // Busca Contactos segun su Pais
        //public List<Contacto> BuscarPorPais(String pais, Agenda agenda)


        // Selecciona un Agenda
        public void SeleccionarAgenda(Agenda agenda)
        {

        }

    }
}
