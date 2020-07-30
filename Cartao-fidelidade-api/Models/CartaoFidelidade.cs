using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Cartao_fidelidade_api.Models
{
    public class CartaoFidelidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int QtdPontos { get; set; }
        public Estabelecimento Estabelecimento { get; set; }
        public int EstabelecimentoId { get; set; }
        public List<Cliente> Clientes { get; set; }

    }
}
