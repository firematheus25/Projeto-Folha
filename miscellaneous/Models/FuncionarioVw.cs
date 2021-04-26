﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miscellaneous.Models
{
    [Table("FuncionariosVw")]
    public class FuncionarioVw
    {
        [Key]
        public int FuncionariosId { get; set; }
        public int TipoFuncionario { get; set; }
        public string Nome { get; set; }
        public int? MetodoPagamento { get; set; }
        public string CEP { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Bairro { get; set; }
        public int? TipoPagamento { get; set; }
        public string Banco { get; set; }
        public string Conta { get; set; }
        public string Agencia { get; set; }
        public string Operacao { get; set; }
        public string Sindicato { get; set; }
        public decimal? TaxaSindical { get; set; }
        public int? ComissionadoId { get; set; }
        public int? HoristaId { get; set; }
        public int? AssalariadoId { get; set; }

        public decimal? Salario { get; set; }
        public decimal? SalarioComissao { get; set; }
        public decimal? TaxaComissao { get; set; }
        public decimal? ValorHora { get; set; }

        public Assalariado Assalariado { get; set; }
        public Comissionado Comissionado { get; set; }
        public Horista Horista { get; set; }
    }
}
