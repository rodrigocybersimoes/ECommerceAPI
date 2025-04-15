using ECommerceAPI.Context;
using ECommerceAPI.Interfaces;
using ECommerceAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {
        private IPagamentoRepository _pagamentoRepository;
        public PagamentoController(IPagamentoRepository pagamentoRepository)
        {
            _pagamentoRepository = pagamentoRepository;
        }

        // 1. DEFINIR O VERBO
        [HttpGet()]
        //2. DEFINIR O RETORNO
        public IActionResult ListarTodos()
        {
            return Ok(_pagamentoRepository.ListarTodos());
        }


    }
}
