using ECommerceAPI.Context;
using ECommerceAPI.Interfaces;
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

        [HttpGet()]
        public IActionResult ListarTodos()
        {
            return Ok(_itemPedidoRepository.ListarTodos());
        }
    }
}
