using ECommerceAPI.Context;
using ECommerceAPI.DTO;
using ECommerceAPI.Interfaces;
using ECommerceAPI.Models;


namespace ECommerceAPI.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly EcommerceContext _context;
        public PedidoRepository(EcommerceContext context)
        {
            _context = context;
        }
        public void Atualizar(int id, Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public Pedido BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(CadastrarPedidoDto pedidoDto)
        {
            // Cadastrar o Pedido
            // Crio variavel pedido para guardar o que o pedido tem
       
            var pedido = new Pedido
            {
                DataPedido = pedidoDto.DataPedido,
                Status = pedidoDto.Status,
                Idcliente = pedidoDto.Idcliente,
                ValorTotal = pedidoDto.ValorTotal
            };

            _context.Pedidos.Add(pedido);

            _context.SaveChanges();

            // Cadastrar os ItensPedido
            // PARA (usar o FOR) cada PRODUTO, crio um ItemPedido

            for (int i = 0; i < pedidoDto.Produtos.Count; i++)
            {
                // Encontrando o produto
                var produto = _context.Produtos.Find(pedidoDto.Produtos[i]);

                // TODO: Lancar erro se produto nao existe.

                // Crio uma variavel itemPedido
                var itemPedido = new ItemPedido
                {
                    Idpedido = pedido.Idpedido,
                    Idproduto = pedido.Idproduto,
                    Quantidade = 0
                };

                // Joga o pedido no Banco de Dados
                _context.ItemPedidos.Add(itemPedido);

                // Salvo
                _context.SaveChanges();


            }
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pedido> ListarTodos()
        {
            return _context.Pedidos.ToList();
        }
    }
}
