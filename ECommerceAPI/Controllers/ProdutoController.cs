using ECommerceAPI.Context;
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
        private readonly EcommerceContext _context;
        private IProdutoRepository _produtoRepository;
        public ProdutoController(EcommerceContext context)
        {
            _context = context;
            _produtoRepository = new ProdutoRepository(_context);
        }

        // Listar na internet e chamado de GET, padrao da internet.
        [HttpGet] // Padrao da internet, obrigado a escrever esta linha para sites.
        public IActionResult ListarProdutos()
        {
            return Ok(_produtoRepository.ListarTodos());
        }

        // CADASTRAR PRODUTO
        [HttpPost]
        public IActionResult CadastrarProduto(Produto prod)
        {
            // 1. Coloco o produto no BD
            _produtoRepository.Cadastrar(prod);

            // 2. Salvar a alteracao
            _context.SaveChanges();

            // 3. Retornar um resultado
                // 201 - Created - codigo que informa que algo foi criado
            return Created();
        }
    }
}
