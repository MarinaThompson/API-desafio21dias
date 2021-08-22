using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace API_Alunos.Servico
{
    public class AlunoServico
    {
        public static async Task<bool> ValidarUsuario(int id)
        {
            using (var http = new HttpClient())
            {
                using (var response = await http.GetAsync($"{Program.AlunoApi}/alunos/{id}"))
                {
                    return response.IsSuccessStatusCode;
                }
            }

        }
    }
}

