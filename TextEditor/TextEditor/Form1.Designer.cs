namespace TextEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editorTV = new System.Windows.Forms.RichTextBox();
            this.addPluginTV = new System.Windows.Forms.TextBox();
            this.addPluginButton = new System.Windows.Forms.Button();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.pluginsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // pluginsMenu
            // 
            this.pluginsMenu.Name = "pluginsMenu";
            this.pluginsMenu.Size = new System.Drawing.Size(58, 20);
            this.pluginsMenu.Text = "Plugins";
            // 
            // editorTV
            // 
            this.editorTV.Location = new System.Drawing.Point(13, 28);
            this.editorTV.Name = "editorTV";
            this.editorTV.Size = new System.Drawing.Size(882, 483);
            this.editorTV.TabIndex = 1;
            this.editorTV.Text = "";
            // 
            // addPluginTV
            // 
            this.addPluginTV.Location = new System.Drawing.Point(106, 2);
            this.addPluginTV.Name = "addPluginTV";
            this.addPluginTV.Size = new System.Drawing.Size(100, 20);
            this.addPluginTV.TabIndex = 2;
            // 
            // addPluginButton
            // 
            this.addPluginButton.Location = new System.Drawing.Point(213, 0);
            this.addPluginButton.Name = "addPluginButton";
            this.addPluginButton.Size = new System.Drawing.Size(75, 23);
            this.addPluginButton.TabIndex = 3;
            this.addPluginButton.Text = "Dodaj";
            this.addPluginButton.UseVisualStyleBackColor = true;
            this.addPluginButton.Click += new System.EventHandler(this.addPluginButton_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 523);
            this.Controls.Add(this.addPluginButton);
            this.Controls.Add(this.addPluginTV);
            this.Controls.Add(this.editorTV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pluginsMenu;
        private System.Windows.Forms.RichTextBox editorTV;
        private System.Windows.Forms.TextBox addPluginTV;
        private System.Windows.Forms.Button addPluginButton;
    }
}

