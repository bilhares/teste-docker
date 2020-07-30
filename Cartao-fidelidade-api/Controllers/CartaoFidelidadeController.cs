using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cartao_fidelidade_api.Data;
using Cartao_fidelidade_api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cartao_fidelidade_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartaoFidelidadeController : ControllerBase
    {
        private readonly IRepository _repository;

        public CartaoFidelidadeController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new CartaoFidelidade());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _repository.GetCartaoFidelidadeById(id);
            return Ok(result);
        }

        [HttpGet("byEstabelecimento/{estabelecimentoId}")]
        public async Task<IActionResult> GetByEstabelecimento(int estabelecimentoId)
        {
            var result = await _repository.GetCartaoFidelidadesByEstabelecimentoIdAsync(estabelecimentoId);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CartaoFidelidade model)
        {
            _repository.Add(model);
            if (await _repository.SaveChangesAsync())
            {
                return Ok(model);
            }

            return BadRequest();
        }
    }
}