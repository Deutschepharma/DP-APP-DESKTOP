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
        //reportes de cuaderno oralne
        public DataTable ListarCuadernos(int val)
        {
            return new Co_CuadernoOralne().ListarCuadernos(val);
        }
        public DataTable ListarProductos_NroCuaderno(int cod)
        {
            return new Co_CuadernoOralne().ListarProductos_NroCuaderno(cod);
        }
        public DataTable ListarCuaderno_Fecha(string fecDesde, string fecHasta)
        {
            return new Co_CuadernoOralne().ListarCuaderno_Fecha(fecDesde, fecHasta);
        }
        public DataTable ListarCuadernos_Medico(int val)
        {
            return new Co_CuadernoOralne().ListarCuadernos_Medico(val);
        }
        public DataTable ExportarData_Medico(int val)
        {
            return new Co_CuadernoOralne().ExportarData_Medico(val);
        }
        public DataTable ExportarData_Fecha(string fecDesde, string fecHasta)
        {
            return new Co_CuadernoOralne().ExportarData_Fecha(fecDesde, fecHasta);
        }
        public DataTable ListarCuadernos_Productos(int val)
        {
            return new Co_CuadernoOralne().ListarCuadernos_Productos(val);
        }

        //Modificaciones al Cuaderno Beneficio 1+1
        public DataTable Marketing_Buscar_NroCuaderno(int val)
        {
            return new Co_CuadernoOralne().Marketing_Buscar_NroCuaderno(val);
        }
        public DataTable Marketing_Buscar_Productos_NroCuaderno(int val)
        {
            return new Co_CuadernoOralne().Marketing_Buscar_Productos_NroCuaderno(val);
        }
        public int Marketing_Registra_Cuaderno_Producto(En_CuadernoOralneProducto c)
        {
            return new Co_CuadernoOralne().Marketing_Registra_Cuaderno_Producto(c);
        }
        public int Marketing_Registra_Cuaderno(En_CuadernoOralne c)
        {
            return new Co_CuadernoOralne().Marketing_Registra_Cuaderno(c);
        }

    }
}
