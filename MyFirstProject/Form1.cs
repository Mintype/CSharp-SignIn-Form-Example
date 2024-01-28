namespace MyFirstProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usernameText = textBox1.Text;
            String passwordText = textBox2.Text;

            MessageBox.Show("Your username is \"" + usernameText + "\"\nYour password is \n" + passwordText + "\n");
        }
    }
}
