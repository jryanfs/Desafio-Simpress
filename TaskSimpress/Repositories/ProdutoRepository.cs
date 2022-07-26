using DesafioSimpress.Data;
using DesafioSimpress.Entities;
using DesafioSimpress.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DesafioSimpress.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ProdutoStoreContext _context;

        public ProdutoRepository(ProdutoStoreContext context)
        {
            _context = context;
        }

        public void Add(Produto produto) {
            _context.Add(produto);
            _context.SaveChanges();
        }

        public void Save(Produto produto)
        {
            _context.Update(produto);
            _context.SaveChanges();
        }

        public IEnumerable<Produto> GetAll()
        {
            return _context.Set<Produto>()
                .Include(x => x.categoria)
                .AsNoTracking();
        }

        public Produto Get(int id)
        {
            return _context.Set<Produto>()
                .Include(x => x.categoria)
                .FirstOrDefault(x => x.Id == id);
        }

        public void Delete(Produto produto)
        {
            _context.Remove(produto);
            _context.SaveChanges();
        }
    }
}
