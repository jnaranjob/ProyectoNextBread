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
        void editarUsuario(int codigo, string nombre, string clave, int permiso, Boolean estado);
        void validarCredenciales(string nombre, string clave);
        int validarPermiso(string nombre);

    }
}
