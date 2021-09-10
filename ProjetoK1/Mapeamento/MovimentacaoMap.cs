using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoK1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoK1.Mapeamento
{
    public class MovimentacaoMap : IEntityTypeConfiguration<Movimentacao>
    {
        public void Configure(EntityTypeBuilder<Movimentacao> builder)
        {
            builder.HasKey(m => m.MovimentacaoId);

            builder.Property(m => m.DataMovimentacao).IsRequired();

            builder.HasOne(m => m.Produto).WithMany(m => m.Movimentacoes).HasForeignKey(m => m.ProdutoId).IsRequired();

            builder.ToTable("Movimentacoes");
        }
    }
}
