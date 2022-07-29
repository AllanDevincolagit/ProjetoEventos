using Microsoft.EntityFrameworkCore;
using ProjetoEventos.Entidades;

namespace ProjetoEventos
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions options) : base(options) { }
        public DbSet<Usuario> USUARIO { get; set; }

        internal string? ToList()
        {
            throw new NotImplementedException();
        }
    }
}
