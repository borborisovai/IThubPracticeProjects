namespace ControlPoint4
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
            TreeNode treeNode1 = new TreeNode("Дата Отправления: 13.04.2007");
            TreeNode treeNode2 = new TreeNode("Омар Кольмаров");
            TreeNode treeNode3 = new TreeNode("Чебупель Чебуреков");
            TreeNode treeNode4 = new TreeNode("Эконом", new TreeNode[] { treeNode2, treeNode3 });
            TreeNode treeNode5 = new TreeNode("Люкс");
            TreeNode treeNode6 = new TreeNode("Пассажиры", new TreeNode[] { treeNode4, treeNode5 });
            TreeNode treeNode7 = new TreeNode("SU14A", new TreeNode[] { treeNode1, treeNode6 });
            treeView1 = new TreeView();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeNode1.Name = "TestNode3";
            treeNode1.Text = "Дата Отправления: 13.04.2007";
            treeNode2.Name = "TestNode6";
            treeNode2.Text = "Омар Кольмаров";
            treeNode3.Name = "TestNode7";
            treeNode3.Text = "Чебупель Чебуреков";
            treeNode4.Name = "TestNode4";
            treeNode4.Text = "Эконом";
            treeNode5.Name = "TestNode8";
            treeNode5.Text = "Люкс";
            treeNode6.Name = "TestNode5";
            treeNode6.Text = "Пассажиры";
            treeNode7.Name = "TestNode1";
            treeNode7.Text = "SU14A";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode7 });
            treeView1.Size = new Size(800, 450);
            treeView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(treeView1);
            Name = "Form1";
            ShowIcon = false;
            Text = "AdminView";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
    }
}
