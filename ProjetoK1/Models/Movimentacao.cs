using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoK1.Models
{
    public enum TipoEnum
    {
        Entrada = 0,
        Saida = 1
    }

    public class Movimentacao
    {
        public int MovimentacaoId { get; set; }

        public int ProdutoId { get; set; }

        [Display(Name = "Produto")]
        public Produto Produto { get; set; }

        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }

        [Display(Name = "Tipo")]
        [EnumDataType(typeof(TipoEnum))]
        public int Tipo { get; set; }

        [Display(Name = "Data")]
        public DateTime DataMovimentacao { get; set; }

    }
}
