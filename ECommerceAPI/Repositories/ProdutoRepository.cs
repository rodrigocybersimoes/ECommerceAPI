using ECommerceAPI.Context;
using ECommerceAPI.Interfaces;
using ECommerceAPI.Models;

namespace ECommerceAPI.Repositories
{
    // NOS REPOSITORIOS FICAM OS METODOS QUE ACESSAM O BANCO DE DADOS
    public class ProdutoRepository : IProdutoRepository
    {
        // INJETAR O CONTEXT
        // INJECAO DE DEPENDENCIA (PEGAR UMA CLASSE E COLOCAR DENTRO DE OUTRA)
        private readonly EcommerceContext _context; // Objeto chamado _context
        
        // METODO CONSTRUTOR - QUANDO CRIAR UM OBJETO, O QUE EU PRECISO TER? E O METODO CONSTRUTOR QUEM DEFINE.
        public ProdutoRepository(EcommerceContext context) // METODO CONSTRUTOR: criado com o comando ctor
        {
            _context = context;
        }
        // Toda essa parte acima e a INJECAO DE DEPENDENCIA

        public void Atualizar(int id, Produto produto)
        {
            throw new NotImplementedException();
        }

        public Produto BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Produto produto)
        {
            _context.Produtos.Add(produto);
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Produto> ListarTodos()
        {
            return _context.Produtos.ToList();
        }
    }
}
