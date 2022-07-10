using GerenciamentoContato.Models;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoContato.Data
{
    public class Contexto: DbContext
     {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Contato> Contato { get; set; }

    }
}
