using DesafioSimpress.Entities;
using Microsoft.EntityFrameworkCore;
using TaskSimpress.Entities.Mapeamento;

namespace DesafioSimpress.Data
{
    public class ProdutoStoreContext : DbContext
    {
        public ProdutoStoreContext(DbContextOptions<ProdutoStoreContext> options): base(options) { 
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation","pt_BR.UTF-8");

            modelBuilder.ApplyConfiguration(new MapeamentoProduto());
            modelBuilder.ApplyConfiguration(new MapeamentoCategoriaProduto());
        }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<CategoriaProduto> CategoriaProduto { get; set; }
    }
}
