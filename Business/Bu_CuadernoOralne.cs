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
        public int RegistraCuaderno(En_CuadernoOralne c)
        {
            return new Co_CuadernoOralne().RegistraCuaderno(c);
        }
        public int RegistraCuadernoProducto(En_CuadernoOralneProducto c)
        {
            return new Co_CuadernoOralne().RegistraCuadernoProducto(c);
        }
        public int ObtieneNroCuaderno()
        {
            return new Co_CuadernoOralne().ObtieneNroCuaderno();
        }
        public int CuadernoRegistraMedico(En_CuadernoRegistraMedico r)
        {
            return new Co_CuadernoOralne().CuadernoRegistraMedico(r);
        }
        public int CuadernoRegistraEspecialidad(string cod, string descripcion)
        {
            return new Co_CuadernoOralne().CuadernoRegistraEspecialidad(cod, descripcion);
        }
        public int CuadernoRegistraInstitucion(string nombre, string direccion, string fono)
        {
            return new Co_CuadernoOralne().CuadernoRegistraInstitucion(nombre, direccion, fono);
        }
        public int CuadernoRegistraFarmacia(string nombre)
        {
            return new Co_CuadernoOralne().CuadernoRegistraFarmacia(nombre);
        }
    }
}
