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

namespace ProjectP3
{
    public partial class FormRegistroPonto : FormPadrao
    {
        public FormRegistroPonto()
        {
            InitializeComponent();
            Entrada.Value = DateTimePicker.MinimumDateTime;
            Saida.Value = DateTimePicker.MinimumDateTime;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            RegistroPontoId.Clear();
            Data.Clear();
            Entrada.Value = DateTimePicker.MinimumDateTime;
            Saida.Value = DateTimePicker.MinimumDateTime;
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

        private void panelInferior_Paint(object sender, PaintEventArgs e)
        {

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
            var frmConsulta = new RegistroPontoConsulta();
            frmConsulta.ShowDialog();
        }

        private async void FuncionariosId1_ConsultarAPI(object sender)
        {

        }
    }
}
