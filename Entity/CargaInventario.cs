using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CargaInventario
    {
        public string bodega { get; set; }
        public int codigo { get; set; }
        public string descripcion { get; set; }
        public string lote { get; set; }
        public DateTime vencimiento { get; set; }
        public float unidades { get; set; }

    }
}
