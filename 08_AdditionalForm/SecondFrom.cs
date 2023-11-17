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
   
    public partial class SecondFrom : Form
    {
        private string userName;

        public string UserName
        {
            get { return userName; }
            set 
            { 
                userName = value;
                nameLb.Text = $"Hello dear, {UserName}";
            }
        }

        public SecondFrom()
        {          
            InitializeComponent();
        }
        public SecondFrom(string name)
        {
            InitializeComponent();
            UserName = name;
            nameLb.Text = $"Hello dear, {UserName}" ;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"User name : {UserName}");
        }
        public void Show(string name)
        {
            UserName = name;
            this.Show();
        }
    }
}
