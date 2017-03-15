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
        public int UsuarioCambiaEstado(int id, int estado)
        {
            return new Co_Usuarios().UsuarioCambiaEstado(id, estado);
        }
        public int UsuarioCambiaClave(int id, string clave)
        {
            return new Co_Usuarios().UsuarioCambiaClave(id, clave);
        }
        public DataTable CargaUsuariosEstados()
        {
            return new Co_Usuarios().CargaUsuariosEstados();
        }
        public int UsuarioDesbloquea(int id)
        {
            return new Co_Usuarios().UsuarioDesbloquea(id);
        }
        public DataTable CargarComboBox(int flag, int ddlFlag)
        {
            return new Co_Usuarios().CargarComboBox(flag, ddlFlag);
        }



    }
}
