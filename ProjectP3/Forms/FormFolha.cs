using miscellaneous.Models;
using ProjectP3.Others;
using ProjectP3.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectP3.Forms
{
    public partial class FormFolha : FormPadrao
    {
        public List<Folha> ListFolha;
        public FormFolha()
        {
            InitializeComponent();

            GridFolha.BuilderColumn("funcionariosId", "Matrícula", 65);
            GridFolha.BuilderColumn("Nome", "Nome", DataGridViewAutoSizeColumnMode.Fill);
            GridFolha.BuilderColumn("MetodoPagamento", "Metodo Pagamento");
            GridFolha.BuilderColumn("Salario", "Salário");
            GridFolha.BuilderColumn("DtPagamento", "Pagamento", DataGridViewAutoSizeColumnMode.None, "dd/MM/yyyy");



            ListFolha = new List<Folha>();
        }

        private async void GerarFolha_Click(object sender, EventArgs e)
        {
            GridFolha.Rows.Clear();
            ListFolha.Clear();
            try
            {
                var Funcionario = await new Services<FuncionarioVw>().Get("api/Funcionarios/");

                for (int i = 0; i < Funcionario.Count; i++)
                {
                    string DIASEMANA = "";
                    if (DtPagamento.Date.Value.DayOfWeek.ToString() == "Sunday") { DIASEMANA = "Domingo"; }
                    if (DtPagamento.Date.Value.DayOfWeek.ToString() == "Monday") { DIASEMANA = "Segunda-Feira"; }
                    if (DtPagamento.Date.Value.DayOfWeek.ToString() == "Tuesday") { DIASEMANA = "Terça-Feira"; }
                    if (DtPagamento.Date.Value.DayOfWeek.ToString() == "Wednesday") { DIASEMANA = "Quarta-Feira"; }
                    if (DtPagamento.Date.Value.DayOfWeek.ToString() == "Thursday") { DIASEMANA = "Quinta-Feira"; }
                    if (DtPagamento.Date.Value.DayOfWeek.ToString() == "Friday") { DIASEMANA = "Sexta-Feira"; }
                    if (DtPagamento.Date.Value.DayOfWeek.ToString() == "Saturday") { DIASEMANA = "Sábado"; }

                    var ultimoDiaDoMes = new DateTime(DtPagamento.Date.Value.Year, DtPagamento.Date.Value.Month, DateTime.DaysInMonth(DtPagamento.Date.Value.Year, DtPagamento.Date.Value.Month));

                    var TaxaServicoSindical = await new Services<TaxasServico>().GetByIds("api/TaxasServico/Ids", Funcionario[i].FuncionarioSindicalId.ToString());
                    if (Funcionario[i].TipoAgenda == "Mensal") //MENSAL
                    {
                        var DataMes = new DateTime(DtPagamento.Date.Value.Year, (DtPagamento.Date.Value.Month - 1), (DtPagamento.Date.Value.Day + 1));


                        if (Funcionario[i].Dia == DtPagamento.Date.Value.Day.ToString())
                        {
                           

                            if (Funcionario[i].TipoFuncionario == 1) //Assalariado
                            {
                                double? salario = 0;

                                var X = Funcionario[i];
                                if (string.IsNullOrEmpty(Funcionario[i].SindicatosId.ToString()))
                                {
                                    var taxa = Funcionario[i].TaxaSindical;                                   
                                    salario = X.Salario - taxa;
                                }

                                if (TaxaServicoSindical.Count > 0 )
                                {
                                    for (int n = 0; n < TaxaServicoSindical.Count; n++)
                                    {
                                        if (TaxaServicoSindical[n].Competencia.Month == DtPagamento.Date.Value.Month )
                                        {
                                            salario = salario - TaxaServicoSindical[n].TaxaServico;
                                        }
                                    }

                                }

                                var folha = new Folha();
                                folha.FuncionariosId = X.FuncionariosId;
                                folha.Nome = X.Nome;
                                if (X.MetodoPagamento == 1)
                                {
                                    folha.MetodoPagamento = "Cheque pelos correios";
                                }
                                if (X.MetodoPagamento == 2)
                                {
                                    folha.MetodoPagamento = "Cheque em mãos";
                                }
                                if (X.MetodoPagamento == 3)
                                {
                                    folha.MetodoPagamento = "Deposito em conta bancária";
                                }
                                folha.DtPagamento = DtPagamento.Date.Value;
                                folha.Salario = Math.Round((double)salario, 2);

                                ListFolha.Add(folha);
                            }



                            if (Funcionario[i].TipoFuncionario == 2) // Comissionado
                            {
                                double? salario = 0;

                                var X = Funcionario[i];
                                if (string.IsNullOrEmpty(Funcionario[i].SindicatosId.ToString()))
                                {
                                    var taxa = Funcionario[i].TaxaSindical;
                                    salario = X.SalarioComissao - taxa;
                                }

                                if (TaxaServicoSindical.Count > 0)
                                {
                                    for (int n = 0; n < TaxaServicoSindical.Count; n++)
                                    {
                                        if (TaxaServicoSindical[n].Competencia.Month == DtPagamento.Date.Value.Month)
                                        {
                                            salario = salario - TaxaServicoSindical[n].TaxaServico;
                                        }
                                    }

                                }

                                var vendas = await new Services<Vendas>().GetByIds("api/Vendas/Ids", Funcionario[i].VendasId.ToString());

                                for (int v = 0; i < vendas.Count; i++)
                                {                                    
                                    if (vendas[v].DtVenda.Date > DataMes.Date && vendas[v].DtVenda.Date <= DtPagamento.Date)
                                    {
                                        var taxacomissao = vendas[v].ValorVenda / Funcionario[i].TaxaComissao;

                                        salario += salario + taxacomissao;
                                    }
                                }


                                var folha = new Folha();
                                folha.FuncionariosId = X.FuncionariosId;
                                folha.Nome = X.Nome;
                                if (X.MetodoPagamento == 1)
                                {
                                    folha.MetodoPagamento = "Cheque pelos correios";
                                }
                                if (X.MetodoPagamento == 2)
                                {
                                    folha.MetodoPagamento = "Cheque em mãos";
                                }
                                if (X.MetodoPagamento == 3)
                                {
                                    folha.MetodoPagamento = "Deposito em conta bancária";
                                }
                                folha.DtPagamento = DtPagamento.Date.Value;
                                folha.Salario = Math.Round((double)salario, 2);

                                ListFolha.Add(folha);

                            }



                            if (Funcionario[i].TipoFuncionario == 3) //Horista
                            {
                                var RegistroPontos = await new Services<RegistroPonto>().GetByIds("api/RegistroPontos/Ids", Funcionario[i].FuncionariosId.ToString());
                                double? salarioHorista = 0;
                                var Z = Funcionario[i];

                                for (int j = 0; j < RegistroPontos.Count; j++)
                                {
                                    var Y = RegistroPontos[j];

                                    if (Y.DtPonto.Value.Date > DataMes.Date && Y.DtPonto.Value.Date <= DtPagamento.Date)
                                    {
                                        var HS = Convert.ToDateTime(Y.Horas);
                                        TimeSpan padrao = new TimeSpan(08, 00, 00);

                                        var Horas = HS.Hour;
                                        var Minuto = HS.Minute;
                                        var ValorMin = (HS.Minute * 1.666667) / 100;
                                        var ValorMinu = Z.ValorHora * ValorMin;
                                        var ValorMinConvertido = Math.Round((double)ValorMinu, 2);

                                        var HoraExtra = HS.TimeOfDay - padrao; // Quantidade de Horas/Minutos Extras
                                        var Horacalc = HoraExtra.Hours;        // Quantidade de Horas Extras
                                        var Mincalc = (HoraExtra.Minutes * 1.666667) / 100; // Quantidade de Minutos Extras
                                        var TaxaExtra = ((double)(Z.ValorHora * 1.5)); // Valor Taxa Extra
                                        var Min = TaxaExtra * Mincalc; // Valor Minutos Extras
                                        var MinExtra = Math.Round(Min, 2); // Valor Minutos Extras - Duas casas Decimais

                                        if (HS.TimeOfDay > padrao)
                                        {

                                            salarioHorista += (Z.ValorHora * padrao.Hours) + (TaxaExtra * Horacalc) + MinExtra;
                                        }
                                        else
                                        {
                                            salarioHorista += (Z.ValorHora * Horas) + ValorMinConvertido;
                                        }
                                    }
                                }

                                if (string.IsNullOrEmpty(Funcionario[i].SindicatosId.ToString()))
                                {
                                    var taxa = Funcionario[i].TaxaSindical;
                                    salarioHorista = salarioHorista - taxa;
                                }

                                if (TaxaServicoSindical.Count > 0)
                                {
                                    for (int n = 0; n < TaxaServicoSindical.Count; n++)
                                    {
                                        if (TaxaServicoSindical[n].Competencia.Month == DtPagamento.Date.Value.Month)
                                        {
                                            salarioHorista = salarioHorista - TaxaServicoSindical[n].TaxaServico;
                                        }
                                    }

                                }


                                var folha = new Folha();
                                folha.FuncionariosId = Z.FuncionariosId;
                                folha.Nome = Z.Nome;
                                if (Z.MetodoPagamento == 1)
                                {
                                    folha.MetodoPagamento = "Cheque pelos correios";
                                }
                                if (Z.MetodoPagamento == 2)
                                {
                                    folha.MetodoPagamento = "Cheque em mãos";
                                }
                                if (Z.MetodoPagamento == 3)
                                {
                                    folha.MetodoPagamento = "Deposito em conta bancária";
                                }
                                folha.DtPagamento = DtPagamento.Date.Value;
                                folha.Salario = salarioHorista;
                                ListFolha.Add(folha);
                            }

                        }

                    }

                    if (Funcionario[i].TipoAgenda == "Semanal") //SEMANAL
                    {
                        if (Funcionario[i].DiaSemana == DIASEMANA)
                        {
                            if (Funcionario[i].TipoFuncionario == 1) //ASSALARIADO
                            {
                                var X = Funcionario[i];
                                double? salario = (X.Salario / ultimoDiaDoMes.Date.Day) * 7;

                                
                                if (string.IsNullOrEmpty(Funcionario[i].SindicatosId.ToString()))
                                {
                                    var taxa = Funcionario[i].TaxaSindical;
                                    var taxasemanal = (taxa / ultimoDiaDoMes.Date.Day) * 7; 
                                    salario = salario - taxasemanal;
                                }

                                if (TaxaServicoSindical.Count > 0)
                                {
                                    for (int n = 0; n < TaxaServicoSindical.Count; n++)
                                    {
                                        if (TaxaServicoSindical[n].Competencia.Month == DtPagamento.Date.Value.Month)
                                        {
                                            var taxasemanal = (TaxaServicoSindical[n].TaxaServico / ultimoDiaDoMes.Date.Day) * 7;

                                            salario = salario - taxasemanal;
                                        }
                                    }

                                }

                                var folha = new Folha();
                                folha.FuncionariosId = X.FuncionariosId;
                                folha.Nome = X.Nome;
                                if (X.MetodoPagamento == 1)
                                {
                                    folha.MetodoPagamento = "Cheque pelos correios";
                                }
                                if (X.MetodoPagamento == 2)
                                {
                                    folha.MetodoPagamento = "Cheque em mãos";
                                }
                                if (X.MetodoPagamento == 3)
                                {
                                    folha.MetodoPagamento = "Deposito em conta bancária";
                                }
                                folha.DtPagamento = DtPagamento.Date.Value;
                                folha.Salario = Math.Round((double)salario, 2);

                                ListFolha.Add(folha);


                            }

                            if (Funcionario[i].TipoFuncionario == 2) // Comissionado
                            {

                                var X = Funcionario[i];
                                double? salario = (X.SalarioComissao / ultimoDiaDoMes.Date.Day) * 7;


                                
                                if (string.IsNullOrEmpty(Funcionario[i].SindicatosId.ToString()))
                                {
                                    var taxa = Funcionario[i].TaxaSindical;
                                    var taxasemanal = (taxa / ultimoDiaDoMes.Date.Day) * 7;                                    
                                    salario = salario - taxasemanal;
                                }

                                if (TaxaServicoSindical.Count > 0)
                                {
                                    for (int n = 0; n < TaxaServicoSindical.Count; n++)
                                    {
                                        if (TaxaServicoSindical[n].Competencia.Month == DtPagamento.Date.Value.Month)
                                        {
                                            var taxasemanal = (TaxaServicoSindical[n].TaxaServico / ultimoDiaDoMes.Date.Day) * 7;

                                            salario = salario - taxasemanal;
                                        }
                                    }

                                }

                                var vendas = await new Services<Vendas>().GetByIds("api/Vendas/Ids", Funcionario[i].VendasId.ToString());

                                for (int v = 0; i < vendas.Count; i++)
                                {
                                    var Day = DtPagamento.Date.Value.AddDays(-6);

                                    if (vendas[v].DtVenda.Date > Day.Date && vendas[v].DtVenda.Date <= DtPagamento.Date)
                                    {
                                        var taxacomissao = vendas[v].ValorVenda / Funcionario[i].TaxaComissao;

                                        salario += salario + taxacomissao;
                                    }
                                }

                                var folha = new Folha();
                                folha.FuncionariosId = X.FuncionariosId;
                                folha.Nome = X.Nome;
                                if (X.MetodoPagamento == 1)
                                {
                                    folha.MetodoPagamento = "Cheque pelos correios";
                                }
                                if (X.MetodoPagamento == 2)
                                {
                                    folha.MetodoPagamento = "Cheque em mãos";
                                }
                                if (X.MetodoPagamento == 3)
                                {
                                    folha.MetodoPagamento = "Deposito em conta bancária";
                                }
                                folha.DtPagamento = DtPagamento.Date.Value;
                                folha.Salario = Math.Round((double)salario, 2);

                                ListFolha.Add(folha);

                            }

                            if (Funcionario[i].TipoFuncionario == 3) // Horista
                            {
                                var RegistroPontos = await new Services<RegistroPonto>().GetByIds("api/RegistroPontos/Ids", Funcionario[i].FuncionariosId.ToString());
                                double? salarioHorista = 0;
                                var Z = Funcionario[i];

                                for (int j = 0; j < RegistroPontos.Count; j++)
                                {
                                    var Y = RegistroPontos[j];
                                    var Day = DtPagamento.Date.Value.AddDays(-6);

                                    if (Y.DtPonto.Value.Date > Day.Date && Y.DtPonto.Value.Date <= DtPagamento.Date)
                                    {
                                        var HS = Convert.ToDateTime(Y.Horas);
                                        TimeSpan padrao = new TimeSpan(08, 00, 00);

                                        var Horas = HS.Hour;
                                        var Minuto = HS.Minute;
                                        var ValorMin = (HS.Minute * 1.666667) / 100;
                                        var ValorMinu = Z.ValorHora * ValorMin;
                                        var ValorMinConvertido = Math.Round((double)ValorMinu, 2);

                                        var HoraExtra = HS.TimeOfDay - padrao; // Quantidade de Horas/Minutos Extras
                                        var Horacalc = HoraExtra.Hours;        // Quantidade de Horas Extras
                                        var Mincalc = (HoraExtra.Minutes * 1.666667) / 100; // Quantidade de Minutos Extras
                                        var TaxaExtra = ((double)(Z.ValorHora * 1.5)); // Valor Taxa Extra
                                        var Min = TaxaExtra * Mincalc; // Valor Minutos Extras
                                        var MinExtra = Math.Round(Min, 2); // Valor Minutos Extras - Duas casas Decimais

                                        if (HS.TimeOfDay > padrao)
                                        {

                                            salarioHorista += (Z.ValorHora * padrao.Hours) + (TaxaExtra * Horacalc) + MinExtra;
                                        }
                                        else
                                        {
                                            salarioHorista += (Z.ValorHora * Horas) + ValorMinConvertido;
                                        }
                                    }
                                }

                                if (string.IsNullOrEmpty(Funcionario[i].SindicatosId.ToString()))
                                {
                                    var taxa = Funcionario[i].TaxaSindical;
                                    salarioHorista = salarioHorista - taxa;
                                }

                                if (TaxaServicoSindical.Count > 0)
                                {
                                    for (int n = 0; n < TaxaServicoSindical.Count; n++)
                                    {
                                        if (TaxaServicoSindical[n].Competencia.Month == DtPagamento.Date.Value.Month)
                                        {
                                            var taxasemanal = (TaxaServicoSindical[n].TaxaServico / ultimoDiaDoMes.Date.Day) * 7;

                                            salarioHorista = salarioHorista - taxasemanal;
                                        }
                                    }

                                }


                                var folha = new Folha();
                                folha.FuncionariosId = Z.FuncionariosId;
                                folha.Nome = Z.Nome;
                                if (Z.MetodoPagamento == 1)
                                {
                                    folha.MetodoPagamento = "Cheque pelos correios";
                                }
                                if (Z.MetodoPagamento == 2)
                                {
                                    folha.MetodoPagamento = "Cheque em mãos";
                                }
                                if (Z.MetodoPagamento == 3)
                                {
                                    folha.MetodoPagamento = "Deposito em conta bancária";
                                }
                                folha.DtPagamento = DtPagamento.Date.Value;
                                folha.Salario = salarioHorista;
                                ListFolha.Add(folha);
                            }
                        }
                    }
                    if (Funcionario[i].TipoAgenda == "Bi-semanal") // BI-SEMANAL
                    {

                        if (Funcionario[i].DiaSemana == DIASEMANA)
                        {

                           

                            if (Funcionario[i].TipoFuncionario == 1) //ASSALARIADO
                            {

                                var X = Funcionario[i];
                                double? salario = (X.Salario / ultimoDiaDoMes.Date.Day) * 14;


                                if (string.IsNullOrEmpty(Funcionario[i].SindicatosId.ToString()))
                                {
                                    var taxa = Funcionario[i].TaxaSindical;
                                    var taxasemanal = (taxa / ultimoDiaDoMes.Date.Day) * 14;
                                    salario = salario - taxasemanal;
                                }


                                if (TaxaServicoSindical.Count > 0)
                                {
                                    for (int n = 0; n < TaxaServicoSindical.Count; n++)
                                    {
                                        if (TaxaServicoSindical[n].Competencia.Month == DtPagamento.Date.Value.Month)
                                        {
                                            var taxasemanal = (TaxaServicoSindical[n].TaxaServico / ultimoDiaDoMes.Date.Day) * 14;

                                            salario = salario - taxasemanal;
                                        }
                                    }

                                }

                                var folha = new Folha();
                                folha.FuncionariosId = X.FuncionariosId;
                                folha.Nome = X.Nome;
                                if (X.MetodoPagamento == 1)
                                {
                                    folha.MetodoPagamento = "Cheque pelos correios";
                                }
                                if (X.MetodoPagamento == 2)
                                {
                                    folha.MetodoPagamento = "Cheque em mãos";
                                }
                                if (X.MetodoPagamento == 3)
                                {
                                    folha.MetodoPagamento = "Deposito em conta bancária";
                                }
                                folha.DtPagamento = DtPagamento.Date.Value;
                                folha.Salario = Math.Round((double)salario, 2);

                                ListFolha.Add(folha);

                            }

                            if (Funcionario[i].TipoFuncionario == 2) //Comissionado
                            {



                            }

                            if (Funcionario[i].TipoFuncionario == 3) //Horista
                            {



                            }

                        }
                    }
                
                    GridFolha.LoadFromList(ListFolha);

                }

            }
                catch (Exception M)
            {

                MessageBox.Show(M.Message);
            }
        }           
    }
}
