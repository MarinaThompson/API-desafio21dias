using System;
using System.Collections.Generic;


namespace API_Alunos.ModelViews
{
    public record HomeView
    {
        public string Informação => "Bem vindo ao sistema";
        public List<dynamic> Endpoints => new List<dynamic>()
        {
            new {Documentacao = "/swagger"},
            new
            {
                Itens = new List<dynamic>()
                {
                    new {Path = "/materiais"}
                }
            }
        };
    }
}
