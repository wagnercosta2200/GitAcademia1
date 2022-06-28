using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioVendas
{
    internal class Produto
    {
        private int idProduto;
        private string codEAN;
        private string nome;
        private decimal preco;
        private int estoque;

        public int IdProduto { get => idProduto; set => idProduto = value; }
        public string CodEAN { get => codEAN; set => codEAN = value; }
        public string Nome { get => nome; set => nome = value; }
        public decimal Preco { get => preco; set => preco = value; }
        public int Estoque { get => estoque; set => estoque = value; }

        public Produto(int idProduto, string codEAN, string nome, decimal preco, int estoque)
        {
            this.IdProduto = idProduto;
            this.CodEAN = codEAN;
            this.Nome = nome;
            this.Preco = preco;
            this.Estoque = estoque;
        }
    }
}
