using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plugin5
{
    public class Plugin5
    {
        public static string getPluginName()
        {
            return "methodFromPlugin5";
        }
        public static void methodFromPlugin5(RichTextBox editor) 
        {
            editor.Text += " text from plugin5";
        }
    }
}
