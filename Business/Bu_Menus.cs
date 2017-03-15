using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using Entity;
using System.Data;

namespace Business
{
    public class Bu_Menus
    {
        public DataTable Menu_Asignados(int id, bool estado)
        {
            return new Co_Menus().Menu_Asignados(id, estado);
        }
        public DataTable Menu_Usuario(int id)
        {
            return new Co_Menus().Menu_Usuario(id);
        }
        public int Asigna_Menu(int usuario_id, int menu_sistema, bool estado_id)
        {
            return new Co_Menus().Asigna_Menu(usuario_id, menu_sistema, estado_id);
        }
    }
}
