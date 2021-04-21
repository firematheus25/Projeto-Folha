using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miscellaneous.Models
{
    public class Comissionado : Funcionario
    {
        public decimal Salario { get; set; }
        public decimal TaxaComissao { get; set; }

    }
}
