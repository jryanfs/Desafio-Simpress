using DesafioSimpress.Repositories.Interface;
using DesafioSimpress.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace TaskSimpress.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ILogger<ProdutoController> _logger;
        private readonly ICategoriaProdutoRepository _categoriaProdutoRepository;
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(ILogger<ProdutoController> logger,
            ICategoriaProdutoRepository categoriaProdutoRepository,
            IProdutoRepository produtoRepository)
        {
            _logger = logger;
            _categoriaProdutoRepository = categoriaProdutoRepository;
            _produtoRepository = produtoRepository;
        }

        public IActionResult Index()
        {
            ProdutoViewModel model = new ProdutoViewModel();
            var categorias = _categoriaProdutoRepository.GetAll();

            model.Dropdown = categorias.Select(x => new SelectListItem { Text = x.Nome, Value = x.Id.ToString() }).ToList();
            model.Produtos = _produtoRepository.GetAll();

            return View(model);
        }

        public JsonResult GetProduto(int id) {

            var produto = _produtoRepository.Get(id);

            return Json(produto);
        }

        public IActionResult Save(ProdutoViewModel produtoViewModel)
        {
            if(produtoViewModel.Id == 0)
                _produtoRepository.Add(produtoViewModel.ToProduto());
            else
                _produtoRepository.Update(produtoViewModel.ToProduto());

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id) 
        {
            var produto = _produtoRepository.Get(id);

            _produtoRepository.Delete(produto);
            return RedirectToAction(nameof(Index));
        }
    }
}
