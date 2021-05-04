using miscellaneous.Models;
using ProjectP3.Forms.FormConsulta;
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
    public partial class FormVendas : FormPadrao
    {
        public FormVendas()
        {
            InitializeComponent();

            this.GridConsultaP.Size = new System.Drawing.Size(400, 183);
            GridConsultaP.BuilderColumn("VendasId");
            GridConsultaP.BuilderColumn("funcionariosId", "Matrícula");
            GridConsultaP.BuilderColumn("Nome", "Nome", DataGridViewAutoSizeColumnMode.Fill);
            GridConsultaP.BuilderColumn("ValorVenda", "R$");
            GridConsultaP.BuilderColumn("DtVenda", "Data", DataGridViewAutoSizeColumnMode.None, "dd/MM/yyyy");

            FuncionariosId.TxtCodigo.Enabled = false;
        }

        public override void LimpaCadastro()
        {
            VendasId.Clear();
            FuncionariosId.Clear();
            DtVenda.Clear();
            ValorVenda.Clear();
            PorcentagemVenda.Clear();
            Comissao.Clear();
            FuncionariosId.Enabled = true;
            FuncionariosId.TxtCodigo.Enabled = false;
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCadastro();            
        }

        public override async void GridConsultaP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                LimpaCadastro();
                FuncionariosId.Enabled = false;
                var id = GridConsultaP.CurrentRow.Cells["VendasId"].Value.ToString();
                var venda = await new Services<Vendas>().GetById("api/Vendas/Id", id);

                VendasId.Text = Convert.ToString(venda.VendasId);
                FuncionariosId.TxtCodigo.Text = Convert.ToString(venda.FuncionariosId);
                FuncionariosId.TxtDescricao.Text = venda.Nome;
                DtVenda.Date = venda.DtVenda;
                ValorVenda.Text = Convert.ToString(venda.ValorVenda);
                PorcentagemVenda.Text = Convert.ToString(venda.Porcentagem);
                Comissao.Text = Convert.ToString(venda.Comissao);

                AlternaModo.Visible = true;

            }
            catch (Exception M)
            {

                MessageBox.Show(M.Message);
            }

        }


        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var Vendas = new Vendas();

                if (!string.IsNullOrEmpty(VendasId.Text))
                {
                    Vendas.VendasId = Convert.ToInt32(VendasId.Text);
                }

                Vendas.FuncionariosId = Convert.ToInt32(FuncionariosId.TxtCodigo.Text);
                Vendas.Nome = FuncionariosId.TxtDescricao.Text;
                Vendas.DtVenda = DtVenda.Date.Value;
                Vendas.ValorVenda = (double?)ValorVenda.Valor;
                Vendas.Porcentagem = (double?)PorcentagemVenda.Valor;
                Vendas.Comissao = (double?)Comissao.Valor;
    
                if (string.IsNullOrEmpty(VendasId.Text))
                {
                    var Result = await new Services<Vendas>().Post("api/Vendas/", Vendas);
                    if (Result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Inserido com sucesso.");

                    }
                }
                else
                {
                    var Result = await new Services<Vendas>().Put("api/Vendas/", Vendas);
                    if (Result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Alterado com sucesso.");

                    }

                }
               


            }
            catch (Exception M)
            {
               MessageBox.Show(M.Message);
            }

        }

        private async void btn_Buscar_Click(object sender, EventArgs e)
        {
            var pontos = await new Services<Vendas>().Get("api/Vendas");

            GridConsultaP.LoadFromList(pontos);
        }

        private void FuncionariosId_ConsultarClick(object sender, EventArgs e)
        {
            var frmConsulta = new FuncionariosConsulta();
            frmConsulta.Owner = this;
            frmConsulta.ShowDialog();
        }

        private void FuncionariosId_ConsultarAPI(object sender) {    }

        private void ValorVenda_TextChanged(object sender, EventArgs e)
        {
            var valorcomissao = Convert.ToDouble(PorcentagemVenda.Text) / 100;
            Comissao.Valor = (decimal?)(Convert.ToDouble(ValorVenda.Text) * valorcomissao);
        }
    }
}
