namespace WindowsFormsApp1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Calculator");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("UTILITIES", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Reg.no");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Names");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Level");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Department");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("STUDENTS", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Members");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("TEAMS", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Link1");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("LINKS", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.calck = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // calck
            // 
            this.calck.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.calck.Location = new System.Drawing.Point(130, 3);
            this.calck.Name = "calck";
            this.calck.Size = new System.Drawing.Size(406, 434);
            this.calck.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.treeView1.LineColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(8, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode1.Text = "Calculator";
            treeNode2.Name = "Node0";
            treeNode2.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode2.Text = "UTILITIES";
            treeNode3.Name = "Node1";
            treeNode3.Text = "Reg.no";
            treeNode4.Name = "Node12";
            treeNode4.Text = "Names";
            treeNode5.Name = "Node13";
            treeNode5.Text = "Level";
            treeNode6.Name = "Node14";
            treeNode6.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode6.Text = "Department";
            treeNode7.Name = "Node0";
            treeNode7.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode7.Text = "STUDENTS";
            treeNode8.Name = "Node18";
            treeNode8.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode8.Text = "Members";
            treeNode9.Name = "Node5";
            treeNode9.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode9.Text = "TEAMS";
            treeNode10.Name = "Node10";
            treeNode10.Text = "Link1";
            treeNode11.Name = "Node9";
            treeNode11.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode11.Text = "LINKS";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode7,
            treeNode9,
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(129, 434);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.node1);
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 439);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.calck);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MENU";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel calck;
        private System.Windows.Forms.TreeView treeView1;
    }
}

