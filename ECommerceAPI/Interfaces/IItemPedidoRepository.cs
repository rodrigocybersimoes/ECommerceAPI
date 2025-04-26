using ECommerceAPI.DTO;
using ECommerceAPI.Models;

namespace ECommerceAPI.Interfaces
{
    public interface IItemPedidoRepository
    {
        List<ItemPedido> ListarTodos();

        ItemPedido BuscarPorId(int id);

        void Cadastrar(CadastrarItemPedidoDto itemPedido);

        void Atualizar(int id, ItemPedido itemPedido);

        void Deletar(int id);
    }
}
