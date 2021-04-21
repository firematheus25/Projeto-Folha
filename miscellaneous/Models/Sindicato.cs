using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miscellaneous.Models
{
    public class Sindicato
    {
        public int SindicatoId { get; set; }
        public int FuncionariosId { get; set; }
        public double Taxa { get; set; }
        public double TaxaExt { get; set; }


    }
}
