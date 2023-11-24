namespace _15_Paint
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
            this.colorList = new System.Windows.Forms.ComboBox();
            this.typeList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // colorList
            // 
            this.colorList.FormattingEnabled = true;
            this.colorList.Location = new System.Drawing.Point(36, 18);
            this.colorList.Name = "colorList";
            this.colorList.Size = new System.Drawing.Size(358, 49);
            this.colorList.TabIndex = 0;
            // 
            // typeList
            // 
            this.typeList.FormattingEnabled = true;
            this.typeList.Location = new System.Drawing.Point(447, 18);
            this.typeList.Name = "typeList";
            this.typeList.Size = new System.Drawing.Size(358, 49);
            this.typeList.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2110, 1140);
            this.Controls.Add(this.typeList);
            this.Controls.Add(this.colorList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox colorList;
        private ComboBox typeList;
    }
}