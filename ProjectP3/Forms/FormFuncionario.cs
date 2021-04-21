using miscellaneous.Models;
using ProjectP3.Others;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectP3
{
    public partial class Empregado : FormPadrao
    {
        public Empregado()
        {
            InitializeComponent();

            MetodoPagamento.Items.Add("1 - Cheque pelos correios");
            MetodoPagamento.Items.Add("2 - Cheque em mãos");
            MetodoPagamento.Items.Add("3 - Deposito em conta bancária");

            Salario.Visible = false;
            lbl_Salario.Visible = false;
            TaxaComissao.Visible = false;
            lbl_TaxaComissao.Visible = false;
            ValorHora.Visible = false;
            lbl_ValorHora.Visible = false;
            MetodoPagamento.DropDownWidth();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Assalariado.Checked)
            {
                var Assalariado = new Assalariado();

                //Assalariado.FuncionariosId = FuncionariosId.Text.ToString();
                Assalariado.Nome = Nome.Text;
                //Assalariado.Sindicato = SindicatosId.GetValues<Sindicato>().SindicatoId;
                Assalariado.MetodoPagamento = Convert.ToInt32(MetodoPagamento.Text.Substring(0, 1));
                Assalariado.Salario = Convert.ToDecimal(Salario.Text);
                Assalariado.CEP = Cep.Text;
                Assalariado.Rua = Rua.Text;
                Assalariado.Numero = Numero.Text;
                Assalariado.Cidade = Cidade.Text;
                Assalariado.Bairro = Bairro.Text;
                Assalariado.Complemento = Complemento.Text;
                Assalariado.UF = UF.Text.Substring(0, 2);
                Assalariado.Banco = Banco.Text;
                Assalariado.Agencia = Agencia.Text;
                Assalariado.Conta = Conta.Text;
                Assalariado.NumeroConta = NumeroConta.Text;
            }

            if (Comissionado.Checked)
            {
                var Comissionado = new Comissionado();

                //Assalariado.FuncionariosId = FuncionariosId.Text.ToString();
                Comissionado.Nome = Nome.Text;
                //Assalariado.Sindicato = SindicatosId.GetValues<Sindicato>().SindicatoId;
                Comissionado.MetodoPagamento = Convert.ToInt32(MetodoPagamento.Text.Substring(0, 1));
                Comissionado.Salario = Convert.ToDecimal(Salario.Text);
                Comissionado.CEP = Cep.Text;
                Comissionado.Rua = Rua.Text;
                Comissionado.Numero = Numero.Text;
                Comissionado.Cidade = Cidade.Text;
                Comissionado.Bairro = Bairro.Text;
                Comissionado.Complemento = Complemento.Text;
                Comissionado.UF = UF.Text.Substring(0, 2);
                Comissionado.Banco = Banco.Text;
                Comissionado.Agencia = Agencia.Text;
                Comissionado.Conta = Conta.Text;
                Comissionado.NumeroConta = NumeroConta.Text;

            }

            if (Horista.Checked)
            {
                var Horista = new Horista();

                //Assalariado.FuncionariosId = FuncionariosId.Text.ToString();
                Horista.Nome = Nome.Text;
                //Assalariado.Sindicato = SindicatosId.GetValues<Sindicato>().SindicatoId;
                Horista.MetodoPagamento = Convert.ToInt32(MetodoPagamento.Text.Substring(0, 1));                
                Horista.CEP = Cep.Text;
                Horista.Rua = Rua.Text;
                Horista.Numero = Numero.Text;
                Horista.Cidade = Cidade.Text;
                Horista.Bairro = Bairro.Text;
                Horista.Complemento = Complemento.Text;
                Horista.UF = UF.Text.Substring(0, 2);
                Horista.Banco = Banco.Text;
                Horista.Agencia = Agencia.Text;
                Horista.Conta = Conta.Text;
                Horista.NumeroConta = NumeroConta.Text;

            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Assalariado.Checked = false;
            Horista.Checked = false;
            Comissionado.Checked = false;
            Salario.Visible = false;
            lbl_Salario.Visible = false;            
            TaxaComissao.Visible = false;
            lbl_TaxaComissao.Visible = false;
            ValorHora.Visible = false;
            lbl_ValorHora.Visible = false;

            FuncionariosId.Clear();
            Nome.Clear();
            SindicatosId.Clear();
            MetodoPagamento.SelectedIndex = -1;
            Salario.Clear();
            Cep.Clear();
            Rua.Clear();
            Numero.Clear();
            Cidade.Clear();
            Bairro.Clear();
            Complemento.Clear();
            UF.SelectedIndex = -1;
            Banco.Clear();
            Agencia.Clear();
            Conta.Clear();
            NumeroConta.Clear();
            Salario.Clear();
            TaxaComissao.Clear();
            ValorHora.Clear();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void MetPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Assalariado_CheckedChanged(object sender, EventArgs e)
        {
            if (Assalariado.Checked)
            {
                Comissionado.Checked = false;
                Horista.Checked = false;

                ValorHora.Visible = false;
                lbl_ValorHora.Visible = false;
                TaxaComissao.Visible = false;
                lbl_TaxaComissao.Visible = false;

                Salario.Visible = true;
                lbl_Salario.Visible = true;


            }
        }

        private void Comissionado_CheckedChanged(object sender, EventArgs e)
        {
            if (Comissionado.Checked)
            {
                Assalariado.Checked = false;                
                Horista.Checked = false;     
                
                ValorHora.Visible = false;
                lbl_ValorHora.Visible = false;

                lbl_TaxaComissao.Visible = true;
                TaxaComissao.Visible = true;
            }
        }

        private void Horista_CheckedChanged(object sender, EventArgs e)
        {
            Comissionado.Checked = false;
            Assalariado.Checked = false;

            lbl_TaxaComissao.Visible = false;
            TaxaComissao.Visible = false;
            Salario.Visible = false;
            lbl_Salario.Visible = false;
            ValorHora.Visible = true;
            lbl_ValorHora.Visible = true;
        }

    }
}
