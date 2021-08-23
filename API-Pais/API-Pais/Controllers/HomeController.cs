using API_Pais.ModelViews;
using Microsoft.AspNetCore.Mvc;


namespace API_Pais.Controllers
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
