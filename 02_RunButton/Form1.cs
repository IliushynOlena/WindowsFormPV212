namespace _02_RunButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Mouse Position {e.X} : {e.Y}";

            Point mouse = e.Location;
            Random random = new Random();   
            if(mouse.X >= btnCatch.Left -20 &&  
                (mouse.X <= btnCatch.Left + btnCatch.Width +20))
            {
                if(mouse.X >= btnCatch.Left + (btnCatch.Width/2))
                {
                    btnCatch.Left = btnCatch.Left-5;    
                }
                else
                {
                    btnCatch.Left = btnCatch.Left + 5;
                }
            }

            if(btnCatch.Left<0 || btnCatch.Right> this.ClientSize.Width)
            {
                btnCatch.Location = new Point(random.Next(this.Width-btnCatch.Width), 
                    random.Next(this.Height-btnCatch.Height));   
            }
            

        }

        private void btnCatch_Click(object sender, EventArgs e)
        {

        }
    }
}