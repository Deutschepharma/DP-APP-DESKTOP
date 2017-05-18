using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class En_Cliente_Correo
    {
        public int rut { get; set; }
        public char dv { get; set; }
        public string nombres { get; set; }
        public DateTime nacimiento { get; set; }
        public string email { get; set; }
        public int usuario { get; set; }
        public char estado { get; set; }
    }
}
