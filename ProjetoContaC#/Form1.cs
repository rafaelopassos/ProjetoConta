namespace ProjetoContaC_
{
    public partial class Form1 : Form
    {
        Conta conta;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conta = new Conta(1, textBox1.Text, Int32.Parse(textBox2.Text));

            //conta.Numero = 1;
            //conta.Titular = textBox1.Text;
            //conta.Saldo = Int32.Parse(textBox2.Text);

            button1.Visible = false;

            label4.Text = conta.Titular;
            label6.Text = conta.Saldo.ToString();

            textBox1.Text = " ";
            textBox2.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valor = Int32.Parse(textBox2.Text);
            
            conta.depositar(valor);
            
            label6.Text = conta.Saldo.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double valor = Int32.Parse(textBox2.Text);
            
            if (!conta.sacar(valor))
            {
                MessageBox.Show("Não foi possivel sacar");
            }
            
            label6.Text = conta.Saldo.ToString();
        }
    }
}
