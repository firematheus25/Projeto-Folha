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

                int teste = Convert.ToInt32(Ponto.Saida.Replace(":", "").Trim());

                TimeSpan teste1 = TimeSpan.FromTicks(teste); 

                //var time = Saida.Value.TimeOfDay.Subtract(Entrada.Value.TimeOfDay);

                var Result = await new Services<RegistroPonto>().Post("api/RegistroPontos", Ponto);
                var tes2 = await Result.Content.ReadAsStringAsync();

            }
            catch (Exception M)
            {

                MessageBox.Show(M.Message);
            }
            

        }


    }
}
