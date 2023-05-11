using Microsoft.AspNetCore.Mvc;

namespace api.cuentas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperacionesController : Controller
    {
        string cadenaConeion = "";

        public OperacionesController(IConfiguration configuration)
        {
            cadenaConeion = configuration.GetConnectionString("PostgresDB");
        }

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
    }
}
