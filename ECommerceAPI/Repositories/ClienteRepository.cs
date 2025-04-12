using ECommerceAPI.Context;
using ECommerceAPI.Interfaces;
using ECommerceAPI.Models;

// ORDEM DE PASSOS:
// 1. HERDAR DA INTERCE
// 2. SEGURAR O CONTROL E CLICAR INomeRepository e clica em "Implementar Interface"
// 3. INJETAR O CONTEXTO
// 4. 
// 5. 
// 6. 
// 7. 

namespace ECommerceAPI.Repositories
{//                                 2. Clicando em IClineteRepository segurando o cntrl e clicar em "Implementar a Interface"
    public class ClienteRepository : IClienteRepository // 1. HERDANDO DA INTERFACE
    {
        private readonly EcommerceContext _context; // 3. INJETANDO O CONTEXTO
        public ClienteRepository(EcommerceContext context) // METODO CONSTRUTOR
        {
            _context = context;
        }

        public void Atualizar(int id, Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente BuscarPorEmailSenha(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public Cliente BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> ListarTodos()
        {
            return _context.Clientes.ToList();
        }
    }
}
 
