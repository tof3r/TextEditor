using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Plugin4
{
    public class Plugin4
    {
        public static string getPluginName()
        {
            return "ReverseText";
        }
        public static void ReverseText(RichTextBox editor)
        {
            string text = editor.Text;
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            editor.Text = new string(array);
        }
    }
}
