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

        }


        // Borra una Agenda
        public void Borrar(Agenda agenda)
        {

        }


        // Muestra Todas las Agendas
        //public List<Agenda> Mostrar()


        // Busca una Agenda
        //public Agenda Buscar(String nombre)


    }
}
