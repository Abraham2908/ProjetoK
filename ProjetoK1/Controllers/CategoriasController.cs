using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoK1.Data;
using ProjetoK1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoK1.Controllers
{
    [Authorize]
    public class CategoriasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriasController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Categorias.ToListAsync());
        }

        [HttpGet]
        public IActionResult NovaCategoria()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NovaCategoria([Bind("CategoriaId,Nome")]Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                // Verifica se a categoria tem um Nome
                if (categoria.Nome == null)
                {
                    ModelState.AddModelError("Nome", "A categoria deve ter um Nome.");
                    return View(categoria);
                }

                await _context.Categorias.AddAsync(categoria);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(categoria);
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirCategoria(int categoriaId)
        {
            Categoria categoria = await _context.Categorias.FindAsync(categoriaId);
            _context.Categorias.Remove(categoria);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }

}
