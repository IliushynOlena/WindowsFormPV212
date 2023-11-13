namespace _07_ListBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.moveRightBtn = new System.Windows.Forms.Button();
            this.moveLeftBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.showSelectionBtn = new System.Windows.Forms.Button();
            this.removeSelectedBtn = new System.Windows.Forms.Button();
            this.deleteCheckedBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(333, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Box";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1202, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(537, 81);
            this.label2.TabIndex = 1;
            this.label2.Text = "Checked List Box";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 41;
            this.listBox1.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Yellow",
            "Gray",
            "Orange",
            "Brown"});
            this.listBox1.Location = new System.Drawing.Point(144, 146);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(766, 660);
            this.listBox1.TabIndex = 2;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Yellow",
            "Gray",
            "Orange",
            "Brown"});
            this.checkedListBox1.Location = new System.Drawing.Point(1176, 155);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(806, 664);
            this.checkedListBox1.TabIndex = 3;
            // 
            // moveRightBtn
            // 
            this.moveRightBtn.Font = new System.Drawing.Font("Segoe UI Black", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.moveRightBtn.Location = new System.Drawing.Point(956, 280);
            this.moveRightBtn.Name = "moveRightBtn";
            this.moveRightBtn.Size = new System.Drawing.Size(181, 119);
            this.moveRightBtn.TabIndex = 4;
            this.moveRightBtn.Text = "-->";
            this.moveRightBtn.UseVisualStyleBackColor = true;
            this.moveRightBtn.Click += new System.EventHandler(this.moveRightBtn_Click);
            // 
            // moveLeftBtn
            // 
            this.moveLeftBtn.Font = new System.Drawing.Font("Segoe UI Black", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.moveLeftBtn.Location = new System.Drawing.Point(956, 484);
            this.moveLeftBtn.Name = "moveLeftBtn";
            this.moveLeftBtn.Size = new System.Drawing.Size(181, 119);
            this.moveLeftBtn.TabIndex = 5;
            this.moveLeftBtn.Text = "<--";
            this.moveLeftBtn.UseVisualStyleBackColor = true;
            this.moveLeftBtn.Click += new System.EventHandler(this.moveLeftBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 871);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(597, 47);
            this.textBox1.TabIndex = 6;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Segoe UI Black", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addBtn.Location = new System.Drawing.Point(807, 835);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(103, 83);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // showSelectionBtn
            // 
            this.showSelectionBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.showSelectionBtn.Location = new System.Drawing.Point(152, 1026);
            this.showSelectionBtn.Name = "showSelectionBtn";
            this.showSelectionBtn.Size = new System.Drawing.Size(393, 130);
            this.showSelectionBtn.TabIndex = 8;
            this.showSelectionBtn.Text = "Show Selection";
            this.showSelectionBtn.UseVisualStyleBackColor = true;
            this.showSelectionBtn.Click += new System.EventHandler(this.showSelectionBtn_Click);
            // 
            // removeSelectedBtn
            // 
            this.removeSelectedBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeSelectedBtn.Location = new System.Drawing.Point(580, 1026);
            this.removeSelectedBtn.Name = "removeSelectedBtn";
            this.removeSelectedBtn.Size = new System.Drawing.Size(393, 130);
            this.removeSelectedBtn.TabIndex = 9;
            this.removeSelectedBtn.Text = "Remove Selected Items";
            this.removeSelectedBtn.UseVisualStyleBackColor = true;
            this.removeSelectedBtn.Click += new System.EventHandler(this.removeSelectedBtn_Click);
            // 
            // deleteCheckedBtn
            // 
            this.deleteCheckedBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteCheckedBtn.Location = new System.Drawing.Point(1490, 1026);
            this.deleteCheckedBtn.Name = "deleteCheckedBtn";
            this.deleteCheckedBtn.Size = new System.Drawing.Size(393, 130);
            this.deleteCheckedBtn.TabIndex = 10;
            this.deleteCheckedBtn.Text = "Delete Checked Items";
            this.deleteCheckedBtn.UseVisualStyleBackColor = true;
            this.deleteCheckedBtn.Click += new System.EventHandler(this.deleteCheckedBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2180, 1192);
            this.Controls.Add(this.deleteCheckedBtn);
            this.Controls.Add(this.removeSelectedBtn);
            this.Controls.Add(this.showSelectionBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.moveLeftBtn);
            this.Controls.Add(this.moveRightBtn);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private CheckedListBox checkedListBox1;
        private Button moveRightBtn;
        private Button moveLeftBtn;
        private TextBox textBox1;
        private Button addBtn;
        private Button showSelectionBtn;
        private Button removeSelectedBtn;
        private Button deleteCheckedBtn;
    }
}