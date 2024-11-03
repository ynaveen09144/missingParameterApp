using MissingParameterIdentifier.Data;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace MissingParameterIdentifier.Controller
{
    internal class MissingParameters
    {
        public void initiate()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Missing_Parameter_Identifier());
        }
        //[STAThread]
        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new Missing_Parameter_Identifier());
        //}
    }
}
