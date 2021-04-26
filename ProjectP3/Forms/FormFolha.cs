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
            try
            {
                var Funcionario = await new Services<Funcionario>().Get("api/Funcionarios/");



                var dia = DtPagamento.Date.Value.DayOfWeek;
                //var ultimodia = DtPagamento.Date.Value.Days;

                var ultimoDiaDoMes = new DateTime(DtPagamento.Date.Value.Year, DtPagamento.Date.Value.Month, DateTime.DaysInMonth(DtPagamento.Date.Value.Year, DtPagamento.Date.Value.Month));

                for (int i = 0; i < Funcionario.Count; i++)
                {
                    if (Funcionario[i].TipoFuncionario == 1)
                    {
                        if (DtPagamento.Date.Value == ultimoDiaDoMes)
                        {
                            var Assalariado = await new Services<Assalariado>().GetById("api/Assalariado/", Funcionario[i].AssalariadoId.ToString());
                            decimal? salario = 0;

                            if (Funcionario[i].AssalariadoId == Assalariado.AssalariadoId)
                            {
                                if (Funcionario[i].Sindicato == "S")
                                {
                                    var taxa = Funcionario[i].TaxaSindical / 100;
                                    var salarioLiquido = Assalariado.Salario * taxa;

                                    salario = Assalariado.Salario - salarioLiquido;
                                }

                                var X = Funcionario[i];
                                var folha = new Folha();
                                folha.FuncionariosId = X.FuncionariosId;
                                folha.Nome = X.Nome;
                                folha.MetodoPagamento = X.MetodoPagamento.Value;
                                folha.DtPagamento = DtPagamento.Date.Value;
                                folha.Salario = salario;

                                ListFolha.Add(folha);
                            }
                        }

                    }
                    if (Funcionario[i].TipoFuncionario == 2)
                    {

                    }
                    if (Funcionario[i].TipoFuncionario == 3)
                    {
                        var Horista = await new Services<RegistroPonto>().GetByIds("api/Horista/", Funcionario[i].HoristaId.ToString());
                        if (DtPagamento.Date.Value.DayOfWeek.ToString() == "Friday")
                        {
                            
                            

                        }

                    }

                    ListFolha.Count.ToString();
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
