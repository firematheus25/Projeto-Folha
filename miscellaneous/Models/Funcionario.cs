using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miscellaneous.Models
{
    [Table("Funcioanarios")]
    public abstract class Funcionario
    {
        [Key]
        public int FuncionariosId { get; set; }
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public int MetodoPagamento { get; set; }
        public string CEP { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Bairro { get; set; }
        public int TipoPagamento { get; set; }
        public string Banco { get; set; }
        public string Conta { get; set; }
        public string Agencia { get; set; }
        public string NumeroConta { get; set; }
        public Sindicato Sindicato { get; set; }



    }
}
