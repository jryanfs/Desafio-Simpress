using TaskSimpress.Entities;

namespace DesafioSimpress.Entities
{
    public class Produto : Enti
    {
        public bool Perecivel { get; set; }

        public int CategoriaId { get; set; }

        public CategoriaProduto Categoria { get; set; }
    }
}
