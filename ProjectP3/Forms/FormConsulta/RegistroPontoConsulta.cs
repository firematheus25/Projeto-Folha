using miscellaneous.Models;
using ProjectP3.MDI;
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

namespace ProjectP3
{
    public partial class RegistroPontoConsulta : FormConsulta
    {
        public RegistroPontoConsulta()
        {
            InitializeComponent();
        }

        private async void RegistroPontoConsulta_Load(object sender, EventArgs e)
        {
            var ListFuncionarios = await new Services<Funcionario>().Get("api/Funcionarios/");


            GridConsulta.LoadFromList(ListFuncionarios);
        }

        private void GridConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Teste");
        }
    }
}
