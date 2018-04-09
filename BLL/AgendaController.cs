using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using DAL;

namespace BLL
{
    public class AgendaController
    {
        #region Singleton
        private static AgendaController instance;
        public static AgendaController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AgendaController();
                }
                return instance;
            }
        }
        #endregion

        AgendaService agendaService = AgendaService.Instance;
        ContactoService contactoService = ContactoService.Instance;

        // Crear una Agenda
        public void Crear(Agenda agenda)
        {
            agendaService.Guardar(agenda);
        }

        // Borra una Agenda
        public void Borrar(Agenda agenda)
        {
            List<Contacto> contactos = contactoService.MostrarContactos(agenda);

            foreach (Contacto contacto in contactos)
            {
                contactoService.Borrar(contacto);
            }
            agendaService.Borrar(agenda);
        }

        // Muestra Todas las Agendas
        public List<Agenda> Mostrar()
        {
            List<Agenda> agendasMostrar = agendaService.MostrarAgendas();
            return agendasMostrar;
        }

        // Busca una Agenda
        public Agenda Buscar(String nombre)
        {
            Agenda agenda = agendaService.BuscarAgenda(nombre);
            return agenda;
        }

        // Selecciona una Agenda
        public String Seleccionar(Agenda agenda)
        {
            return agenda.Nombre;
        }
    }
}
