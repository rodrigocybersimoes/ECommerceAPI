namespace ECommerceAPI.DTO
{
    // RECEBO OS DADOS DO PEDIDO E RECEBO OS PRODUTOS COMPRADOS
    public class CadastrarPedidoDto
    {
        public DateOnly? DataPedido { get; set; }

        public string? Status { get; set; }

        public decimal? ValorTotal { get; set; }

        public int? Idcliente { get; set; }

        // Produtos Comprados
        public List<int> Produtos { get; set; }
    }
}
