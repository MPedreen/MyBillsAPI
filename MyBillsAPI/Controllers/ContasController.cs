using Microsoft.AspNetCore.Mvc;
using MyBills.Application.Interfaces.Services;
using MyBills.Application.Models.Commands;
using MyBills.Application.Models.Queries;

namespace MyBills.API.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ContasController : ControllerBase
    {
        private readonly IContaAppService _contaAppService;

        public ContasController(IContaAppService contaAppService)
        {
            _contaAppService = contaAppService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(ContaQuery), 201)]
        public async Task<IActionResult> Post(ContaCreateCommand command)
            => StatusCode(201, await _contaAppService.Create(command));

        [HttpPut]
        [ProducesResponseType(typeof(ContaQuery), 200)]
        public async Task<IActionResult> Put(ContaUpdateCommand command)
            => StatusCode(200, await _contaAppService.Update(command));

        [HttpDelete]
        [ProducesResponseType(typeof(ContaQuery), 200)]
        public async Task<IActionResult> Delete(Guid? id)
        {
            var command = new ContaDeleteCommand { Id = id };
            return StatusCode(200, await _contaAppService.Delete(command));
        }

        //[HttpGet]
        //[ProducesResponseType(typeof(List<ContaQuery>), 200)]
        //public IActionResult GetAll()
        //    => StatusCode(200, _contaAppService.GetAll());
    }
}
