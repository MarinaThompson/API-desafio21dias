using api_desafio21dias.Servicos;
using API_Pais.Models;
using API_Pais.Servicos;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using System;
using System.Threading.Tasks;

namespace API_Pais.Controllers
{
    [ApiController]
    public class PaisController : Controller
    {
       public PaisController()
        {
            this.paiMongoRepo = new PaisMongodb(); 
        }
        private PaisMongodb paiMongoRepo;
        
        //GET: /pais
        [HttpGet]
        [Route("/pais")]
        public async Task<IActionResult> Index()
        {
            return StatusCode(200, await paiMongoRepo.Todos());
        }

        //GET: /pais/5
        [HttpGet]
        [Route("/pais/{id}")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound(); 
            }

            var pai = await paiMongoRepo.BuscaPorId(ObjectId.Parse(id)); 
            if(pai == null)
            {
                return NotFound();
            }
            return StatusCode(200, pai);
        }

        //POST: /pais
        [HttpPost]
        [Route("/pais")]
        public async Task<IActionResult> Create(Pai pai)
        {
            if (ModelState.IsValid)
            {
                if (!(await AlunoServico.ValidarUsuario(pai.AlunoId)))
                    return StatusCode(400, new { Mensagem = "O aluno passado não é válido ou não está cadastrado" });

                pai.Aluno = await AlunoServico.BuscaPorId(pai.AlunoId);

                paiMongoRepo.Inserir(pai);
                return StatusCode(201, pai);
            }
            return StatusCode(400, new { Mensagem = "O pai passado é inválido" });
        }

        //PUT: /pais/5
        [HttpPut]
        [Route("/pais/{id}")]
        public async Task<IActionResult> Edit(string id, Pai pai)
        {
            if (ModelState.IsValid)
            {
                if (!(await AlunoServico.ValidarUsuario(pai.AlunoId)))
                    return StatusCode(400, new { Mensagem = "O aluno passado não é válido ou não está cadastrado" });

                try
                {
                    pai.Id = ObjectId.Parse(id);
                    pai.Aluno = await AlunoServico.BuscaPorId(pai.AlunoId);
                    paiMongoRepo.Atualizar(pai);
                }
                catch (Exception erro)
                {
                    if(! await PaiExists(pai.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        return StatusCode(500, erro); 
                    }
                }
                return StatusCode(200, pai); 
            }
            return StatusCode(200, pai); 
        }

        //DELETE: /pais/5
        [HttpDelete]
        [Route("/pais/{id}")]
        public IActionResult DeleteConfimed(string id)
        {
            paiMongoRepo.RemoverPorId(ObjectId.Parse(id));
            return StatusCode(204); 
        }

        private async Task<bool> PaiExists(ObjectId id)
        {
            return (await paiMongoRepo.BuscaPorId(id)) != null;
        }

    }
}
