using System.Text;

namespace _03_BaseControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = true;
        }
        private bool IsSelectedMeal()
        {
            return checkBox1.Checked || checkBox2.Checked || checkBox3.Checked;
        }
        private void ClearTextBox()
        {
            foreach (var item in this.Controls.OfType<TextBox>())
            {
                item.Text = "";
            }
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            if(!IsSelectedMeal())
            {
                MessageBox.Show("Select any meal at least!!!");
                return;
            }
            StringBuilder res = new StringBuilder("================ Order ============\n") ;//
            res.Append("Meals : ");
            if (checkBox1.Checked)
                res.Append("Breakfast ");
            if (checkBox2.Checked)
                res.Append("Lunch ");
            if (checkBox3.Checked)
                res.Append("Dinner "); 

            res.Append("\nDelevery : ");
            if (radioButton1.Checked)
                res.Append("Economy ");
            if (radioButton2.Checked)
                res.Append("Standart ");
            if (radioButton3.Checked)
                res.Append("Fast ");
            res.AppendLine();

            res.AppendLine("Login : " + textBox1.Text);
            res.AppendLine("Password : " + textBox2.Text);
            res.AppendLine("Phone : " + maskedTextBox1.Text);
            res.AppendLine("Address : " + textBox3.Text);
            res.AppendLine("Comment : " + textBox4.Text);


            res.AppendLine("Date : " +dateTimePicker1.Value.ToString());
            res.AppendLine("From : " + monthCalendar1.SelectionStart);
            res.AppendLine("To : " +monthCalendar1.SelectionEnd);
            res.AppendLine("Count : " +numericUpDown1.Value);
            MessageBox.Show(res.ToString());
            ClearTextBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }
    }
}