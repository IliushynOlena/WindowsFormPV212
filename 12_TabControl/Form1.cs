namespace _12_TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            TabPage tabPage = new TabPage($"New Tab {tabControl.TabPages.Count + 1}");
            tabPage.UseVisualStyleBackColor = true;

            // label1
            // 
            Label mainLabel = new Label();
            mainLabel.AutoSize = true;
            mainLabel.Font = new System.Drawing.Font("Segoe UI Black", 20.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            mainLabel.Location = new System.Drawing.Point(502, 120);
            mainLabel.Name = "label1";
            mainLabel.Size = new System.Drawing.Size(374, 89);
            mainLabel.Text = "Hello User";
            // 
            // label2
            // 
            Label nameLabel = new Label();
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(183, 396);
            nameLabel.Name = "label2";
            nameLabel.Size = new System.Drawing.Size(112, 41);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name :";
            // 
            // nameTextBox
            // 
            TextBox nameTb = new TextBox();    
            nameTb.Location = new System.Drawing.Point(411, 396);
            nameTb.Name = "nameTextBox";
            nameTb.Size = new System.Drawing.Size(682, 47);
            nameTb.TabIndex = 2;
            // 
            // clearBtn
            // 
            Button clearBtn = new Button();
            clearBtn.Location = new System.Drawing.Point(559, 638);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new System.Drawing.Size(317, 72);
            clearBtn.TabIndex = 3;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += (s,args) => { nameTb.Clear(); };

            tabPage.Controls.Add(mainLabel);
            tabPage.Controls.Add(nameLabel);
            tabPage.Controls.Add(nameTb);
            tabPage.Controls.Add(clearBtn);
            tabControl.TabPages.Add(tabPage);
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(tabControl.SelectedIndex != -1)  
                tabControl.TabPages.RemoveAt(tabControl.SelectedIndex);
        }
 

        public TextBox SelectedNameTb
        {
            get 
            {
                foreach (var item in tabControl.SelectedTab.Controls.OfType<TextBox>())
                {
                    if (item.Name == "nameTextBox")
                        return item;
                }
                return null;
            }            
        }

        //TextBox GetSelectedTextBox()
        //{
        //    foreach (var item in tabControl.SelectedTab.Controls.OfType<TextBox>())
        //    {
        //        if (item.Name == "nameTextBox")
        //            return item;
        //    }
        //    return null;
        //}

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Selected User Name....{SelectedNameTb.Text}");
        }
    }
}