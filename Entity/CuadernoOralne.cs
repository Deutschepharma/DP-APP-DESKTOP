using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CuadernoOralne
    {
        public int tipo_evento { get; set; }
        public int cliente_rut { get; set; }
        public int maquina_id { get; set; }
        public string detalle_eventos { get; set; }
        public int id_user { get; set; }
        public int canEventos { get; set; }
        public string maquina { get; set; }

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
    }
}
