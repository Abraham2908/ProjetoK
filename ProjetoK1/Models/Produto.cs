using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoK1.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        public string Nome { get; set; }

        [Display(Name = "Estoque")]
        public int Quantidade { get; set; }

        [Display(Name = "Preço")]
        public double Preco { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

        public ICollection<Movimentacao> Movimentacoes { get; set; }
    }
}
