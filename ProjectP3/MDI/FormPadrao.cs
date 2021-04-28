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
    public partial class FormPadrao : Form
    {
        public FormPadrao()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           //Implementar Heranca
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Implementar na heranca
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Implementar na heranca
            panel1.Visible = false;
        }

        private void btn_Retornar_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void GridConsultaP_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Implementar na Heranca
        }
    }
}
