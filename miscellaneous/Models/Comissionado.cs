using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miscellaneous.Models
{
    public class Comissionado 
    {
        [Key]
        public int ComissionadoId { get; set; }
        public decimal Salario { get; set; }
        public decimal TaxaComissao { get; set; }

    }
}
