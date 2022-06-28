using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioVendas
{
    internal class Cliente
    {
        private int idcliente;
        private string cpf;
        private string nome;
        private string telefone;
        private string email;

        public int Idcliente { get => idcliente; set => idcliente = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }

        public Cliente(int idcliente, string cpf, string nome, string telefone, string email)
        {
            this.idcliente = idcliente;
            this.cpf = cpf;
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
        }
    }
}
