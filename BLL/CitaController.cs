using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using DAL;

namespace BLL
{
    public class CitaController
    {
        #region Singleton
        private static CitaController instance;
        public static CitaController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CitaController();
                }
                return instance;
            }
        }
        #endregion

        CitaService citaController = CitaService.Instance;
        public static Contacto Contacto { get; set; }

        // Selecciona un Contacto
        public void SeleccionarContacto(Contacto contacto)
        {

        }

    }
}
