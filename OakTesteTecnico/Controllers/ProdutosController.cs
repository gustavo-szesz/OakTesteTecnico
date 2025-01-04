using Microsoft.AspNetCore.Mvc;
using OakTesteTecnico.Models;

namespace OakTesteTecnico.Controllers
{
    public class ProdutosController : Controller
    {
        #region Lista de Produtos exemplo
        /// <summary>
        /// Lista criada para simular um banco de dados, est� 
        /// hard-coded para facilitar a execu��o do projeto, � uma prova de conceito.
        /// </summary>
        private static List<ProdutoViewModel> produtos = new List<ProdutoViewModel>
            {
                new ProdutoViewModel { Id = 1, Nome = "Produto ex. 1", Descricao = "Descri��o 1", Valor = 10.0m, DisponivelParaVenda = true },
                new ProdutoViewModel { Id = 2, Nome = "Produto ex. 2", Descricao = "Descri��o 2", Valor = 20.0m, DisponivelParaVenda = false }
            };
        #endregion

        #region M�todos listar produtos em ordem crescente

        /// <summary>
        /// Exibe a lista de produtos ordenada pelo valor.
        /// </summary>
        /// <returns>Uma vis�o com a lista de produtos.</returns>
        public IActionResult Index()
        {
            return View(produtos.OrderBy(p => p.Valor).ToList());
        }
        #endregion

        #region M�todo Create (GET) - exibir formul�rio de cria��o
        /// <summary>
        /// Exibe o formul�rio de cria��o de um novo produto.
        /// </summary>
        /// <returns>Uma vis�o com o formul�rio de cria��o de produto.</returns>
        public IActionResult Create()
        {
            return View();
        }
        #endregion

        #region M�todo Create (POST) Inser��o.
        /// <summary>
        /// M�todo para criar um novo produto e adicionar na lista de produtos.
        /// </summary>
        /// <param name="produto">O modelo de dados do produto a ser criado.</param>
        /// <returns>Redireciona para a lista de produtos se bem-sucedido, caso contr�rio, retorna a vis�o de cria��o com erros de valida��o.</returns>
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
