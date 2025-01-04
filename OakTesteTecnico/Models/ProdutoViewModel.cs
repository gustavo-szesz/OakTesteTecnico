using System.ComponentModel.DataAnnotations;

namespace OakTesteTecnico.Models
{
    #region Model ProdutoViewModel (Id, Nome, Descricao, Valor, DisponivelParaVenda)
    public class ProdutoViewModel
    {
        /// <summary>
        /// Identificador único do produto.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do produto.
        /// </summary>
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public required string Nome { get; set; }

        /// <summary>
        /// Descrição do produto, uma string simples.
        /// </summary>
        [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
        public required string Descricao { get; set; }

        /// <summary>
        /// Valor do produto, está em decimal.
        /// </summary>
        [Required(ErrorMessage = "O campo Valor é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor deve ser maior que zero.")]
        public decimal? Valor { get; set; }

        /// <summary>
        /// Indica se o produto está disponível para venda.
        /// </summary>
        public required bool DisponivelParaVenda { get; set; }
    }
    #endregion
}
