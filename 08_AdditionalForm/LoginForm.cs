using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_AdditionalForm
{
    public partial class LoginForm : Form
    {
        public User User{ get; set; }
        public LoginForm()
        {
            InitializeComponent();
            User = new User();
        }
        public LoginForm(User user )
        {
            InitializeComponent();
            User = user;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrWhiteSpace(loginTb.Text)|| 
                string.IsNullOrWhiteSpace(passwordTb.Text))
            {
                MessageBox.Show("Enter login or password!!!");
                return;
            }


            User.Login = loginTb.Text;
            User.Password = passwordTb.Text;

            DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
