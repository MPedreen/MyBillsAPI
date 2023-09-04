using Microsoft.AspNetCore.Mvc;

namespace MyBills.API.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ContasController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(201)]
        public async Task<IActionResult> Post()
            => StatusCode(201);
    }
}
