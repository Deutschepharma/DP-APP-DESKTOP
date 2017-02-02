using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Controller;
using System.Data;

namespace Business
{
    public class Bu_Usuarios
    {
        public DataTable CargaUsuarios()
        {
            return new Co_Usuarios().CargaUsuarios();
        }
        public DataTable Busca_Usuario(string us, string pw)
        {
            return new Co_Usuarios().Busca_Usuario(us, pw);
        }
        

    }
}
