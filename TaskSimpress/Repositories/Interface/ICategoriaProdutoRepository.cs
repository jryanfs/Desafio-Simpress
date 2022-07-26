using DesafioSimpress.Entities;
using System.Collections.Generic;

namespace DesafioSimpress.Repositories.Interface
{
    public interface ICategoriaProdutoRepository 
    {
        public IEnumerable<CategoriaProduto> GetAll();
    }
}
