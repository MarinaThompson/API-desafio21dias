using Microsoft.AspNetCore.Mvc;
using mvc_razor.Models;
using mvc_razor.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_razor.Controllers
{
    public class AlunosController : Controller
    {
        //GET: Alunos
        public async Task<IActionResult> Index(int pagina = 1)
        {
            return View(await AlunoServico.TodosPaginado(pagina));
        }

        //GET: Alunos/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var aluno = await AlunoServico.BuscarPorId(id);
            if (aluno == null)
            {
                return NotFound();
            }
            return View(aluno);
        }

        //GET: Alunos/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id, Nome, Matricula, Notas")] Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                var estudante = await AlunoServico.Salvar(aluno);
                return Redirect($"/Alunos/Details/{estudante.Id}");
            }
            return View(aluno);
        }


        //GET: Alunos/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var aluno = await AlunoServico.BuscarPorId(id);
            if (aluno == null)
            {
                return NotFound();
            }
            return View(aluno);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Nome, Matricula, Notas")] Aluno aluno)
        {
            if (id != aluno.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await AlunoServico.Salvar(aluno);
                return RedirectToAction(nameof(Index));
            }
            return View(aluno);
        }

        //GET: Alunos/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var aluno = await AlunoServico.BuscarPorId(id);
            if (aluno == null)
            {
                return NotFound();
            }
            return View(aluno);
        }

        //POST: Alunos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await AlunoServico.ExcluirPorId(id);
            return RedirectToAction(nameof(Index));
        }
    }
}