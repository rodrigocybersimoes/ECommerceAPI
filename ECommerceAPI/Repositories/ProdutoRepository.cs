using ECommerceAPI.Context;
using ECommerceAPI.Interfaces;
using ECommerceAPI.Models;
using Microsoft.AspNetCore.Http.Connections;

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
            // 1. Achar o produto
            Produto produtoRegistro = _context.Produtos.Find(id);

            // 2. Caso me forneca um id que nao existe, mostrar um erro
            if (produtoRegistro == null) 
            {
                throw new Exception();
            }

            // 3. Realizar as possiveis alteracoes
            produtoRegistro.Descricao = produto.Descricao;
            produtoRegistro.Preco = produto.Preco;
            produtoRegistro.CategoriaProduto = produto.CategoriaProduto;
            produtoRegistro.Imagem = produto.Imagem;
            produtoRegistro.EstoqueDisponivel = produto.EstoqueDisponivel;

            // 4. Salvar as alteracoes
            _context.SaveChanges();


        }

        public Produto BuscarPorId(int id)
        {
            return _context.Produtos.FirstOrDefault(p => p.Idproduto == id);
        }

        public void Cadastrar(Produto produto)
        {
            _context.Produtos.Add(produto);

            // Salvar a alteracao
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            // 1. Encontrar quem quero excluir
            Produto produtoEcontrado = _context.Produtos.Find(id); // O Find so procura pela chave primaria

            // 2. Tratar; se informar um id que nao existe mostra um erro
            if (produtoEcontrado == null) 
            {
                throw new Exception();
            }
            
            // 3. Excluir o produto
            _context.Produtos.Remove(produtoEcontrado);

            // 4. Salvando a alteracao
            _context.SaveChanges();
        
        }

        public List<Produto> ListarTodos()
        {
            //ToList() - Pegar varios
            return _context.Produtos.ToList();
        }
    }
}
