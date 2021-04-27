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



                var dia = DtPagamento.Date.Value.DayOfWeek;
                //var ultimodia = DtPagamento.Date.Value.Days;

                var ultimoDiaDoMes = new DateTime(DtPagamento.Date.Value.Year, DtPagamento.Date.Value.Month, DateTime.DaysInMonth(DtPagamento.Date.Value.Year, DtPagamento.Date.Value.Month));

                for (int i = 0; i < Funcionario.Count; i++)
                {
                    if (Funcionario[i].TipoFuncionario == 1)//ASSALARIADO
                    {
                        if (DtPagamento.Date.Value == ultimoDiaDoMes)
                        {
                                double? salario = 0;

                                var X = Funcionario[i];
                                if (Funcionario[i].Sindicato == "S")
                                {
                                    var taxa = Funcionario[i].TaxaSindical / 100;
                                    var salarioLiquido = X.Salario * taxa;

                                    salario = X.Salario - salarioLiquido;
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
                                folha.Salario = salario;
                                                                
                                ListFolha.Add(folha);
                            
                        }

                    }
                    if (Funcionario[i].TipoFuncionario == 2)//COMISSIONADO
                    {

                    }
                    if (Funcionario[i].TipoFuncionario == 3)//HORISTA
                    {                        
                        if (DtPagamento.Date.Value.DayOfWeek.ToString() == "Friday")
                        {
                            var RegistroPontos = await new Services<RegistroPonto>().GetByIds("api/RegistroPontos/", Funcionario[i].FuncionariosId.ToString());
                            if (Funcionario[i].FuncionariosId == RegistroPontos[0].FuncionariosId)
                            {
                                var Day = DtPagamento.Date.Value.Day - 6;
                                double? salarioHorista = 0;
                                var Z = Funcionario[i];

                                for (int j = 0; j < RegistroPontos.Count; j++)
                                {
                                    var Y = RegistroPontos[j];
                                    
                                    if (Y.DtPonto.Value.Day >= Day && Y.DtPonto.Value.Day <= DtPagamento.Date.Value.Day)
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

                                if (Funcionario[i].Sindicato == "S")
                                {
                                    var taxa = Funcionario[i].TaxaSindical / 100;
                                    var salarioLiquido = salarioHorista * taxa;

                                    salarioHorista = salarioHorista - salarioLiquido;
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
