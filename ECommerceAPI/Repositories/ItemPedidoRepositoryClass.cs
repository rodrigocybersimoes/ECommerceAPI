using ECommerceAPI.Context;
using ECommerceAPI.DTO;
using ECommerceAPI.Interfaces;
using ECommerceAPI.Models;

namespace ECommerceAPI.Repositories
{
    public class ItemPedidoRepository : IItemPedidoRepository
    {
        private readonly EcommerceContext _context;
        public ItemPedidoRepository(EcommerceContext context)
        {
            _context = context;
        }

        public void Atualizar(int id, ItemPedido itemPedido)
        {
            ItemPedido itemPedidoCadastro = _context.ItemPedidos.Find();

            if (itemPedidoCadastro == null)
            {
                throw new Exception();
            }

            itemPedidoCadastro.IditemPedido = itemPedido.IditemPedido;
            itemPedidoCadastro.Quantidade = itemPedido.Quantidade;
            itemPedidoCadastro.Idproduto = itemPedido.Idproduto;
            itemPedidoCadastro.Idpedido = itemPedido.Idpedido;
        }

        public ItemPedido BuscarPorId(int id)
        {
            return _context.ItemPedidos.FirstOrDefault(p => p.IditemPedido == id);
        }

        public void Cadastrar(CadastrarItemPedidoDto itemPedido)
        {
            ItemPedido itemPedidoCadastro = new ItemPedido
            {
                Quantidade = itemPedido.Quantidade,
                Idproduto = itemPedido.Idproduto,
                Idpedido = itemPedido.Idpedido,
            };

            _context.ItemPedidos.Add(itemPedidoCadastro);

            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            
            ItemPedido itemPedidoEcontrado = _context.ItemPedidos.Find(id);

            if (itemPedidoEcontrado == null)
            {
                throw new Exception();
            }

            _context.ItemPedidos.Remove(itemPedidoEcontrado);

            _context.SaveChanges();
        }

        public List<ItemPedido> ListarTodos()
        {
            return _context.ItemPedidos.ToList();
        }

    }
}
