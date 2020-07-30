using Cartao_fidelidade_api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cartao_fidelidade_api.Data
{
    public class Repository : IRepository
    {
        Context _context;
        public Repository(Context context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
        public async Task<Estabelecimento[]> GetEstabelecimentosAsync()
        {
            return await _context.Estabelecimentos.Include(e => e.CartaoFidelidades).ToArrayAsync();
        }

        public async  Task<CartaoFidelidade[]> GetCartaoFidelidadesByEstabelecimentoIdAsync(int estabelecimentoId)
        {
            return await _context.CartaoFidelidades.Where(c => c.EstabelecimentoId == estabelecimentoId).ToArrayAsync();
        }

        public async Task<Estabelecimento> GetEstabelecimentoById(int estabelecimentoId)
        {
            return await _context.Estabelecimentos.Include(e => e.CartaoFidelidades).FirstOrDefaultAsync(e => e.Id == estabelecimentoId);
        }

        public async Task<CartaoFidelidade> GetCartaoFidelidadeById(int cartaoFidelidadeId)
        {
            return await _context.CartaoFidelidades.FirstOrDefaultAsync(c => c.Id == cartaoFidelidadeId);
        }
    }
}
