using NextBreadDemo1._0.Forms.Avisos.Inventario;
using NextBreadDemo1._0.Forms.Caja_Registradora;
using NextBreadDemo1._0.Forms.Inventario;
using NextBreadDemo1._0.Forms.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextBreadDemo1._0
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Login());
        }
    }
}
