using Microsoft.EntityFrameworkCore;
using ProjetoEventos.Entidades;

namespace ProjetoEventos
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions options) : base(options) { }
        public DbSet<Usuario> USUARIO { get; set; }
        public DbSet<Permissoes> PERMISSOES { get; set; }
        public DbSet<Usuario_Permissoes> USUARIO_PERMISSOES { get; set; }
        
         
    }
}
