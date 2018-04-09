using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Contacto
    {
        public String Nombre { get; set; }
        public DateTime FecNac { get; set; }
        public String Pais { get; set; }
        public String Agenda { get; set; }
        public Boolean Activo { get; set; }
    }
}
