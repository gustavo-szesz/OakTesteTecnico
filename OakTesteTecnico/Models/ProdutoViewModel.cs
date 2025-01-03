namespace OakTesteTecnico.Models
{
    public class ProdutoViewModel
    {
        #region Propriedades

        /// <summary>
        /// Identificador único do produto.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do produto.
        /// </summary>
        public string Nome { get; set; } = string.Empty;

        /// <summary>
        /// Descrição do produto, uma string simples.
        /// </summary>
        public string Descricao { get; set; } = string.Empty;

        /// <summary>
        /// Valor do produto, está em decimal.
        /// </summary>
        public decimal Valor { get; set; }

        /// <summary>
        /// Indica se o produto está disponível para venda.
        /// </summary>
        public bool DisponivelParaVenda { get; set; }

        #endregion
    }
}
