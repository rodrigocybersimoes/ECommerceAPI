using ECommerceAPI.Context;
using ECommerceAPI.DTO;
using ECommerceAPI.Interfaces;
using ECommerceAPI.Models;
using ECommerceAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private IProdutoRepository _produtoRepository;

        // INJECAO DE DEPENDENCIA
        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        // Listar na internet e chamado de GET, padrao da internet.
        // CADASTRAR PRODUTO
        [HttpPost]
        public IActionResult CadastrarProduto(CadastrarProdutoDto prod)
        {
            // 1. Coloco o produto no BD
            _produtoRepository.Cadastrar(prod);

            // 2. Retornar um resultado
                // 201 - Created - codigo que informa que algo foi criado
            return Created();
        }

        // 1. Buscar produto por id - /api/produtos/1 <-- id
        [HttpGet("{id}")]
        
        // 2. Criar a funcao IActionResult
        public IActionResult ListarPorId(int id)
        {
            // 3. Criando a variavel para receber o id envido
            Produto produto = _produtoRepository.BuscarPorId(id);

            // 4. Caso o produto nao seja encontrado mostrar o erro 404 - Not Found
            if (produto == null) 
            { 
                return NotFound();
            }
            // Quando o produto e encontrado
            return Ok(produto);
        }

        [HttpPut("{id}")]
        public IActionResult Editar(int id, Produto prod)
        {
            try
            {
                _produtoRepository.Atualizar(id, prod);
                return Ok();
            }
            catch (Exception ex) 
            {
                return NotFound("Produto nao encontrado.");
            }
        }

        [HttpGet] // Padrao da internet, obrigado a escrever esta linha para sites.
        public IActionResult ListarProdutos()
        {
            return Ok(_produtoRepository.ListarTodos());
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id) 
        {
            try
            {
                _produtoRepository.Deletar(id);
                // 204 - Deu certo
                return NoContent();
            }
            // Caso de erro
            catch (Exception ex) 
            {
                return NotFound("Produto nao encontrado");
            }
        }
    }
}
