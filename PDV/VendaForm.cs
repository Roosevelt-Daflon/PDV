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
    public partial class VendaForm : Form
    {
        private readonly Venda _venda;
        public VendaForm(Venda venda)
        {
            InitializeComponent();
            _venda = venda;
            CarregaProdutos();
            CarregaProdutos();
            textBox1.Text = @$"Venda: {venda.Codigo}
Total de produtos: {venda.Produtos.Count} 
Total da venda: {venda.Valor}R$ 
Data: {venda.Data}";
        }

        public void CarregaProdutos()
        {
            dataGridView1.Rows.Clear();


            foreach (var produto in _venda.Produtos)
            {
                dataGridView1.Rows.Add(produto.Codigo, produto.Nome, produto.Preco);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
