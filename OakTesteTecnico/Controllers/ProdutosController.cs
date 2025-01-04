using Microsoft.AspNetCore.Mvc;
using OakTesteTecnico.Models;

namespace OakTesteTecnico.Controllers
{
    public class ProdutosController : Controller
    {
        #region Lista de Produtos exemplo
        /// <summary>
        /// Lista criada para simular um banco de dados, está 
        /// hard-coded para facilitar a execução do projeto, é uma prova de conceito.
        /// </summary>
        private static List<ProdutoViewModel> produtos = new List<ProdutoViewModel>
            {
                new ProdutoViewModel { Id = 1, Nome = "Produto ex. 1", Descricao = "Descrição 1", Valor = 10.0m, DisponivelParaVenda = true },
                new ProdutoViewModel { Id = 2, Nome = "Produto ex. 2", Descricao = "Descrição 2", Valor = 20.0m, DisponivelParaVenda = false }
            };
        #endregion

        #region Métodos listar produtos em ordem crescente

        /// <summary>
        /// Exibe a lista de produtos ordenada pelo valor.
        /// </summary>
        /// <returns>Uma visão com a lista de produtos.</returns>
        public IActionResult Index()
        {
            return View(produtos.OrderBy(p => p.Valor).ToList());
        }
        #endregion

        #region Método Create (GET) - exibir formulário de criação
        /// <summary>
        /// Exibe o formulário de criação de um novo produto.
        /// </summary>
        /// <returns>Uma visão com o formulário de criação de produto.</returns>
        public IActionResult Create()
        {
            return View();
        }
        #endregion

        #region Método Create (POST) Inserção.
        /// <summary>
        /// Método para criar um novo produto e adicionar na lista de produtos.
        /// </summary>
        /// <param name="produto">O modelo de dados do produto a ser criado.</param>
        /// <returns>Redireciona para a lista de produtos se bem-sucedido, caso contrário, retorna a visão de criação com erros de validação.</returns>
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
        #endregion

    }
}
