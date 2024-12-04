using System.Diagnostics.Eventing.Reader;
using System.Text;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked) 
            {
                PassGen(6);
            }
            else if (checkBox2.Checked) 
            {
                PassGen(12);
            }
            else if(checkBox3.Checked) 
            {
                PassGen(18);
            }
            else
            {
                PassGen(8);
            }

        }
        public void PassGen(int len)
        {
            const string ValidChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUWXYZ1234567890";
            System.Text.StringBuilder result = new StringBuilder();
            Random random = new Random();
            while (0 < len--)
            {
                result.Append(ValidChar[random.Next(ValidChar.Length)]);
            }
            textBox1.Text = result.ToString();
        }
    }
}