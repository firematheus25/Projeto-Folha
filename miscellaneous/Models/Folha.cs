using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miscellaneous.Models
{
    public class Folha
    {
        [Key]
        public int FolhasId { get; set; }
        public int FuncionariosId { get; set; }
        public DateTime DtPagamento { get; set; }
        public decimal Salario { get; set; }

    }
}
