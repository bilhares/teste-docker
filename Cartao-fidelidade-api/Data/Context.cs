using Cartao_fidelidade_api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cartao_fidelidade_api.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Estabelecimento> Estabelecimentos { get; set; }
        public DbSet<CartaoFidelidade> CartaoFidelidades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ControlePontos> ControlePontos { get; set; }
    }
}
