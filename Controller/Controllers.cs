using Microsoft.AspNetCore.Mvc;
using API_Development.Controller;

namespace API_Development.Controllers
{
    public class APIController : ControllerBase
    {
        APP app = new APP();
        public IActionResult Index()
        {
            app.A();
            app.B();
            return Ok($"Point A is on the line = [ {app.isOnLineA} ]\nPoint B is on the line = [ {app.isOnLineB} ]");
        }
    }
}
