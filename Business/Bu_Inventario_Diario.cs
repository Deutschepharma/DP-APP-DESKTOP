using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using Entity;

namespace Business
{
    public class Bu_Inventario_Diario
    {
        public int RegistraInventario(En_CargaMatVta mv)
        {
            return new Co_Inventario_Diario().RegistraInventario(mv);
        }
        public int RegistraMatEnv(En_CargaMatEnv me)
        {
            return new Co_Inventario_Diario().RegistraMatEnv(me);
        }
    }
}
