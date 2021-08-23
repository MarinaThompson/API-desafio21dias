using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Pais.ModelViews
{
    public record HomeView
    {
        public string Informacao => "Bem vindo ao sistema";
        public List<dynamic> Endpoints => new List<dynamic>(){
            new { Documentacao = "/swagger" },
            new {
                Itens = new List<dynamic>(){
                    new { Path = "/pais" },
                }
            }
        };
    }
}
