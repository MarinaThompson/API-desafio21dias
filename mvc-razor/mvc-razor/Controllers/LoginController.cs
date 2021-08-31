
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mvc_razor.Servico;
using System;
using System.Threading.Tasks;

namespace mvc_razor.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Logar(string email, string senha, string lembrar)
        {
            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                ViewBag.erro = "Digite o email e a senha"; 
            }
            else
            {
                var adm = await AdministradorServico.Logar(email, senha);
                if(adm != null)
                {
                    var expira = DateTimeOffset.UtcNow.AddHours(3);
                    if (!string.IsNullOrEmpty(lembrar)) expira = DateTimeOffset.UtcNow.AddYears(1);
                    this.HttpContext.Response.Cookies.Append("adm_logado", adm.Id.ToString(), new CookieOptions
                    {
                        Expires = expira,
                        HttpOnly = true
                    });

                    this.HttpContext.Response.Cookies.Append("adm_logado_nome", adm.Nome.ToString(), new CookieOptions
                    {
                        Expires = expira,
                        HttpOnly = true
                    });

                    Response.Redirect("/");                     
                }
                else
                {
                    ViewBag.erro = "Usuário ou senha inválidos"; 
                }
            }
            return View("Index"); 
        }

        public IActionResult Sair()
        {
            this.HttpContext.Response.Cookies.Append("adm_logado", "", new CookieOptions
            {
                Expires = DateTimeOffset.UtcNow.AddMinutes(-1),
                HttpOnly = true
            });

            this.HttpContext.Response.Cookies.Append("amd_logado_nome", "", new CookieOptions
            {
                Expires = DateTimeOffset.UtcNow.AddMinutes(-1),
                HttpOnly = true
            });
            return Redirect("/");
        }
    }
}
