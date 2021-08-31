using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace mvc_razor.Helpers
{
    public class LogadoAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (string.IsNullOrEmpty(filterContext.HttpContext.Request.Cookies["adm_logado"]))
            {
                filterContext.HttpContext.Response.Redirect("/login");
                return;
            }
            if(filterContext.Controller != null)
            {
                string usuarioLogado = filterContext.HttpContext.Request.Cookies["adm_logado_nome"];
                ((Controller)filterContext.Controller).TempData["usuarioLogado"] = usuarioLogado; 
            }

            base.OnActionExecuted(filterContext);
        }
    }
}
