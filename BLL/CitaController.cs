using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using DAL;

namespace BLL
{
    public class CitaController
    {
        public static String Contacto { get; set; }

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
    }
}
