using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miscellaneous.Models
{
    public class Horista 
    {
        [Key]
        public int HoristaId { get; set; }
        public decimal ValorHora { get; set; }
    }
}
