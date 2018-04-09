using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using DAL;

namespace BLL
{
    public class AgendaController
    {
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

        // Crear una Agenda
        public void Crear(Agenda agenda)
        {

        }

        // Borra una Agenda
        public void Borrar(Agenda agenda)
        {

        }

        // Muestra Todas las Agendas
        public List<Agenda> Mostrar(List<Agenda> agendas)
        {
            List<Agenda> agendasMostrar = new List<Agenda>();

            return agendasMostrar;
        }

        // Busca una Agenda
        public Agenda Buscar(String nombre)
        {
            Agenda agenda;

            return agenda;
        }

        // Selecciona una Agenda
        public String Seleccionar(Agenda agenda)
        {
            String agendaDevolver = agenda.Nombre;

            return agendaDevolver;
        }
    }
}
