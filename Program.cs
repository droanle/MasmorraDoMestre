using MasmorraDoMestre.Model;
using MasmorraDoMestre.View;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasmorraDoMestre
{
    internal static class Program
    {
        static PrivateFontCollection pf = new Utilities().FontDefine();

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Sheet(1,1,pf));
        }
    }
}
