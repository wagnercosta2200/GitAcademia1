using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioVendas
{
    internal class Venda
    {
        private int idVenda;
        private int codigoCliente;
        private decimal valorTotal;

        public int IdVenda { get => idVenda; set => idVenda = value; }
        public int CodigoCliente { get => codigoCliente; set => codigoCliente = value; }
        public decimal ValorTotal { get => valorTotal; set => valorTotal = value; }

        public Venda(int idVenda, int codigoCliente, decimal valorTotal)
        {
            this.IdVenda = idVenda;
            this.CodigoCliente = codigoCliente;
            this.ValorTotal = valorTotal;
        }
    }
}
