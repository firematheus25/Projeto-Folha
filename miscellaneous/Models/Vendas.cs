using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miscellaneous.Models
{
    public class Vendas
    {
        [Key]
        public int VendasId { get; set; }
        public int FuncionariosId { get; set; }
        public decimal? Valor { get; set; }
        public DateTime DtVenda { get; set; }
        public decimal? Porcentagem { get; set; }
    }
}
