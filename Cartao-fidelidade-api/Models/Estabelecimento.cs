using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cartao_fidelidade_api.Models
{
    public class Estabelecimento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

        public List<CartaoFidelidade> CartaoFidelidades { get; set; }

    }
}
