using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Telefonos
    {
        public String TipoTelefono { get; set; }
        public String Telefono { get; set; }
        public Contacto Contacto { get; set; }
        public Boolean Activo { get; set; }
    }
}
