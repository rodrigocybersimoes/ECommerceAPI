﻿using ECommerceAPI.Context;
using ECommerceAPI.Interfaces;
using ECommerceAPI.Models;

namespace ECommerceAPI.Repositories
{
    public class PagamentoRepository : IPagamentoRepository
    {

        private readonly EcommerceContext _context;
        public PagamentoRepository(EcommerceContext context)
        {
            _context = context;
        }
        public void Atualizar(int id, Pagamento pagamento)
        {
            throw new NotImplementedException();
        }

        public Pagamento BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Pagamento pagamento)
        {
            _context.Pagamentos.Add(pagamento);
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pagamento> ListarTodos()
        {
            return _context.Pagamentos.ToList();
        }
    }
}
