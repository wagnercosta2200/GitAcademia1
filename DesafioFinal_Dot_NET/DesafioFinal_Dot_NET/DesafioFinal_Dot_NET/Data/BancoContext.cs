using DesafioFinal_Dot_NET.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioFinal_Dot_NET.Data
{
    //Construtor do banco de dados
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base(options)
        {

        }
        //cria a connexao com a tabela contatos
        public DbSet<ContatoModel> Contatos { get; set; }
    }


}
