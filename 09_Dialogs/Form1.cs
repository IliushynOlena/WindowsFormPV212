using Microsoft.WindowsAPICodePack.Dialogs;

namespace _09_Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog()== DialogResult.OK)
            {
                this.BackColor = color.Color;
            }
        }

        private void fontBtn_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();   
            if(fontDialog.ShowDialog()== DialogResult.OK)
            {
                var selected = fontDialog.Font;
                openFileBtn.Font = selected;
                saveFileBtn.Font = selected;
                openFolderBtn.Font = selected;
                backColorButton.Font = selected;
                fontBtn.Font = selected;
            }
           

        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory =
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.Filter = "All files(*.*)|*.*|Text files(*.txt)|*.txt||";
            openFileDialog.FilterIndex = 2;
            if (openFileDialog.ShowDialog()== DialogResult.OK)
            {
                string message = File.ReadAllText(openFileDialog.FileName);
                textBox1.Text = message;
            }
        }

        private void saveFileBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.DefaultExt = ".txt";
            saveFileDialog.OverwritePrompt = true;
            if(saveFileDialog.ShowDialog()== DialogResult.OK)
            {
                File.WriteAllText( saveFileDialog.FileName, textBox1.Text);
            }
        }

        private void openFolderBtn_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog common = new CommonOpenFileDialog();
            common.IsFolderPicker = true;
            if( common.ShowDialog()== CommonFileDialogResult.Ok)
            {
                listBox1.Items.Clear();
                foreach (var path in Directory.GetFiles(common.FileName))
                {
                    listBox1.Items.Add(Path.GetFileName(path));
                }                
            }

            //FolderBrowserDialog folder = new FolderBrowserDialog();  
            //folder.RootFolder = Environment.SpecialFolder.Desktop;
            //if(folder.ShowDialog()== DialogResult.OK)
            //{
            //    listBox1.Items.Clear();
            //    foreach (var path in Directory.GetFiles(folder.SelectedPath))
            //    {
            //        listBox1.Items.Add(Path.GetFileName(path));
            //    }  
               
            //}
        }
    }
}