using ProjectP3.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectP3.MDI
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFuncionario F = new FormFuncionario();
            F.MdiParent = this;
            F.Show();
        }

        private void registroDePontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistroPonto F = new FormRegistroPonto();
            F.MdiParent = this;
            F.Show();
        }

        private void cadastroDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVendas F = new FormVendas();
            F.MdiParent = this;
            F.Show();
        }

        private void folhaDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFolha F = new FormFolha();
            F.MdiParent = this;
            F.Show();
        }
    }
}
