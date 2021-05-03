using miscellaneous.Models;
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

namespace ProjectP3.Forms
{
    public partial class FormSindicato : FormPadrao
    {
        public FormSindicato()
        {
            InitializeComponent();
            GridConsultaP.BuilderColumn("SindicatosId");
            GridConsultaP.BuilderColumn("Nome", "Sindicato", DataGridViewAutoSizeColumnMode.Fill);

            this.GridConsultaP.Size = new System.Drawing.Size(367, 140);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            SindicatosId.Clear();
            Nome.Clear();
        }

        public async override void GridConsultaP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {                
                var id = GridConsultaP.CurrentRow.Cells["SindicatosId"].Value.ToString();
                var Sindicato = await new Services<Sindicato>().GetById("api/Sindicatos/Id", id);

                SindicatosId.Text = Sindicato.SindicatosId.ToString();
                Nome.Text = Sindicato.Nome;

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
                Sindicato Sindicato = new Sindicato();                
                Sindicato.Nome = Nome.Text;

                if (string.IsNullOrEmpty(SindicatosId.Text))
                {
                    var result = await new Services<Sindicato>().Post("api/Sindicatos", Sindicato);
                    if (result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Inserido com Sucesso.");

                    }
                }
                else
                {
                    Sindicato.SindicatosId = Convert.ToInt32(SindicatosId.Text);
                    var result = await new Services<Sindicato>().Put("api/Sindicatos", Sindicato);
                    if (result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Alterado com Sucesso.");

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
            var Sindicato = await new Services<Sindicato>().Get("api/Sindicatos");

            GridConsultaP.LoadFromList(Sindicato);
        }
    }
}
