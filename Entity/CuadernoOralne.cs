using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CuadernoOralne
    {
        public string NRO_CUADERNO { get; set; }
        public string CLIENTE_NOMBRE { get; set; }
        public string CLIENTE_PATERNO { get; set; }
        public string CLIENTE_MATERNO { get; set; }
        public DateTime CLIENTE_NACIMIENTO { get; set; }
        public string CLIENTE_DIRECCION { get; set; }
        public string CLIENTE_EMAIL { get; set; }
        public string CLIENTE_FONO { get; set; }
        public char CLIENTE_AUTORIZA_CONTACTO { get; set; }
        public int RECETA_NRO_BOLETA { get; set; }
        public DateTime RECETA_FECHA_COMPRA { get; set; }
        public string RECETA_FUNCIONARIO { get; set; }
        public string RECETA_OBSERVACION { get; set; }
        public string PRESCRIPTOR_MEDICO { get; set; }
        public string PRESCRIPTOR_CENTRO_MEDICO { get; set; }
        public string PRESCRIPTOR_FARMACIA { get; set; }
    }
}
