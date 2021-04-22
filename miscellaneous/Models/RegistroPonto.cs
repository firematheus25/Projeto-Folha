using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miscellaneous.Models
{
    [Table("RegistroPontos")]
    public class RegistroPonto
    {
        [Key]
        public int RegistroPontoId { get; set; }
        public int FuncionariosId { get; set; }
        public DateTime? Data { get; set; }
        public TimeSpan HoraChegada { get; set; }
        public TimeSpan HoraSaida { get; set; }


    }
}
