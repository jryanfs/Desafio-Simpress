using DesafioSimpress.Entities;
using System.Collections.Generic;

namespace DesafioSimpress.Repositories.Interface
{
    public interface IProdutoRepository 
    {
        public void Add(Produto produto);

        public IEnumerable<Produto> GetAll();

        public Produto Get(int id);

        public void Save(Produto produto);

        public void Delete(Produto produto);
    }
}
