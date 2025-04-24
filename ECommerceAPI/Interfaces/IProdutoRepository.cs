using ECommerceAPI.DTO;
using ECommerceAPI.Models;

namespace ECommerceAPI.Interfaces
{
    // AQUI EU SO MOSTRO O QUE OS METODOS VAO FAZER, E SO UM CONTRATO.
    public interface IProdutoRepository
    {
        // R - READ (Leitura)
        // Retorno
        List<Produto> ListarTodos();

        // RECEBE UM IDENTIFICADOR E RETORNA O PRODUTO CORRESPONDENTE (Leitura)
        Produto BuscarPorId(int id);

        // C - CREATE (Cadastro)
        void Cadastrar(CadastrarProdutoDto produto);

        // U - ATUALIZAR (Coloco quem quero atualizar e qual sera o novo produto que vai substituir o antigo)
        void Atualizar(int id, Produto produto);

        // D - Deletar
        // Recebo o identificador dr quem quero excluir
        void Deletar(int id);

    }
}
