﻿using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using System.Data.SqlClient;

namespace DAL
{
    public class AgendaService
    {
        public static readonly String cadenaConexion = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""Base de Datos - Agenda"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

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

        // Guarda una Agenda en la Base de Datos
        public void Guardar(Agenda agenda)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                const String query = "INSERT INTO Agendas (nombre, fechaCreacion, activo) VALUES (@nombre, @fechaCreacion, @activo)";
                connection.Open();
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@nombre", agenda.Nombre);
                comando.Parameters.AddWithValue("@fechaCreacion", agenda.FechaCreacion);
                comando.Parameters.AddWithValue("@activo", true);
            }
        }

        // Borrado Logico de una Agenda
        public void Borrar(Agenda agenda)
        {
            using (SqlConnection connection = new SqlConnection(cadenaConexion))
            {
                const String query = "UPDATE Agendas SET activo = @activo WHERE nombre = @nombre";
                connection.Open();
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@nombre", agenda.Nombre);
                comando.Parameters.AddWithValue("@activo", false);
            }
        }

        // Muestra todas las Agendas de la Base de Datos
        public List<Agenda> MostrarAgendas()
        {
            List<Agenda> agendas = new List<Agenda>();

            return agendas;
        }

        // Busca una Agenda en la Base de Datos
        public Agenda BuscarAgenda(String nombre)
        {
            Agenda agenda;

            return agenda;
        }
    }
}
