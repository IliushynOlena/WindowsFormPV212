namespace _11_TreeViewListView
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node16");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node15", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node14", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node11", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node12");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node13");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node8", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node4", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Node3");
            this.dirTree = new System.Windows.Forms.TreeView();
            this.fileList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // dirTree
            // 
            this.dirTree.Location = new System.Drawing.Point(3, 3);
            this.dirTree.Name = "dirTree";
            treeNode1.Name = "Node16";
            treeNode1.Text = "Node16";
            treeNode2.Name = "Node15";
            treeNode2.Text = "Node15";
            treeNode3.Name = "Node14";
            treeNode3.Text = "Node14";
            treeNode4.Name = "Node11";
            treeNode4.Text = "Node11";
            treeNode5.Name = "Node12";
            treeNode5.Text = "Node12";
            treeNode6.Name = "Node13";
            treeNode6.Text = "Node13";
            treeNode7.Name = "Node8";
            treeNode7.Text = "Node8";
            treeNode8.Name = "Node9";
            treeNode8.Text = "Node9";
            treeNode9.Name = "Node10";
            treeNode9.Text = "Node10";
            treeNode10.Name = "Node4";
            treeNode10.Text = "Node4";
            treeNode11.Name = "Node5";
            treeNode11.Text = "Node5";
            treeNode12.Name = "Node6";
            treeNode12.Text = "Node6";
            treeNode13.Name = "Node7";
            treeNode13.Text = "Node7";
            treeNode14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            treeNode14.ForeColor = System.Drawing.Color.Navy;
            treeNode14.Name = "Node0";
            treeNode14.Text = "Node0";
            treeNode15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            treeNode15.ForeColor = System.Drawing.Color.Lime;
            treeNode15.Name = "Node1";
            treeNode15.Text = "Node1";
            treeNode16.Name = "Node2";
            treeNode16.Text = "Node2";
            treeNode17.Name = "Node3";
            treeNode17.Text = "Node3";
            this.dirTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
            this.dirTree.Size = new System.Drawing.Size(851, 1143);
            this.dirTree.TabIndex = 0;
            this.dirTree.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.dirTree_BeforeCollapse);
            this.dirTree.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.dirTree_AfterExpand);
            this.dirTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.dirTree_AfterSelect);
            // 
            // fileList
            // 
            this.fileList.Location = new System.Drawing.Point(879, 5);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(974, 1146);
            this.fileList.TabIndex = 1;
            this.fileList.UseCompatibleStateImageBehavior = false;
            this.fileList.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1866, 1151);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.dirTree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView dirTree;
        private ListView fileList;
    }
}