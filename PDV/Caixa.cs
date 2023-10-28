using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDV.Models;

namespace PDV
{
    public partial class Caixa : Form
    {

        public List<Produto> ProdutosVenda = new List<Produto>();
        public List<Produto> Produtos = new List<Produto>();
        public bool VendaRealiada = false;
        public Caixa(List<Produto> produtos)
        {
            InitializeComponent();
            Produtos = produtos;
            CarregaProdutos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gridProdutos.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = gridProdutos.SelectedRows[0];

                int valorDaColuna1 = Convert.ToInt32(selectedRow?.Cells["codigo"]?.Value);

                var produto = Produtos.FirstOrDefault(x => x.Codigo == valorDaColuna1);
                if (produto == null) return;

                if (produto.QuantidadeEmEstoque <= 0)
                {
                    MessageBox.Show($"Produto {valorDaColuna1} sem estoque");
                    return;
                }
                produto.QuantidadeEmEstoque--;
                produto.DataUltimaVenda = DateTime.Now;
                ProdutosVenda.Add(produto);
                CarregaProdutos();
                CarregaProdutosVedna();
            }
            else
            {
                MessageBox.Show($"Por Favor Selecione um produto primeiro");
            }
        }

        public void CarregaProdutos()
        {
            gridProdutos.Rows.Clear();

            foreach (var produto in Produtos)
            {
                gridProdutos.Rows.Add(produto.Codigo, produto.Nome, produto.Preco, produto.Unidade, produto.QuantidadeEmEstoque, produto.DataUltimaVenda);
            }
        }

        public void CarregaProdutosVedna()
        {
            gridProdutosVenda.Rows.Clear();

            foreach (var produto in ProdutosVenda)
            {
                gridProdutosVenda.Rows.Add(produto.Codigo, produto.Nome, produto.Preco, produto.Unidade, produto.QuantidadeEmEstoque);
            }
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            VendaRealiada = true;
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
