﻿using ECommerceAPI.Context;
using ECommerceAPI.Interfaces;
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
    }
}
