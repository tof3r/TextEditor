using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugin2
{
    public class Plugin2
    {
        public static string getPluginName()
        {
            return "methodFromPlugin2";
        }
        public static void methodFromPlugin2(RichTextBox editor)
        {
            editor.Text += " text from plugin2";
        }
    }
}
