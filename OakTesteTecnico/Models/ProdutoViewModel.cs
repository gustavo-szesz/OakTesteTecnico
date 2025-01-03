namespace OakTesteTecnico.Models
{
    public class ProdutoViewModel
    {
        #region Propriedades

        /// <summary>
        /// Identificador �nico do produto.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do produto.
        /// </summary>
        public string Nome { get; set; } = string.Empty;

        /// <summary>
        /// Descri��o do produto, uma string simples.
        /// </summary>
        public string Descricao { get; set; } = string.Empty;

        /// <summary>
        /// Valor do produto, est� em decimal.
        /// </summary>
        public decimal Valor { get; set; }

        /// <summary>
        /// Indica se o produto est� dispon�vel para venda.
        /// </summary>
        public bool DisponivelParaVenda { get; set; }

        #endregion
    }
}
