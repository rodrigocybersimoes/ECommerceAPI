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
            Cliente clienteRegistro = _context.Clientes.Find(id);

            if (clienteRegistro == null)
            {
                throw new Exception();
            }

            clienteRegistro.NomeCompleto = cliente.NomeCompleto;
            clienteRegistro.Email = cliente.Email;
            clienteRegistro.Telefone = cliente.Telefone;
            clienteRegistro.Endereco = cliente.Endereco;
            clienteRegistro.DataCadastro = cliente.DataCadastro;

        }

        public Cliente BuscarPorEmailSenha(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public Cliente BuscarPorId(int id)
        {
            return _context.Clientes.FirstOrDefault(p => p.Idcliente == id);
        }

        public void Cadastrar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);

            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            // 1. Encontrar quem quero excluir
            Cliente clienteEcontrado = _context.Clientes.Find(id); // O Find so procura pela chave primaria

            // 2. Tratar; se informar um id que nao existe mostra um erro
            if (clienteEcontrado == null)
            {
                throw new Exception();
            }

            // 3. Excluir o produto
            _context.Clientes.Remove(clienteEcontrado);

            // 4. Salvando a alteracao
            _context.SaveChanges();
        }

        public List<Cliente> ListarTodos()
        {
            return _context.Clientes.ToList();
        }
    }
}
 
