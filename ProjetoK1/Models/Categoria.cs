using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoK1.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [Display(Name = "Categoria")]
        public string Nome { get; set; }

        public ICollection<Produto> Produtos { get; set; }
    }
}
