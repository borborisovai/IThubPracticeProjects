namespace Quizler
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
            questionTabs = new TabControl();
            questionTab1 = new TabPage();
            button1 = new Button();
            textBox1 = new TextBox();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            menuStrip = new MenuStrip();
            toolStripMenuItemFile = new ToolStripMenuItem();
            toolStripMenuItemEdit = new ToolStripMenuItem();
            toolStripMenuItemHelp = new ToolStripMenuItem();
            toolStripMenuItemFileCreate = new ToolStripMenuItem();
            toolStripMenuItemFileOpen = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuItemFileExit = new ToolStripMenuItem();
            toolStripMenuItemFileSave = new ToolStripMenuItem();
            questionTabs.SuspendLayout();
            questionTab1.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // questionTabs
            // 
            questionTabs.Controls.Add(questionTab1);
            questionTabs.Dock = DockStyle.Fill;
            questionTabs.Location = new Point(0, 0);
            questionTabs.Name = "questionTabs";
            questionTabs.SelectedIndex = 0;
            questionTabs.Size = new Size(656, 495);
            questionTabs.TabIndex = 0;
            // 
            // questionTab1
            // 
            questionTab1.Controls.Add(button1);
            questionTab1.Controls.Add(textBox1);
            questionTab1.Controls.Add(linkLabel1);
            questionTab1.Controls.Add(label1);
            questionTab1.Controls.Add(dateTimePicker1);
            questionTab1.Controls.Add(comboBox1);
            questionTab1.Controls.Add(checkBox1);
            questionTab1.Controls.Add(radioButton1);
            questionTab1.Location = new Point(4, 34);
            questionTab1.Name = "questionTab1";
            questionTab1.Padding = new Padding(3);
            questionTab1.Size = new Size(648, 457);
            questionTab1.TabIndex = 0;
            questionTab1.Text = "Вопрос 1";
            questionTab1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 31);
            textBox1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            linkLabel1.Location = new Point(0, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(100, 23);
            linkLabel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 31);
            dateTimePicker1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.Location = new Point(0, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 33);
            comboBox1.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.Location = new Point(0, 0);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 24);
            checkBox1.TabIndex = 6;
            // 
            // radioButton1
            // 
            radioButton1.Location = new Point(0, 0);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(104, 24);
            radioButton1.TabIndex = 7;
            // TODO: Доделать редактор 
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItemFile, toolStripMenuItemEdit, toolStripMenuItemHelp });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(656, 33);
            menuStrip.TabIndex = 8;
            menuStrip.Text = "Файл";
            menuStrip.Visible = false;
            // 
            // toolStripMenuItemFile
            // 
            toolStripMenuItemFile.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemFileCreate, toolStripMenuItemFileOpen, toolStripMenuItemFileSave, toolStripSeparator1, toolStripMenuItemFileExit });
            toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            toolStripMenuItemFile.Size = new Size(65, 29);
            toolStripMenuItemFile.Text = "Файл";
            // 
            // toolStripMenuItemEdit
            // 
            toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            toolStripMenuItemEdit.Size = new Size(85, 29);
            toolStripMenuItemEdit.Text = "Правка";
            // 
            // toolStripMenuItemHelp
            // 
            toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            toolStripMenuItemHelp.Size = new Size(93, 29);
            toolStripMenuItemHelp.Text = "Справка";
            // 
            // toolStripMenuItemFileCreate
            // 
            toolStripMenuItemFileCreate.Name = "toolStripMenuItemFileCreate";
            toolStripMenuItemFileCreate.Size = new Size(170, 30);
            toolStripMenuItemFileCreate.Text = "Создать";
            // 
            // toolStripMenuItemFileOpen
            // 
            toolStripMenuItemFileOpen.Name = "toolStripMenuItemFileOpen";
            toolStripMenuItemFileOpen.Size = new Size(170, 30);
            toolStripMenuItemFileOpen.Text = "Открыть";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(167, 6);
            // 
            // toolStripMenuItemFileExit
            // 
            toolStripMenuItemFileExit.Name = "toolStripMenuItemFileExit";
            toolStripMenuItemFileExit.Size = new Size(170, 30);
            toolStripMenuItemFileExit.Text = "Выйти";
            // 
            // toolStripMenuItemFileSave
            // 
            toolStripMenuItemFileSave.Name = "toolStripMenuItemFileSave";
            toolStripMenuItemFileSave.Size = new Size(170, 30);
            toolStripMenuItemFileSave.Text = "Сохранить";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 495);
            Controls.Add(questionTabs);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            questionTabs.ResumeLayout(false);
            questionTab1.ResumeLayout(false);
            questionTab1.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl questionTabs;
        private TabPage questionTab1;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private Button button1;
        private TextBox textBox1;
        private LinkLabel linkLabel1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private MenuStrip menuStrip;
        private ToolStripMenuItem toolStripMenuItemFile;
        private ToolStripMenuItem toolStripMenuItemEdit;
        private ToolStripMenuItem toolStripMenuItemHelp;
        private ToolStripMenuItem toolStripMenuItemFileCreate;
        private ToolStripMenuItem toolStripMenuItemFileOpen;
        private ToolStripMenuItem toolStripMenuItemFileSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItemFileExit;
    }
}