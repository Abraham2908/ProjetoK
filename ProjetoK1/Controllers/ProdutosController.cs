using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class ProdutosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProdutosController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Produtos.Include(p => p.Categoria).ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> NovoProduto()
        {
            ViewData["CategoriaId"] = new SelectList(await _context.Categorias.ToListAsync(), "CategoriaId", "Nome");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NovoProduto(Produto produto)
        {
            if (ModelState.IsValid)
            {
                await _context.Produtos.AddAsync(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["CategoriaId"] = new SelectList(await _context.Categorias.ToListAsync(), "CategoriaId", "Nome", produto.CategoriaId);
            return View(produto);
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirProduto(int produtoId)
        {
            Produto produto = await _context.Produtos.FindAsync(produtoId);
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
