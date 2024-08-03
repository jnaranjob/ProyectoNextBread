using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBreadDemo1._0.Interfaces
{
    public interface IntInventario
    {
        void agregarProducto(long codigoP, string nombre, int precioCosto, int cantidad, string nombreProveedor, Boolean estado, string nombreUsuario);
        void editarProducto(long codigoP, string nombre, int precioCosto, int cantidad, string nombreProveedor, Boolean estado, string nombreUsuario);

    }
}
