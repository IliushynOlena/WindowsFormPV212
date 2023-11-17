namespace _08_AdditionalForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Open Form
            //SecondFrom form = new SecondFrom(); 
            //form.ShowDialog(); //modal mode 
            //form.Show();   //no modal mode 

            //1 - use constructor
            //string name = textBox1.Text;
            //SecondFrom form = new SecondFrom(name);
            //form.Show();


            //2 - use properties child Class
            //string name = textBox1.Text;
            //SecondFrom form = new SecondFrom();
            //form.UserName = textBox1.Text;
            //form.Show();

            //3- using custom Show/ShowDialog method
            string name = textBox1.Text;
            SecondFrom form = new SecondFrom();
          
            form.Show(name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //1  - using child form property
            //User user = null;//empty reference = null
            //LoginForm loginForm = new LoginForm();
            //if (loginForm.ShowDialog()== DialogResult.OK)
            //{
            //    //1 - using child form properties
            //    user = loginForm.User;//address = address

            //    loginTb.Text = user.Login;
            //    passwordTb.Text = user.Password;
            //}

            //2 - using reference to the object
            User user = new User();
            LoginForm form = new LoginForm(user);
            if(form.ShowDialog()== DialogResult.OK)
            {
                loginTb.Text = user.Login;
                passwordTb.Text = user.Password;
            }            
        }
    }
}