using System.Net.Sockets;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usu = textBox1.Text;
            string senha = textBox2.Text;

            if (usu == "2022102020041" && senha == "123123")
            {
                AVA ava = new AVA();
                ava.ShowDialog();
            }
            else
            {
                MessageBox.Show("Senha ou login invalidos!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
