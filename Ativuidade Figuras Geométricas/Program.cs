using System;
using System.Windows.Forms;

namespace Ativuidade_Figuras_Geométricas
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FigurasGeometricas()); 
        }
    }
}
