using API_Administradores.ModelViews;
using Microsoft.AspNetCore.Mvc;


namespace API_Administradores.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        public HomeView Index()
        {
            return new HomeView(); 
        }
    }
}
