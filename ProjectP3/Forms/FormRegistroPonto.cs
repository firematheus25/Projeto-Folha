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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var Ponto = new Ponto();

            Ponto.RegistroPontoId = 0;
            Ponto.FuncionariosId = 1;
            Ponto.Data = Data.Date.Value;
            Ponto.HoraChegada = Entrada.Value.TimeOfDay;
            Ponto.HoraSaida = Saida.Value.TimeOfDay;

            var time = Saida.Value.TimeOfDay.Subtract(Entrada.Value.TimeOfDay);
            MessageBox.Show(time.ToString());


            

        }


    }
}
