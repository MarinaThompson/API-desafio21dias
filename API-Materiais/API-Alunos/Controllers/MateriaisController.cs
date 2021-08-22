using API_Alunos.Model;
using API_Alunos.Servico;
using EntityFrameworkPaginateCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace API_Alunos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriaisController : ControllerBase
    {
        private readonly DbContexto _context; 
        
        public MateriaisController(DbContexto context)
        {
            _context = context; 
        }

        //GET /materiais 
        [HttpGet]
        [Route("/materiais")]
        public async Task<IActionResult> Index(int page = 1)
        {
            return StatusCode(200, await _context.Materiais.OrderBy(a => a.Id).PaginateAsync(page, 3)); 
        }

        //GET: /materiais/5
        [HttpGet]
        [Route("/materiais/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound(); 
            }

            var material = await _context.Materiais
                 .FirstOrDefaultAsync(m => m.Id == id);

            if(material == null)
            {
                return NotFound(); 
            }
            return StatusCode(200, material);
        }

        //POST: /materiais
        [HttpPost]
        [Route("/materiais")]
        public async Task<IActionResult> Create(Material material)
        {
            if (ModelState.IsValid)
            {
                if (!await AlunoServico.ValidarUsuario(material.AlunoId))
                    return StatusCode(400, new { Mensagem = "O usuário passado não é válido ou não está cadastrado" }); 

                _context.Add(material);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); 
            }
            return StatusCode(400, new { Mensagem = "O material passado é inválido" }); 
        }

        //PUT: /material/5
        [HttpPut]
        [Route("/materiais/{id}")]
        public async Task<IActionResult> Edit(int id, Material material)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    material.Id = id;
                    _context.Update(material);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MaterialExists(material.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw; 
                    }
                }
                return StatusCode(200, material); 
            }
            return StatusCode(200, material); 
        }

        //DELETE: /materiais/5
        [HttpDelete]
        [Route("/materiais/{id}")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var material = await _context.Materiais.FindAsync(id);
            _context.Materiais.Remove(material);
            await _context.SaveChangesAsync();
            return StatusCode(204); 
        }

        private bool MaterialExists(int id)
        {
            return _context.Materiais.Any(m => m.Id == id); 
        }
    }
}
