using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using DAL;

namespace BLL
{
    public class TelefonosController
    {
        #region Singelton
        private static TelefonosController instance;
        public static TelefonosController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TelefonosController();
                }
                return instance;
            }
        }
        #endregion

        TelefonosService telefonosService = TelefonosService.Instance;
        public Contacto Contacto { get; set; }

        // Crea un Telefono para un Contacto
        public void Crear(Telefonos telefono)
        {
            telefonosService.Guardar(telefono);
        }

        // Modifica el Telefono de un Contacto en la Base de Datos
        public void Modificar(String tipoTelefono, String telefono, Contacto contacto)
        {
            if (tipoTelefono != null && telefono != null)
            {
                telefonosService.ModificarTipo(tipoTelefono, contacto);
                telefonosService.ModificarTelefono(telefono, contacto);
            }
            else
            {
                if (tipoTelefono != null)
                {
                    telefonosService.ModificarTipo(tipoTelefono, contacto);
                }

                if (telefono != null)
                {
                    telefonosService.ModificarTelefono(telefono, contacto);
                }
            }
            
        }

        // Elimina el Telefono de un Contacto
        public void Borrar(Telefonos telefono)
        {
            telefonosService.Borrar(telefono);
        }

        // Muestra los telefonos de un Contacto
        public List<Telefonos> Mostrar(Contacto contacto)
        {
            List<Telefonos> telefonos = new List<Telefonos>();

            return telefonos;
        }

        // Selecciona un Contacto
        public void SeleccionarContacto(Contacto contacto)
        {
            Contacto = contacto;
        }
    }
}
