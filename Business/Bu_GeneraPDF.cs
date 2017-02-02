using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Controller;

namespace Business
{
    public class Bu_GeneraPDF
    {
      
        public bool GeneraCuaderno(En_ListasDatos l)
        {
            return new Co_GeneraPDF().GeneraCuaderno(l);
        }
    }
}
