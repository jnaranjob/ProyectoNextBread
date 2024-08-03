using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextBreadDemo1._0.Entidades
{
    public abstract class Inventario
    {
        string codigoP { get; set; }
        string nombreP { get; set; }
        int precioP { get; set; }
        string tipoP { get; set; }
        int cantidad { get; set; }
        string nombreProveedor { get; set; }
        Boolean estado { get; set; }
    }
}
