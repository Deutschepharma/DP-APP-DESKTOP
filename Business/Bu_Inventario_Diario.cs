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
        public int RegistraInventario(CargaInventario c)
        {
            return new Co_Inventario_Diario().RegistraInventario(c);
        }
        public int RegistraMatEnv(CargaInventario c)
        {
            return new Co_Inventario_Diario().RegistraMatEnv(c);
        }
    }
}
