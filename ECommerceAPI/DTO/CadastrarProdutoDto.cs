namespace ECommerceAPI.DTO
{
    public class CadastrarProdutoDto
    {
        public string? NomeProduto { get; set; }

        public string? Descricao { get; set; }

        public decimal? Preco { get; set; }

        public int? EstoqueDisponivel { get; set; }

        public string? CategoriaProduto { get; set; }

        public string? Imagem { get; set; }
    }
}
