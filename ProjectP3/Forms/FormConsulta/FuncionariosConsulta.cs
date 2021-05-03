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

namespace ProjectP3.Forms.FormConsulta
{
    public partial class FuncionariosConsulta : FormConsult
    {
        public FuncionariosConsulta()
        {
            InitializeComponent();


            GridConsulta.BuilderColumn("funcionariosId", "Matrícula");
            GridConsulta.BuilderColumn("Nome", "Nome", DataGridViewAutoSizeColumnMode.Fill);
        }

        public async override void FormConsulta_Load(object sender, EventArgs e)
        {
            List<Funcionario> ListFuncionarios;
            var t = this.Owner.GetType();
            if (t.Equals(typeof(FormRegistroPonto)))
            {
                ListFuncionarios = await new Services<Funcionario>().Get("api/Funcionarios/Horista");
            }
            else if (t.Equals(typeof(FormVendas)))
            {
                ListFuncionarios = await new Services<Funcionario>().Get("api/Funcionarios/Comissionado");
            }
            else if (t.Equals(typeof(FormTaxas)))
            {
                ListFuncionarios = await new Services<Funcionario>().Get("api/Funcionarios/Sindicatos");
            }
            else if (t.Equals(typeof(FormFuncionario)))
            {

                List<Sindicato> ListSindicato;
                ListSindicato = await new Services<Sindicato>().Get("api/Sindicatos");
                GridConsulta.LoadFromList(ListSindicato);
                return;
            }
            else
            {
                ListFuncionarios = null;
            }



            GridConsulta.LoadFromList(ListFuncionarios);
        }

        public async override void GridConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var t = this.Owner.GetType();
            if (t.Equals(typeof(FormFuncionario)))
            {
                var IdSind = GridConsulta.CurrentRow.Cells["SindicatosId"].Value.ToString();
                var Sindicato = await new Services<Sindicato>().GetById("api/Sindicatos/Id", IdSind);

                var frmSind = (FormFuncionario)this.Owner;

                frmSind.FuncionarioSindicalId.TxtCodigo.Text = Convert.ToString(Sindicato.SindicatosId);
                frmSind.FuncionarioSindicalId.TxtDescricao.Text = Sindicato.Nome;

            }
            else
            {
                var Id = GridConsulta.CurrentRow.Cells["FuncionariosId"].Value.ToString();
                var funcionario = await new Services<Funcionario>().GetById("api/funcionarios/BuscaCB/", Id);

                var frm = (FormRegistroPonto)this.Owner;

                frm.FuncionariosId.TxtCodigo.Text = Convert.ToString(funcionario.FuncionariosId);
                frm.FuncionariosId.TxtDescricao.Text = funcionario.Nome;
                this.Close();
            }
            this.Close();

        }
    }
}
