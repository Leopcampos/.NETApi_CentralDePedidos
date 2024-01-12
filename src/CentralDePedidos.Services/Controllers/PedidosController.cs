using Microsoft.AspNetCore.Mvc;

namespace CentralDePedidos.Services.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PedidosController : ControllerBase
{
    [HttpPost]
    public IActionResult Post()
    {
        return Ok();
    }
}