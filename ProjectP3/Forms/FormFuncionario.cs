using miscellaneous.Models;
using Newtonsoft.Json;
using ProjectP3.Others;
using ProjectP3.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectP3
{
    public partial class FormFuncionario : FormPadrao
    {
        public FormFuncionario()
        {
            InitializeComponent();

            MetodoPagamento.Items.Add("1 - Cheque pelos correios");
            MetodoPagamento.Items.Add("2 - Cheque em mãos");
            MetodoPagamento.Items.Add("3 - Deposito em conta bancária");

            Sindicato.Items.Add("Sim");
            Sindicato.Items.Add("Não");

            Salario.Visible = false;
            lbl_Salario.Visible = false;
            TaxaComissao.Visible = false;
            lbl_TaxaComissao.Visible = false;
            ValorHora.Visible = false;
            lbl_ValorHora.Visible = false;
            MetodoPagamento.DropDownWidth();
        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var Funcionario = new Funcionario();

                if (!string.IsNullOrEmpty(FuncionariosId.Text))
                {
                    Funcionario.FuncionariosId = Convert.ToInt32(FuncionariosId.Text);
                }

                Funcionario.Nome = Nome.Text;             
                Funcionario.MetodoPagamento = Convert.ToInt32(MetodoPagamento.Text.Substring(0, 1));
                Funcionario.CEP = Cep.Text;
                Funcionario.Rua = Rua.Text;
                Funcionario.Numero = Numero.Text;
                Funcionario.Cidade = Cidade.Text;
                Funcionario.Bairro = Bairro.Text;
                Funcionario.Complemento = Complemento.Text;
                Funcionario.UF = UF.Text.Substring(0, 2);
                Funcionario.Banco = Banco.Text;
                Funcionario.Agencia = Agencia.Text;
                Funcionario.Conta = Conta.Text;
                Funcionario.Operacao = NumeroConta.Text;

                if (Sindicato.SelectedIndex != -1)
                {
                    Funcionario.Sindicato = Sindicato.Text.Substring(0, 1);
                    Funcionario.TaxaSindical = Convert.ToDecimal(TaxaSindical.Text);

                }

                if (Assalariado.Checked)
                {
                    Funcionario.TipoFuncionario = 1;
                    var Assalariado = new Assalariado();
                    if (!string.IsNullOrEmpty(AssalariadoId.Text))
                    {
                        Assalariado.AssalariadoId = Convert.ToInt32(AssalariadoId.Text);
                    }
                    Assalariado.Salario = Convert.ToDecimal(Salario.Text);
                    Funcionario.Assalariado = Assalariado;
                }

                if (Comissionado.Checked)
                {
                    Funcionario.TipoFuncionario = 2;
                    var Comissionado = new Comissionado();
                    if (!string.IsNullOrEmpty(ComissionadoId.Text))
                    {
                        Comissionado.ComissionadoId = Convert.ToInt32(ComissionadoId.Text);
                    }
                    Comissionado.Salario = Convert.ToDecimal(Salario.Text);
                    Comissionado.TaxaComissao = Convert.ToDecimal(TaxaComissao.Text);
                    Funcionario.Comissionado = Comissionado;
                }

                if (Horista.Checked)
                {
                    Funcionario.TipoFuncionario = 3;
                    var Horista = new Horista();
                    if (!string.IsNullOrEmpty(HoristaId.Text))
                    {
                        Horista.HoristaId = Convert.ToInt32(HoristaId.Text);
                    }
                    Horista.ValorHora = Convert.ToDouble(ValorHora.Text);
                    Funcionario.Horista = Horista;
                }

                var Result = await new Services<Funcionario>().Post("api/Funcionarios/", Funcionario);
                var Message = await Result.Content.ReadAsStringAsync();

            }
            catch (Exception M)
            {

                MessageBox.Show(M.Message);
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
            lbl_TxSindical.Visible = false;
            TaxaSindical.Visible = false;

            FuncionariosId.Clear();
            Nome.Clear();
            Sindicato.SelectedIndex = -1;
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

                lbl_Salario.Visible = true;
                Salario.Visible = true;
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

        private void Sindicato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Sindicato.SelectedIndex == 0)
            {
                lbl_TxSindical.Visible = true;
                TaxaSindical.Visible = true;

            }
        }
    }
}
