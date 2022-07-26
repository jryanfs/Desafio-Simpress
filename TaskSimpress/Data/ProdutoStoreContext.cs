using DesafioSimpress.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioSimpress.Data
{
    public class ProdutoStoreContext : DbContext
    {
        public ProdutoStoreContext(DbContextOptions<ProdutoStoreContext> options): base(options) { 
            
        }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<CategoriaProduto> CategoriaProduto { get; set; }
    }
}
