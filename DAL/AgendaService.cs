using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using System.Data.SqlClient;

namespace DAL
{
    public class AgendaService
    {
        #region Singleton
        private static AgendaService instance;
        public static AgendaService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AgendaService();
                }
                return instance;
            }
        }
        #endregion

        public static readonly String cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BaseDeDatos-Agenda;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // Guarda una Agenda en la Base de Datos
        public void Guardar(Agenda agenda)
        {

        }

        // Borrado Logico de una Agenda
        public void Borrar(Agenda agenda)
        {

        }

        // Muestra todas las Agendas de la Base de Datos
        //public List<Agenda> MostrarAgendas()


        // Busca una Agenda en la Base de Datos
        //public Agenda BuscarAgenda(String nombre)

    }
}
