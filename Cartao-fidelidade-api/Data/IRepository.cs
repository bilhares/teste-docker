using Cartao_fidelidade_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cartao_fidelidade_api.Data
{
    public interface IRepository
    {
        //Geral
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        //Estabelecimento
        Task<Estabelecimento[]> GetEstabelecimentosAsync();
        Task<Estabelecimento> GetEstabelecimentoById(int estabelecimentoId);

        //cartao 
        Task<CartaoFidelidade[]> GetCartaoFidelidadesByEstabelecimentoIdAsync(int estabelecimentoId);
        Task<CartaoFidelidade> GetCartaoFidelidadeById(int cartaoFidelidadeId);
        
    }
}
