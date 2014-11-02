using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Plugin2
{
    public class Plugin2
    {
        public static string getPluginName()
        {
            return "FontSize20SEL";
        }
        public static void FontSize20SEL(RichTextBox editor)
        {
            editor.SelectionFont = new Font(editor.Font.OriginalFontName, 20);
        }
    }
}
