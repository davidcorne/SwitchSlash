//=============================================================================
//

using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Linq;

//=============================================================================
namespace SS
{
    class Run
    {
        [STAThread]
        static void Main()
        {
            string text = Clipboard.GetText();
            // Swap all / for \ and visa-versa
            char[] buffer = text.Select(c => c == '\\' ? '/' : (c == '/' ? '\\' : c)).ToArray();
            string newText = new string(buffer);
            Console.WriteLine(newText);
        }
    }
}
