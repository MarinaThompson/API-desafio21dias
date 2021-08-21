using API_Alunos.ModelViews;
using Microsoft.AspNetCore.Mvc;


namespace API_Alunos.Controllers
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
