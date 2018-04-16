using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Cita
    {
        public DateTime fecha { get; set; }
        public DateTime horaInicio { get; set; }
        public DateTime horaFinal { get; set; }
        public List<Contacto> contactos { get; set; }
        public Boolean Activo { get; set; }
    }
}
