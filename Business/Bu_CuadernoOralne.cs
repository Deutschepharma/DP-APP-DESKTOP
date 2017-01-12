using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using System.Data;
using Entity;

namespace Business
{
    public class Bu_CuadernoOralne
    {
        public DataTable CargaCombos(int flag, int ddlFlag)
        {
            return new Co_CuadernoOralne().CargarComboBox(flag, ddlFlag);
        }
        public int RegistraCuaderno(CuadernoOralne c)
        {
            return new Co_CuadernoOralne().RegistraCuaderno(c);
        }
        public int RegistraCuadernoProducto(CuadernoOralneProducto c)
        {
            return new Co_CuadernoOralne().RegistraCuadernoProducto(c);
        }
        public int ObtieneNroCuaderno()
        {
            return new Co_CuadernoOralne().ObtieneNroCuaderno();
        }


    }
}
