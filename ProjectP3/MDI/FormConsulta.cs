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

namespace ProjectP3.MDI
{
    public partial class FormConsulta : Form
    {
        public FormConsulta()
        {
            InitializeComponent();

            GridConsulta.BuilderColumn("funcionariosId", "Matrícula");
            GridConsulta.BuilderColumn("Nome", "Nome", DataGridViewAutoSizeColumnMode.Fill);
        }

        private async void FormConsulta_Load(object sender, EventArgs e)
        {
            // IMPLEMENTAR NOS FORMS FILHOS 
        }
    }
}
