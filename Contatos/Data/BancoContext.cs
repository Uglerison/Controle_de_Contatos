using Contatos.Models;
using Microsoft.EntityFrameworkCore;
namespace Contatos.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) { 
        }

        public DbSet<ContatoModel> TblContatos { get; set; }
        public DbSet<UsuarioModel> TblUsuarios { get; set; }
    }
}
