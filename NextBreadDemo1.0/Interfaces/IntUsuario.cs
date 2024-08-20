using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBreadDemo1._0.Interfaces
{
    public interface IntUsuario
    {
        void agregarUsuario(int codigo, string nombre, string clave, int permiso, Boolean estado);
        void editarUsuario(string nombre, string clave, int permiso);
        void desactivarUsuario(string nombre, Boolean estado);
        void validarCredenciales(string nombre, string clave);
        Boolean validarPermiso(string nombre);

    }
}
