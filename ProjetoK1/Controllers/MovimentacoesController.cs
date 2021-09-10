using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoK1.Data;
using ProjetoK1.Models;

namespace ProjetoK1.Controllers
{
    [Authorize]
    public class MovimentacoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MovimentacoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Movimentacoes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Movimentacoes.Include(m => m.Produto);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Movimentacoes/Create
        public IActionResult Create()
        {
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "ProdutoId", "Nome");
            return View();
        }

        // POST: Movimentacoes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MovimentacaoId,ProdutoId,Quantidade,Tipo,DataMovimentacao")] Movimentacao movimentacao)
        {
            if (ModelState.IsValid)
            {
                // Valida se o campo é valido
                var produto = _context.Produtos.Find(movimentacao.ProdutoId);
                if ((movimentacao.Tipo == 1) && (produto.Quantidade - movimentacao.Quantidade < 0)) {
                    ModelState.AddModelError("Quantidade", "Não existe a quantidade selecionada para saída");
                    return View(movimentacao);
                }

                // Verifica se a data da movimentação é anterior ou superior a data atual
                if ((movimentacao.DataMovimentacao < DateTime.Today) | (movimentacao.DataMovimentacao > DateTime.Today.AddDays(1)))
                {
                    ModelState.AddModelError("DataMovimentacao", "A data deve ser o dia de hoje.");
                    return View(movimentacao);
                }

                _context.Add(movimentacao);
                await _context.SaveChangesAsync();
                
                // Persistir quantidade de produtos
                if (movimentacao.Tipo == 0)
                {
                    produto.Quantidade += movimentacao.Quantidade;
                } else if (movimentacao.Tipo == 1)
                {
                    produto.Quantidade -= movimentacao.Quantidade;
                }
                _context.Update(produto);
                _context.SaveChanges();
                
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "ProdutoId", "Nome", movimentacao.ProdutoId);
            return View(movimentacao);
        }

        // GET: Movimentacoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movimentacao = await _context.Movimentacoes
                .Include(m => m.Produto)
                .FirstOrDefaultAsync(m => m.MovimentacaoId == id);
            if (movimentacao == null)
            {
                return NotFound();
            }

            return View(movimentacao);
        }

        // POST: Movimentacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movimentacao = await _context.Movimentacoes.FindAsync(id);
            _context.Movimentacoes.Remove(movimentacao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovimentacaoExists(int id)
        {
            return _context.Movimentacoes.Any(e => e.MovimentacaoId == id);
        }
    }
}
