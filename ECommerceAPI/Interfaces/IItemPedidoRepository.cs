using ECommerceAPI.Models;

namespace ECommerceAPI.Interfaces
{
    public interface IItemPedidoRepository
    {
        // R - READ (Leitura)
        // Retorno
        List<ItemPedido> ListarTodos();

        // RECEBE UM IDENTIFICADOR E RETORNA O PRODUTO CORRESPONDENTE (Leitura)
        ItemPedido BuscarPorId(int id);

        // C - CREATE (Cadastro)
        void Cadastrar(ItemPedido itemPedido);

        // U - ATUALIZAR (Coloco quem quero atualizar e qual sera o novo produto que vai substituir o antigo)
        void Atualizar(int id, ItemPedido itemPedido);

        // D - Deletar
        // Recebo o identificador dr quem quero excluir
        void Deletar(int id);
    }
}
