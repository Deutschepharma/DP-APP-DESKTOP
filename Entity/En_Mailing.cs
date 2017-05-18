using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class En_Mailing
    {
        public string para { get; set; }
        public string to { get; set; }
        public string subjet { get; set; }
        public string cuerpo { get; set; }
        public string ruta { get; set; }
        public string response { get; set; }
        public string clave { get; set; }
        public string smtpCuenta { get; set; }
        public int pto { get; set; }
        public bool ssl { get; set; }
        public string usuario { get; set; }
    }
}
