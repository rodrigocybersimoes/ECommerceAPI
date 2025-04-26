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
    public class ItemPedidoController : ControllerBase
    {
        private IItemPedidoRepository _itemPedidoRepository;
        public ItemPedidoController(IItemPedidoRepository itemPedidoRepository)
        {
            _itemPedidoRepository = itemPedidoRepository;
        }

        [HttpPost]
        public IActionResult CadastrarItemPedido(CadastrarItemPedidoDto itemped)
        {
            // 1. Coloco o produto no BD
            _itemPedidoRepository.Cadastrar(itemped);

            // 2. Retornar um resultado
            // 201 - Created - codigo que informa que algo foi criado
            return Created();
        }

        [HttpGet("{id}")]

        // 2. Criar a funcao IActionResult
        public IActionResult ListarPorId(int id)
        {
            // 3. Criando a variavel para receber o id envido
            ItemPedido itemPedido = _itemPedidoRepository.BuscarPorId(id);

            // 4. Caso o produto nao seja encontrado mostrar o erro 404 - Not Found
            if (itemPedido == null)
            {
                return NotFound();
            }
            // Quando o produto e encontrado
            return Ok(itemPedido);
        }

        [HttpPut("{id}")]
        public IActionResult Editar(int id, ItemPedido ped)
        {
            try
            {
                _itemPedidoRepository.Atualizar(id, ped);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound("Produto nao encontrado.");
            }
        }

        [HttpGet]
        public IActionResult ListarItemPedido()
        {
            return Ok(_itemPedidoRepository.ListarTodos());
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _itemPedidoRepository.Deletar(id);
                
                return NoContent();
            }
            
            catch (Exception ex)
            {
                return NotFound("Produto nao encontrado");
            }
        }

    }
}
