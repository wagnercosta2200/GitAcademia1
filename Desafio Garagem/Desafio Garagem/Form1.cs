namespace Desafio_Garagem
{
    public partial class Form1 : Form
    {
        public partial class Form1 : Form
        {
            List<Veiculo> listaNaGaragem = new List<Veiculo>();
            List<Veiculo> listaSairam = new List<Veiculo>();
            int posicao;

            string placaSaida;
            string dataSaida;
            string horaSaida;
            int permanenciaMinuto;
            int permanenciaHora;
            double valorHora;
            double valorCobrado;

            private void popularNaGaragem(List<Veiculo> lista)
            {

                textBox_Estacionados.Text = "";
                listBox_Estacionados.Items.Clear();
                int contador = 0;
                foreach (Veiculo i in lista)
                {
                    contador++;

                    textBox_Estacionados.AppendText(i.Placa + "   -   " + i.DataEntrada + "   -   " + i.HoraEntrada + Environment.NewLine);
                }
            }
            private void popularSairam(List<Veiculo> lista)
            {
                textBox_Saida.Text = "";
                listBox_Sairam.Items.Clear();
                int contador = 0;
                foreach (Veiculo i in lista)
                {
                    contador++;
                    textBox_Saida.AppendText(contador + " - " + i.Placa + " - " + i.DataSaida + " - " + i.HoraSaida + " - " + i.PermanenciaHora + " hora(s) - " + i.ValorCobrado.ToString("C"));
                }
            }


            public Form1()
        {
           
            InitializeComponent();
            Persistencia.gravarArquivoEntrada(listaNaGaragem);
            popularNaGaragem(listaNaGaragem);

            Persistencia.lerArquivoEntrada(listaNaGaragem);
            popularNaGaragem(listaNaGaragem);

            Persistencia.lerArquivoSaida(listaSairam);
            popularSairam(listaSairam);

            DateTime dataNow = DateTime.Now;

            maskedTextBox_Data.Text = dataNow.ToShortDateString();
            maskedTextBox_Hora.Text = dataNow.ToShortTimeString();

            Configurar configuracao = new Configurar();
            configuracao.lerConfiguracao();

            textBox_TamanhoGaragem.Text = configuracao.TamanhoGaragem.ToString();
            textBox_ValorHora.Text = configuracao.ValorHora.ToString("C");
            textBox_Disponivel.Text = (configuracao.TamanhoGaragem - listaNaGaragem.Count).ToString();
        }

        private void btn_Entrada_Click(object sender, EventArgs e)
        {

          
    }

        private void btn_Entrada_Click(object sender, EventArgs e)
        {
                if (Veiculo.jaCadastrado(maskedTextBox_Placa.Text, listaNaGaragem))
                {
                    MessageBox.Show("Veiculo já está na Garagem.\nPlaca repetida.", "Alerta");
                    return;
                }

                // Verifica se existe vaga
                Configurar configuracao = new Configurar();
                configuracao.lerConfiguracao();

                if (listaNaGaragem.Count >= configuracao.TamanhoGaragem)
                {
                    MessageBox.Show("Não temos vaga", "Lotação");
                    return;
                }

                DateTime dataAgora = DateTime.Now;
                string dataEntrada = dataAgora.ToShortDateString();
                string horaEntrada = dataAgora.ToShortTimeString();

                listaNaGaragem.Add(new Veiculo(maskedTextBox_Placa.Text, dataEntrada, horaEntrada, configuracao.ValorHora));
                Persistencia.gravarArquivoEntrada(listaNaGaragem);
                popularNaGaragem(listaNaGaragem);
                textBox_Disponivel.Text = (configuracao.TamanhoGaragem - listaNaGaragem.Count).ToString();
                //  Limpar dados
                DateTime dataNow = DateTime.Now;
                maskedTextBox_Data.Text = dataNow.ToShortDateString();
                maskedTextBox_Hora.Text = dataNow.ToShortTimeString();
                maskedTextBox_Placa.Text = "";
                textBox_ResumoSaida.Text = "";
                textBox_Total.Text = "";
            }
        }
    }