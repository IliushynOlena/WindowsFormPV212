namespace _01_IntroToWF
{
    public partial class Form1 : Form
    {
        Point startPoint;
        public Form1()
        {
            InitializeComponent();
            startPoint = CSharpBtn.Location;    
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello WinForms", "Congratulation!!!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClick_MouseEnter(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Yellow;
        }

        private void btnClick_MouseLeave(object sender, EventArgs e)
        {
            btnClick.BackColor = Color.Lime;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close window?", "", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning) == DialogResult.Yes)
            { this.Close(); }
        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            CSharpBtn.Location = new Point(CSharpBtn.Location.X-5, CSharpBtn.Location.Y); 
        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            CSharpBtn.Location = new Point(CSharpBtn.Location.X+5, CSharpBtn.Location.Y); 

        }

        private void CSharpBtn_Click(object sender, EventArgs e)
        {
            CSharpBtn.Location = startPoint;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Mouse Position {e.X} : {e.Y}";
            
        }
    }
}