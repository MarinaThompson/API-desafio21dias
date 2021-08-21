using API_Alunos.ModelViews;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
