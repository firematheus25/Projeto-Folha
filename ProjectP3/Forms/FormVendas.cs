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
            FuncionariosId.Clear();
            Data.Clear();
            ValorVenda.Clear();
            PorcentagemVenda.Clear();
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var Vendas = new Vendas();

                //Vendas.VendasId = VendasId.Text.ToString();
               // Vendas.FuncionariosId = FuncionariosId.GetValues<Comissionado>().FuncionariosId;
                Vendas.DtVenda = Data.Date.Value;
                Vendas.Valor = ValorVenda.Valor;
                Vendas.Porcentagem = PorcentagemVenda.Valor;


            }
            catch (Exception M)
            {
               MessageBox.Show(M.Message);
            }
        }
    }
}
