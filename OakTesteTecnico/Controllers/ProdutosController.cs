using Microsoft.AspNetCore.Mvc;
using OakTesteTecnico.Models;

namespace OakTesteTecnico.Controllers
{
    public class ProdutosController : Controller
    {
        private static List<ProdutoViewModel> produtos = new List<ProdutoViewModel>
        {
            new ProdutoViewModel { Id = 1, Nome = "Produto 1", Descricao = "Descrição 1", Valor = 10.0m, DisponivelParaVenda = true },
            new ProdutoViewModel { Id = 2, Nome = "Produto 2", Descricao = "Descrição 2", Valor = 20.0m, DisponivelParaVenda = false }
        };

        public IActionResult Index()
        {
            return View(produtos.OrderBy(p => p.Valor).ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                produto.Id = produtos.Max(p => p.Id) + 1;
                produtos.Add(produto);
                return RedirectToAction(nameof(Index));
            }
            return View(produto);
        }
    }
}
