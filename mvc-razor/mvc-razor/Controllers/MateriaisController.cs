using Microsoft.AspNetCore.Mvc;
using mvc_razor.Helpers;
using mvc_razor.Models;
using mvc_razor.Servico;
using System.Threading.Tasks;

namespace mvc_razor.Controllers
{
    [Logado]
    public class MateriaisController : Controller
    {
        //GET: Materiais
        public async Task<IActionResult> Index(int pagina = 1)
        {
            return View(await MaterialServico.TodosPaginado(pagina));
        }

        //GET: Materiais/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var material = await MaterialServico.BuscarPorId(id);
            if (material == null)
            {
                return NotFound();
            }
            return View();
        }    

        //GET: Materiais/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, Nome, AlunoId")] Material material)
        {
            if (ModelState.IsValid)
            {
                var mat = await MaterialServico.Salvar(material);
                return RedirectToAction(nameof(Index));
            }
            return View(material);
        }


        //GET: Materiais/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var material = await MaterialServico.BuscarPorId(id);
            if (material == null)
            {
                return NotFound();
            }
            return View(material);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Nome, AlunoId")] Material material)
        {
            if (id != material.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await MaterialServico.Salvar(material);
                return RedirectToAction(nameof(Index));
            }
            return View(material);
        }

        //GET: Materiais/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var material = await MaterialServico.BuscarPorId(id);
            if (material == null)
            {
                return NotFound();
            }
            return View(material);
        }

        //POST: Materiais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await MaterialServico.ExcluirPorId(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
