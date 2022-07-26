using DesafioSimpress.Data;
using DesafioSimpress.Entities;
using DesafioSimpress.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DesafioSimpress.Repositories
{
    public class CategoriaProdutoRepository : ICategoriaProdutoRepository
    {
        private readonly ProdutoStoreContext _context;

        public CategoriaProdutoRepository(ProdutoStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<CategoriaProduto> GetAll() 
        {
            return _context.CategoriaProduto.AsNoTracking();
        }

    }
}
