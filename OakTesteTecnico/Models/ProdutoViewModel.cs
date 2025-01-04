using System.ComponentModel.DataAnnotations;

namespace OakTesteTecnico.Models
{
    #region Model ProdutoViewModel (Id, Nome, Descricao, Valor, DisponivelParaVenda)
    public class ProdutoViewModel
    {
        /// <summary>
        /// Identificador �nico do produto.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do produto.
        /// </summary>
        [Required(ErrorMessage = "O campo Nome � obrigat�rio.")]
        public required string Nome { get; set; }

        /// <summary>
        /// Descri��o do produto, uma string simples.
        /// </summary>
        [Required(ErrorMessage = "O campo Descri��o � obrigat�rio.")]
        public required string Descricao { get; set; }

        /// <summary>
        /// Valor do produto, est� em decimal.
        /// </summary>
        [Required(ErrorMessage = "O campo Valor � obrigat�rio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor deve ser maior que zero.")]
        public decimal? Valor { get; set; }

        /// <summary>
        /// Indica se o produto est� dispon�vel para venda.
        /// </summary>
        public required bool DisponivelParaVenda { get; set; }
    }
    #endregion
}
