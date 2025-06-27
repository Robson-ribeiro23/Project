using Ac;
using System;
using System.Windows.Forms;

namespace Acelera2025
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Navegador.IrParaInicio();
            Application.Run(new ApplicationContext());
        }
    }
}
