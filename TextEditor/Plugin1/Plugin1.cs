using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Plugin1
{
    public class Plugin1
    {
        public static string getPluginName()
        {
            return "BoldSEL";
        }
        public static void BoldSEL(RichTextBox editor)
        {
            editor.SelectionFont = new Font(editor.Font, FontStyle.Bold);
        }
    }
}
