using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using System.Data;

namespace Business
{
    public class Bu_Ventas
    {
        public DataTable CargaCombos(int flag, int ddlFlag)
        {
            return new Co_Ventas().CargarComboBox(flag, ddlFlag);
        }
        public DataTable Carga_Ventas(int ano)
        {
            return new Co_Ventas().Carga_Ventas(ano);
        }
    }
}
