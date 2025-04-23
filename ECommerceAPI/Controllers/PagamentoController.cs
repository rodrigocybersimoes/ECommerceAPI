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
    public class PagamentoController : ControllerBase
    {
        private IPagamentoRepository _pagamentoRepository;
        public PagamentoController(IPagamentoRepository pagamentoRepository)
        {
            _pagamentoRepository = pagamentoRepository;
        }

        [HttpPost]
        public IActionResult CadastrarPagamento(Pagamento pag)
        {
            _pagamentoRepository.Cadastrar(pag);
                 
            return Created();
        }

        [HttpGet("{id}")]

        public IActionResult ListarPorId(int id)
        {
            Pagamento pagamento = _pagamentoRepository.BuscarPorId(id);

            if (pagamento == null)
            {
                return NotFound();
            }
            
            return Ok(pagamento);
        }

        [HttpPut("{id}")]
        public IActionResult Editar(int id, Pagamento pag)
        {
            try
            {
                _pagamentoRepository.Atualizar(id, pag);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound("Pagamento não encontrado.");
            }
        }

        [HttpGet()]
        public IActionResult ListarTodos()
        {
            return Ok(_pagamentoRepository.ListarTodos());
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _pagamentoRepository.Deletar(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound("Pagamento não encontrado.");
            }
        }


    }
}
