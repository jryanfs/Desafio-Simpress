using DesafioSimpress.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace DesafioSimpress.ViewModel
{
    public class ProdutoViewModel
    {
        public int Id { get; set; }
        public List<SelectListItem> Dropdown { get; set; }
        public int CategoriaId { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }
        public bool Perecivel { get; set; }

        public IEnumerable<Produto> Produtos { get; set; }

        public Produto ToProduto()
        {
            return new Produto
            {
                Id = Id,
                CategoriaId = CategoriaId,
                Descricao = Descricao,
                Nome = Nome,
                Perecivel = Perecivel,
                Ativo = true,
            };
        }
    }
}
