using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBreadDemo1._0.Interfaces
{
    public interface IntProveedor
    {

        void agregarProveedor(string nombre, Boolean estado, string nombreUsuario);

        void editarProveedor(int codigo, string nombre, Boolean estado, string nombreUsuario);

    }
}
