using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Plugin3
{
    public class Plugin3
    {
        public static string getPluginName()
        {
            return "GreenBackGroundRTB";
        }
        public static void GreenBackGroundRTB(RichTextBox editor)
        {
            editor.BackColor = Color.LimeGreen;
        }
    }
}
