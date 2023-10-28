using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Models
{
    public class Venda : Entidade
    {
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public List<Produto> Produtos { get; set; }

        public Venda(List<Produto> produtos)
        {
            var random = new Random();
            Codigo = random.Next(10000, 99999);
            Data = DateTime.Now;
            Valor = produtos.Sum(x => x.Preco);
            Produtos = produtos;
        }


    }
}
