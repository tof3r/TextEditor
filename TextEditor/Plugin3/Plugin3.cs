using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugin3
{
    public class Plugin3
    {
        public static string getPluginName()
        {
            return "methodFromPlugin3";
        }
        public static void methodFromPlugin3(RichTextBox editor)
        {
            editor.Text += " text from plugin3";
        }
    }
}
