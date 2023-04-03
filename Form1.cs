namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Adicao(int valor01, int valor02)
        {
            try
            {
                return valor01 + valor02;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a operação de adição. Detalhes: " + ex.Message);
                return 0;
            }
        }
        private int Subtracao(int valor01, int valor02)
        {
            try
            {
                return (valor01 - valor02);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        private int Multiplicacao(int valor01, int valor02)
        {
            try
            {
                return valor01 * valor02;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        private double Divisao(double valor01, double valor02)
        {
            try
            {
                return valor01 / valor02;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private void CaixaMarcada(CheckBox cb01, CheckBox cb02, CheckBox cb03)
        {
            try
            {
                cb01.Checked = false;
                cb02.Checked = false;
                cb03.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBotao_Click(object sender, EventArgs e)
        {
            try
            {
                int valor01, valor02;

                if (txtTexto01.Text.Equals("") == true || txtTexto02.Text.Equals("") == true)
                {
                    MessageBox.Show("Informe os 2 valores.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                valor01 = Convert.ToInt32(txtTexto01.Text);
                valor02 = Convert.ToInt32(txtTexto02.Text);

                if (cbAdicao.Checked == true)
                {
                    MessageBox.Show("A soma entre: " + valor01 + " e " + valor02 + " = " + Adicao(valor01, valor02));
                }
                else if (cbSubtracao.Checked == true)
                {
                    MessageBox.Show($"A subtração entre: {valor01} e {valor02} = {Subtracao(valor01, valor02)}");
                }
                else if (cbMultiplicacao.Checked == true)
                {
                    MessageBox.Show($"A multiplicação entre: {valor01} e {valor02} = {Multiplicacao(valor01, valor02)}");
                }
                else if (cbDivisao.Checked == true)
                {
                    if (valor02.Equals(0) == false)
                    {
                        MessageBox.Show($"A divisão entre: {valor01} e {valor02} = {Divisao(valor01, valor02)}");
                    }
                    else
                    {
                        MessageBox.Show($"Digite um número diferente de {valor02}");
                    }
                }
                else
                {
                    MessageBox.Show("Marque uma das caixinhas!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cbAdicao_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                if (cbAdicao.Checked == true)
                {
                    CaixaMarcada(cbSubtracao, cbMultiplicacao, cbDivisao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cbSubtracao_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbSubtracao.Checked == true)
                {
                    CaixaMarcada(cbAdicao, cbDivisao, cbMultiplicacao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbMultiplicacao.Checked == true)
                {
                    CaixaMarcada(cbAdicao, cbSubtracao, cbMultiplicacao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cbMultiplicacao_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbMultiplicacao.Checked == true)
                {
                    CaixaMarcada(cbAdicao, cbSubtracao, cbDivisao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbDivisao_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbDivisao.Checked == true)
                {
                    cbAdicao.Checked = false;
                    cbSubtracao.Checked = false;
                    cbMultiplicacao.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTexto01_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtTexto02_TextChanged(object sender, EventArgs e)
        {

        }

    }
}