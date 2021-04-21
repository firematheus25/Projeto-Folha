using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miscellaneous.Models
{
    public class Taxas
    {
        [Key]
        public int TaxasId { get; set; }
        public int FuncionariosId { get; set; }
        public decimal TaxaServico { get; set; }
        public decimal TaxaSindExtra { get; set; }
    }
}
