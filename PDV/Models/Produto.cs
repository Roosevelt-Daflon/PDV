using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Models
{
    public class Produto : Entidade
    {
        public string Nome { get; set; }
        public string Unidade { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        public DateTime DataUltimaVenda { get; set; }

        public Produto(int codigo, string nome, string unidade, decimal preco, int quantidadeEmEstoque)
        {
            Codigo = codigo;
            Nome = nome;
            Unidade = unidade;
            Preco = preco;
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }
    }
}
