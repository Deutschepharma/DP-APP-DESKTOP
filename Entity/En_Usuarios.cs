using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class En_Usuarios
    {
        public int id { get; set; }
        public string us { get; set; }
        public string pw { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int tipo_us { get; set; }
        public char estado_usuario_id { get; set; }
        public string estado_usuario_descripcion { get; set; }
    }
}
