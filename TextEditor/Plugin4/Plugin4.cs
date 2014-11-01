using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugin4
{
    public class Plugin4
    {
        public static string getPluginName()
        {
            return "methodFromPlugin4";
        }
        public static void  methodFromPlugin4(RichTextBox editor)
        {
            editor.Text += " text from plugin4";
        }
    }
}
