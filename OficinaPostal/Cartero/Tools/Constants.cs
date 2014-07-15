using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartero.Tools
{
    public class Constants
    {
        public static string Key { get { return "HKEY_LOCAL_MACHINE\\SOFTWARE\\" + Application.ProductName + "\\" + Application.ProductVersion; } }
    }
}

