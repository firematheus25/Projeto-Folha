using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miscellaneous.Models
{
    public class TaxasServico
    {
        [Key]
        public int FuncionarioSindicalId { get; set; }
        public DateTime Competencia { get; set; }
        public double TaxaServico { get; set; }
    }
}
