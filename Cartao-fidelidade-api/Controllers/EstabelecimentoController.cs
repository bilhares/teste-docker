using System.Threading.Tasks;
using Cartao_fidelidade_api.Data;
using Cartao_fidelidade_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cartao_fidelidade_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstabelecimentoController : ControllerBase
    {
        private readonly IRepository _repository;

        public EstabelecimentoController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _repository.GetEstabelecimentosAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _repository.GetEstabelecimentoById(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Estabelecimento model)
        {
            _repository.Add(model);

            if(await _repository.SaveChangesAsync())
            {
                return Ok(model);
            }


            return BadRequest();
        }

    }
}