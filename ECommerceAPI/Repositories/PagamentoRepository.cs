using ECommerceAPI.Context;
using ECommerceAPI.Interfaces;
using ECommerceAPI.Models;
using Microsoft.EntityFrameworkCore;

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
            Pagamento pagamentoRegistro = _context.Pagamentos.Find(id);

            if (pagamentoRegistro == null)
            {
                throw new Exception();
            }

            pagamentoRegistro.Idpagamento = pagamento.Idpagamento;
            pagamentoRegistro.DataPagamento = pagamento.DataPagamento;
            pagamentoRegistro.FormaPagamento = pagamento.FormaPagamento;
            pagamentoRegistro.StatusPagamento = pagamento.StatusPagamento;

            _context.SaveChanges();
        }

        public Pagamento BuscarPorId(int id)
        {
            return _context.Pagamentos.FirstOrDefault(p => p.Idpagamento == id);
        }

        public void Cadastrar(Pagamento pagamento)
        {
            _context.Pagamentos.Add(pagamento);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Pagamento pagamentoEcontrado = _context.Pagamentos.Find(id);

            if (pagamentoEcontrado == null)
            {
                throw new Exception();
            }

            _context.Pagamentos.Remove(pagamentoEcontrado);
            _context.SaveChanges();
        }

        public List<Pagamento> ListarTodos()
        {
            return _context.Pagamentos
                .Include(p => p.IdpedidoNavigation)
                .ToList();
        }
    }
}
