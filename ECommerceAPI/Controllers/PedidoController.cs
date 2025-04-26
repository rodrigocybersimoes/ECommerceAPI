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
    public class PedidoController : ControllerBase
    {
        private IPedidoRepository _pedidoRepository;
        public PedidoController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        [HttpPost]

        public IActionResult CadastrarPedido(CadastrarPedidoDto ped)
        {
            _pedidoRepository.Cadastrar(ped);

            return Created();
        }

        [HttpGet("{id}")]

        // 2. Criar a funcao IActionResult
        public IActionResult ListarPorId(int id)
        {
            // 3. Criando a variavel para receber o id envido
            Pedido pedido = _pedidoRepository.BuscarPorId(id);

            // 4. Caso o produto nao seja encontrado mostrar o erro 404 - Not Found
            if (pedido == null)
            {
                return NotFound();
            }
            // Quando o produto e encontrado
            return Ok(pedido);
        }

        [HttpPut("{id}")]
        public IActionResult Editar(int id, Pedido ped)
        {
            try
            {
                _pedidoRepository.Atualizar(id, ped);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound("Produto nao encontrado.");
            }
        }

        [HttpGet]
        public IActionResult ListarPedidos()
        {
            return Ok(_pedidoRepository.ListarTodos());
        }


        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _pedidoRepository.Deletar(id);
                
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound("Produto nao encontrado");
            }
        }

    }
}
