using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TesteConexaoGoDaddy.Models
{
    public class EFContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Estado> Estados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
    
}