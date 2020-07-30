using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cartao_fidelidade_api.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public CartaoFidelidade CartaoFidelidade { get;  }
        public int CartaoFidelidadeId { get; set; }
        public List<ControlePontos> ControlePontos { get; set; }
    }
}
