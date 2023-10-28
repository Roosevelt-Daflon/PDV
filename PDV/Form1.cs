using PDV.Models;

namespace PDV
{
    public partial class Form1 : Form
    {
        public List<Venda> Vendas = new List<Venda>();
        public List<Produto> Produtos = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
            Produtos.Add(new(1, "Banana", "Kg", 5.99m, 10));
            Produtos.Add(new(2, "Coca Cola", "unidade", 10.99m, 20));

        }

        public void AdicionarVendas(Venda venda) => Vendas.Add(venda);

        private void btnVenda_Click(object sender, EventArgs e)
        {
            var caixa = new Caixa(Produtos);
            caixa.ShowDialog();
            if (caixa.VendaRealiada && caixa.ProdutosVenda.Count > 0)
            {
                AdicionarVendas(new(caixa.ProdutosVenda));
                Produtos = caixa.Produtos;
                CarregaProdutosVedna();
            }
        }

        public void CarregaProdutosVedna()
        {
            dataGridView1.Rows.Clear();

            foreach (var venda in Vendas)
            {
                dataGridView1.Rows.Add(venda.Codigo, venda.Valor, venda.Data, venda.Produtos.Count);
            }
        }

        private void btnDetalhe_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int valorDaColuna1 = Convert.ToInt32(selectedRow?.Cells["codigo"]?.Value);

                var venda = Vendas.FirstOrDefault(x => x.Codigo == valorDaColuna1);
                if (venda == null) return;
                VendaForm vendaForm = new VendaForm(venda);
                vendaForm.ShowDialog();

            }
            else
            {
                MessageBox.Show($"Por Favor Selecione um produto primeiro");
            }
        }
    }
}