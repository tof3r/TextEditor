using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadPlugins();
        }

        private void LoadPlugins()
        {
            int i = 1;
            foreach (string myFilename in Directory.GetFiles("E:\\Development\\Projects\\VisualStudioProjects\\TextEditor", "*.dll", SearchOption.AllDirectories))
            {
                try
                {
                    Assembly plugin = Assembly.LoadFrom(myFilename);
                    string NameSpaceName = Path.GetFileNameWithoutExtension(myFilename);
                    Type item = plugin.GetType(NameSpaceName + ".Plugin" + i);
                    MethodInfo method = item.GetMethod("getPluginName");
                    object result = method.Invoke(null, new object[] { });
                    pluginsMenu.DropDownItems.Add(new ToolStripMenuItem(result.ToString(), null, MenuHandler, item.Name + " " + result.ToString()));
                    i++;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
           }

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadTextFromRTB();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveTextFromRTB();
        }

        private void addPluginButton_Click(object sender, EventArgs e)
        {
            if (!pluginsMenu.DropDownItems.ContainsKey(addPluginTV.Text))
            {
                pluginsMenu.DropDownItems.Add(new ToolStripMenuItem(addPluginTV.Text, null, MenuHandler, addPluginTV.Text));
                addPluginTV.Text = "";
            }
        }

        private void MenuHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem items = (ToolStripMenuItem)sender;
            object result = null;
            bool isInvoked = false;
            foreach (string myFilename in Directory.GetFiles("E:\\Development\\Projects\\VisualStudioProjects\\TextEditor", "*.dll", SearchOption.AllDirectories))
            {
                Assembly plugin = Assembly.LoadFrom(myFilename);
                foreach (Type item in plugin.GetTypes()) //lista klas
                {
                    foreach (MethodInfo method in item.GetMethods())
                    {
                        string[] pluginInfo = items.Name.ToString().Split(new Char[]{' '});
                        if (method.Name.Equals(pluginInfo[1]) && !isInvoked)
                        {
                            result = method.Invoke(null, new Object[] { editorTV });
                            isInvoked = true;
                        }
                    }
                }
            }
        }

        private void saveTextFromRTB() 
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
            saveFile1.FileName.Length > 0)
            {
                editorTV.SaveFile(saveFile1.FileName);
            }
        }

        private void loadTextFromRTB()
        {
            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
            openFile1.FileName.Length > 0)
            {
                editorTV.LoadFile(openFile1.FileName);
            }

        }
    }
}
