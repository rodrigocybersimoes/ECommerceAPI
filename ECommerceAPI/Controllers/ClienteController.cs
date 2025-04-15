using ECommerceAPI.Context;
using ECommerceAPI.Interfaces;
using ECommerceAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IClienteRepository _clienteRepository;
        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        [HttpGet()]
        public IActionResult ListarTodos()
        {
            return Ok(_clienteRepository.ListarTodos());
        }
    }
}
