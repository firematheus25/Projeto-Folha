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
            var ListFuncionarios = await new Services<Funcionario>().Get("api/Funcionarios/Horista");


            GridConsulta.LoadFromList(ListFuncionarios);
        }

        private async void GridConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var Id = GridConsulta.CurrentRow.Cells["FuncionariosId"].Value.ToString();
            var funcionario = await new Services<Funcionario>().GetById("api/funcionarios/BuscaCB/", Id);

            var frm = (FormRegistroPonto)this.Owner;

            frm.FuncionariosId1.TxtCodigo.Text = Convert.ToString(funcionario.FuncionariosId);
            frm.FuncionariosId1.TxtDescricao.Text = funcionario.Nome;
            this.Close();
        }
    }
}
