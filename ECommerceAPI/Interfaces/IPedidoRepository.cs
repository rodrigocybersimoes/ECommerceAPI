using ECommerceAPI.Models;

namespace ECommerceAPI.Interfaces
{
    public interface IPedidoRepository
    {
        // R - READ (Leitura)
        // Retorno
        List<Pedido> ListarTodos();

        // RECEBE UM IDENTIFICADOR E RETORNA O PRODUTO CORRESPONDENTE (Leitura)
        Pedido BuscarPorId(int id);

        // C - CREATE (Cadastro)
        void Cadastrar(Pedido pedido);

        // U - ATUALIZAR (Coloco quem quero atualizar e qual sera o novo produto que vai substituir o antigo)
        void Atualizar(int id, Pedido pedido);

        // D - Deletar
        // Recebo o identificador dr quem quero excluir
        void Deletar(int id);
    }
}
