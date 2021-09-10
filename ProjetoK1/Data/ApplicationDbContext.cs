using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjetoK1.Models;
using ProjetoK1.Mapeamento;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoK1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Movimentacao> Movimentacoes { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ProdutoMap());
            builder.ApplyConfiguration(new MovimentacaoMap());
            builder.ApplyConfiguration(new CategoriaMap());


        }


    }
}
