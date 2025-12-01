namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InitMenuStrip();
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        private void InitMenuStrip()
        {
            MenuStrip menuStrip = new MenuStrip();
            ToolStripMenuItem fileMenuItem = new ToolStripMenuItem("File");
            ToolStripMenuItem aboutProgramMenuItem = new ToolStripMenuItem("About Program", null, (s, e) => { Form1.ShowAboutProgram(); });
            fileMenuItem.DropDownItems.Add("New");
            fileMenuItem.DropDownItems.Add("Open");
            fileMenuItem.DropDownItems.Add("Save", null, (s, e) => { throw new NotImplementedException(); });
            menuStrip.Items.Add(fileMenuItem);
            menuStrip.Items.Add(aboutProgramMenuItem);
            this.MainMenuStrip = menuStrip;
            this.Controls.Add(menuStrip);
        }
        
        #endregion
    }
}
