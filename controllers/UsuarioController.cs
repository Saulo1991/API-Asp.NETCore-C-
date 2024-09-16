using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyNewApi.Models;

namespace SistemaDeTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<UsuarioController>> BuscarTodosUsuarios()
        {
            return Ok();
        }
    }
}
