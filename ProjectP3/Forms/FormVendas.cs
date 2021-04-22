using miscellaneous.Models;
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
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            VendasId.Clear();
            FuncionariosId1.Clear();
            Data.Clear();
            ValorVenda.Clear();
            PorcentagemVenda.Clear();
            
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

                Vendas.FuncionariosId = Convert.ToInt32(FuncionariosId.Text);
                Vendas.DtVenda = Data.Date.Value;
                Vendas.Valor = ValorVenda.Valor;
                Vendas.Porcentagem = PorcentagemVenda.Valor;


                var teste = await new Services<Vendas>().Post("api/Vendas/", Vendas);
                var tes2 = await teste.Content.ReadAsStringAsync();


            }
            catch (Exception M)
            {
               MessageBox.Show(M.Message);
            }
        }
    }
}
