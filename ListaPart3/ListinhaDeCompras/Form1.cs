namespace ListinhaDeCompras
{
    public partial class Form1 : Form
    {
        private Listagem listagem;
        public Form1()
        {
            InitializeComponent();
            listagem = new Listagem();
        }

        private void NomeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuantProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrecoProduto_TextChanged(object sender, EventArgs e)
        {

        }
        private void ListaProdutos_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void BotaoADD_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = NomeProduto.Text;
                int quantidade = Convert.ToInt32(QuantProduto.Text);
                double preco = Convert.ToDouble(PrecoProduto.Text);

                Produto produto = new Produto(nome, quantidade, preco);
                listagem.AddProduto(produto);

                //Limpar após adicionar o produto
                NomeProduto.Text = string.Empty;
                QuantProduto.Text = string.Empty;
                PrecoProduto.Text = string.Empty;

                AtualizarLista();
            }
            catch (FormatException)
            {
                MessageBox.Show("Insira valores válidos. Tente novamente!");
            }
        }

        private void AtualizarLista()
        {
            ListaProdutos.Items.Clear();

            foreach (var produto in listagem.GetLista())
            {
                //ListaProdutos.Items.Add(ConstruirLista(produto));
                ListaProdutos.Items.Add($"{produto.Nome} - Quant. {produto.Quantidade}, Preço: R${produto.Preco}, Valor Total: R${produto.CalcularTotal()}");
            }
        }

        private string ConstruirLista(Produto p)
        {
            string preco = p.Preco.ToString("0.00") + "$";
            string quantidade = p.Quantidade.ToString("000");
            return p.Nome + new string(' ', 5 - p.Nome.Length - quantidade.Length - preco.Length) + preco;
        }
    }
}