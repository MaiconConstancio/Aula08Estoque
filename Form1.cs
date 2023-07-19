namespace Aula08Estoque
{
    public partial class Form1 : Form
    {
     
        List<string> produtoNome = new List<string>();
        List<int> produtoQuantidade = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        void AdicionaProduto()
        {
            string nome = txtNome.Text;
            int quantidade = int.Parse(txtQuantidade.Text);
            produtoNome.Add(nome);
            produtoQuantidade.Add(quantidade);
        }

        void update()
        {
            int quantidadeCadastrada = produtoNome.Count();
            lblCadastros.Text = quantidadeCadastrada.ToString();
        }

        void limpaCampos()
        {
            txtNome.Clear();
            txtQuantidade.Clear();
            txtNome.Focus();

        }

        void verProdutos(bool primeiro)
        {
            string nome;
            int quantidade;

            if (primeiro == true)
            {
                nome = produtoNome[0];
                quantidade = produtoQuantidade[0];
            }
            else
            {
                nome = produtoNome [produtoNome.Count() - 1];
                quantidade = produtoQuantidade[produtoQuantidade.Count() - 1];
            }

            MessageBox.Show($"Nome: {nome}, Quantidade : {quantidade}");
        }

        void RemovePrimeiroNome()
        {
            produtoNome.RemoveAt(0);
            produtoQuantidade.RemoveAt(0);
            update();
        }

        // ----------------------- -------------------------------------- //

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            AdicionaProduto();
            update();
            limpaCampos();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void btnPrimeiroProduto_Click(object sender, EventArgs e)
        {
            verProdutos(true);
        }

        private void btnUltimoProduto_Click(object sender, EventArgs e)
        {
            verProdutos(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RemovePrimeiroNome();
        }
    }
}