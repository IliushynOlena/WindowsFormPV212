namespace _08_AdditionalForm
{
    partial class SecondFrom
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
            this.label1 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.nameLb = new System.Windows.Forms.Label();
            this.showBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(504, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "Second Form";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(825, 451);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(284, 113);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLb.Location = new System.Drawing.Point(504, 278);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(298, 62);
            this.nameLb.TabIndex = 2;
            this.nameLb.Text = "Hello, ..............";
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(342, 451);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(284, 113);
            this.showBtn.TabIndex = 3;
            this.showBtn.Text = "Show User";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // SecondFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 757);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.nameLb);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label1);
            this.Name = "SecondFrom";
            this.Text = "SecondFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button exitBtn;
        private Label nameLb;
        private Button showBtn;
    }
}