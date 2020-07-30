using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cartao_fidelidade_api.Models
{
    public class ControlePontos
    {
        public int Id { get; set; }
        public Cliente Cliente { get;  }
        public int ClienteId { get; set; }
        public DateTime DataPontuacao { get; set; }
        public int pontos { get; set; }
    }
}
