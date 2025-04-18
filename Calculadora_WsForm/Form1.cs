namespace Calculadora_WsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private enum Operacao
        {
            Somar, Subtrair, Multiplicar, Dividir
        };

        Operacao op;
        decimal igual, valor1;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            resultado.Text += "0";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            resultado.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultado.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultado.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultado.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resultado.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resultado.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resultado.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            resultado.Text += "9";
        }

        private void botao_somar_Click(object sender, EventArgs e)
        {
            try
            {
                op = Operacao.Somar;
                valor1 = System.Convert.ToDecimal(resultado.Text);
                resultado.Text = "";
            }
            catch
            {
                MessageBox.Show("Necessário digitar um número para a operação.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void botao_subtrair_Click(object sender, EventArgs e)
        {
            try
            {
                op = Operacao.Subtrair;
                valor1 = System.Convert.ToDecimal(resultado.Text);
                resultado.Text = "";
            }
            catch
            {
                MessageBox.Show("Necessário digitar um número para a operação.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void botao_multi_Click(object sender, EventArgs e)
        {
            try
            {
                op = Operacao.Multiplicar;
                valor1 = System.Convert.ToDecimal(resultado.Text);
                resultado.Text = "";
            }
            catch
            {
                MessageBox.Show("Necessário digitar um número para a operação.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void botao_dividir_Click(object sender, EventArgs e)
        {
            try
            {
                op = Operacao.Dividir;
                valor1 = System.Convert.ToDecimal(resultado.Text);
                resultado.Text = "";
            }
            catch { MessageBox.Show("Necessário digitar um número para a operação.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }


        private void enter_button_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case Operacao.Somar:
                    igual = valor1 + System.Convert.ToDecimal(resultado.Text);
                    break;

                case Operacao.Subtrair:
                    igual = valor1 - System.Convert.ToDecimal(resultado.Text);
                    break;

                case Operacao.Multiplicar:
                    igual = valor1 * System.Convert.ToDecimal(resultado.Text);
                    break;

                case Operacao.Dividir:
                    igual = valor1 / System.Convert.ToDecimal(resultado.Text);
                    break;
            }
            resultado.Text = System.Convert.ToString(igual);
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            resultado.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text.Remove(resultado.Text.Length - 1, 1);
        }

        private void comma_button_Click(object sender, EventArgs e)
        {
            if (!resultado.Text.Contains(","))
            {
                resultado.Text += ",";

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor1 = System.Convert.ToDecimal(resultado.Text);
            valor1 /= 100;
            resultado.Text = System.Convert.ToString(valor1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text.Remove(resultado.Text.Length - 1, 1);
        }
    }
}
