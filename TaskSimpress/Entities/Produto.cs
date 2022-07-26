using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioSimpress.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

        public bool Perecivel { get; set; }

        public int CategoriaId { get; set; }

        public CategoriaProduto categoria { get; set; }
    }
}
