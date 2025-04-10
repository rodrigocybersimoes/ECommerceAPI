using ECommerceAPI.Models;

namespace ECommerceAPI.Interfaces
{
    public interface IPagamentoRepository
    {
        // R - READ (Leitura)
        // Retorno
        List<Pagamento> ListarTodos();

        // RECEBE UM IDENTIFICADOR E RETORNA O PRODUTO CORRESPONDENTE (Leitura)
        Pagamento BuscarPorId(int id);

        // C - CREATE (Cadastro)
        void Cadastrar(Pagamento pagamento);

        // U - ATUALIZAR (Coloco quem quero atualizar e qual sera o novo produto que vai substituir o antigo)
        void Atualizar(int id, Pagamento pagamento);

        // D - Deletar
        // Recebo o identificador dr quem quero excluir
        void Deletar(int id);
    }
}
