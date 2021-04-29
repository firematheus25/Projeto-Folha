using miscellaneous.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Humanizer;
using ProjectP3.Services;
using ProjectP3.Others;
using ProjectP3.MDI;

namespace ProjectP3
{
    public partial class FormRegistroPonto : FormPadrao
    {
        public FormRegistroPonto()
        {
            InitializeComponent();
            Entrada.Value = DateTimePicker.MinimumDateTime;
            Saida.Value = DateTimePicker.MinimumDateTime;
            this.GridConsultaP.Size = new System.Drawing.Size(400, 183);

            GridConsultaP.BuilderColumn("RegistroPontoId");
            GridConsultaP.BuilderColumn("funcionariosId", "Matrícula");
            GridConsultaP.BuilderColumn("Nome", "Nome", DataGridViewAutoSizeColumnMode.Fill);
            GridConsultaP.BuilderColumn("DtPonto", "Data", DataGridViewAutoSizeColumnMode.None, "dd/MM/yyyy");

            FuncionariosId.TxtCodigo.Enabled = false;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            RegistroPontoId.Clear();
            Data.Clear();
            Entrada.Value = DateTimePicker.MinimumDateTime;
            Saida.Value = DateTimePicker.MinimumDateTime;
        }

        private async void GridConsultaP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FuncionariosId.Enabled = false;
            var id = GridConsultaP.CurrentRow.Cells["RegistroPontoId"].Value.ToString();
            var Ponto = await new Services<RegistroPonto>().GetById("api/RegistroPontos/Id", id);

            RegistroPontoId.Text = Convert.ToString(Ponto.RegistroPontoId);
            FuncionariosId.TxtCodigo.Text = Convert.ToString(Ponto.FuncionariosId);
            FuncionariosId.TxtDescricao.Text = Ponto.Nome;
            Data.Date = Ponto.DtPonto;
            Entrada.Value = Convert.ToDateTime(Ponto.Entrada);
            Saida.Value = Convert.ToDateTime(Ponto.Saida);
            Horas.Text = Ponto.Horas;


            panel1.Visible = true;



        }

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var Ponto = new RegistroPonto();

                //Ponto.RegistroPontoId = 0;
                Ponto.FuncionariosId = Convert.ToInt32(FuncionariosId.Text);
                Ponto.DtPonto = Data.Date.Value;
                Ponto.Entrada = Entrada.Value.TimeOfDay.ToString();
                Ponto.Saida = Saida.Value.TimeOfDay.ToString();
                Ponto.Horas = Horas.Text;

                var Result = await new Services<RegistroPonto>().Post("api/RegistroPontos", Ponto);
                var tes2 = await Result.Content.ReadAsStringAsync();

            }
            catch (Exception M)
            {

                MessageBox.Show(M.Message);
            }
            

        }

        private void Saida_ValueChanged(object sender, EventArgs e)
        {
            if (Saida.Value == DateTimePicker.MinimumDateTime || Saida.Value.TimeOfDay < Entrada.Value.TimeOfDay)
            {

            }
            if (Saida.Value.TimeOfDay > Entrada.Value.TimeOfDay)
            {
                Horas.Text = Convert.ToString(Saida.Value.TimeOfDay - Entrada.Value.TimeOfDay);
            }
        }

        private void FuncionariosId1_ConsultarClick(object sender, EventArgs e)
        {
            var frmConsulta = new FormConsulta();
            frmConsulta.Owner = this;
            frmConsulta.ShowDialog();
        }

        private async void FuncionariosId1_ConsultarAPI(object sender)
        {

        }

        private async void btn_Buscar_Click(object sender, EventArgs e)
        {
            var pontos = await new Services<RegistroPonto>().Get("api/RegistroPontos");

            GridConsultaP.LoadFromList(pontos);
        }
    }
}
