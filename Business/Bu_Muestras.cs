using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using System.Data;

namespace Business
{
    public class Bu_Muestras
    {
        public DataTable CargaCombos(int flag, int ddlFlag)
        {
            return new Co_Muestras().CargarComboBox(flag, ddlFlag);
        }
    }
}
