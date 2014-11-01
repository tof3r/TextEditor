using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugin1
{
    public class Plugin1
    {
        public static string getPluginName()
        {
            return "methodFromPlugin1";
        }
        public static void methodFromPlugin1(RichTextBox editor)
        {
            editor.Text += " text from plugin1";
        }
    }
}
