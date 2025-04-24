using ECommerceAPI.DTO;
using ECommerceAPI.Models;

namespace ECommerceAPI.Interfaces
{
    public interface IClienteRepository
    {
        // R - READ (Leitura)
        // Retorno
        List<Cliente> ListarTodos();

        // RECEBE UM IDENTIFICADOR E RETORNA O PRODUTO CORRESPONDENTE (Leitura)
        Cliente BuscarPorId(int id);
        Cliente? BuscarPorEmailSenha(string email, string senha);

        // C - CREATE (Cadastro)
        void Cadastrar(CadastrarClientesDto cliente);

        // U - ATUALIZAR (Coloco quem quero atualizar e qual sera o novo produto que vai substituir o antigo)
        void Atualizar(int id, Cliente cliente);

        // D - Deletar
        // Recebo o identificador dr quem quero excluir
        void Deletar(int id);

        List<Cliente> BuscarClientePorNome(string nome);
    }
}
