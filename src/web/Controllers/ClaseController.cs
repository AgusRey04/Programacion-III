using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;
using Application.Services;
namespace web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaseController : Controller
    {
       private readonly IClaseService _claseService;

       public ClaseController(IClaseService claseService)
        {
            _claseService = claseService;
        }

        [HttpGet]
        public IActionResult GetClases()
        {
            return Ok(_claseService.GetAll()); // Agregué el paréntesis de cierre
        }
    }
}
