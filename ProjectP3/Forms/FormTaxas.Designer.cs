
namespace ProjectP3.Forms
{
    partial class FormTaxas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.FuncionariosId = new ProjectP3.componentes.CmpBuscaCombinada();
            this.label1 = new System.Windows.Forms.Label();
            this.TaxaServico = new System.Windows.Forms.TextBox();
            this.Competencia = new ProjectP3.componentes.CmpDataCalendario();
            this.label2 = new System.Windows.Forms.Label();
            this.TaxaServicoId = new System.Windows.Forms.TextBox();
            this.panelInferior.SuspendLayout();
            this.AlternaModo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(255, 15);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(336, 15);
            // 
            // panelInferior
            // 
            this.panelInferior.Location = new System.Drawing.Point(-2, 186);
            this.panelInferior.Size = new System.Drawing.Size(421, 48);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(261, 12);
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Retornar
            // 
            this.btn_Retornar.Location = new System.Drawing.Point(346, 12);
            // 
            // AlternaModo
            // 
            this.AlternaModo.Controls.Add(this.TaxaServicoId);
            this.AlternaModo.Controls.Add(this.label2);
            this.AlternaModo.Controls.Add(this.Competencia);
            this.AlternaModo.Controls.Add(this.TaxaServico);
            this.AlternaModo.Controls.Add(this.label1);
            this.AlternaModo.Controls.Add(this.label6);
            this.AlternaModo.Controls.Add(this.FuncionariosId);
            this.AlternaModo.Size = new System.Drawing.Size(421, 236);
            this.AlternaModo.Controls.SetChildIndex(this.panelInferior, 0);
            this.AlternaModo.Controls.SetChildIndex(this.FuncionariosId, 0);
            this.AlternaModo.Controls.SetChildIndex(this.label6, 0);
            this.AlternaModo.Controls.SetChildIndex(this.label1, 0);
            this.AlternaModo.Controls.SetChildIndex(this.TaxaServico, 0);
            this.AlternaModo.Controls.SetChildIndex(this.Competencia, 0);
            this.AlternaModo.Controls.SetChildIndex(this.label2, 0);
            this.AlternaModo.Controls.SetChildIndex(this.TaxaServicoId, 0);
            // 
            // PalavraChave
            // 
            this.PalavraChave.Size = new System.Drawing.Size(158, 20);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Funcionário";
            // 
            // FuncionariosId
            // 
            this.FuncionariosId.BackColor = System.Drawing.Color.Transparent;
            this.FuncionariosId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FuncionariosId.CorFundo = System.Drawing.Color.Transparent;
            this.FuncionariosId.LarguraCodigo = 100;
            this.FuncionariosId.Location = new System.Drawing.Point(77, 31);
            this.FuncionariosId.Mascara = "";
            this.FuncionariosId.Name = "FuncionariosId";
            this.FuncionariosId.Size = new System.Drawing.Size(330, 21);
            this.FuncionariosId.TabIndex = 14;
            this.FuncionariosId.ConsultarAPI += new ProjectP3.componentes.CmpBuscaCombinada.EventHandlerCustom(this.FuncionariosId_ConsultarAPI);
            this.FuncionariosId.ConsultarClick += new System.EventHandler(this.FuncionariosId_ConsultarClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Taxa Serviço:";
            // 
            // TaxaServico
            // 
            this.TaxaServico.Location = new System.Drawing.Point(77, 58);
            this.TaxaServico.Name = "TaxaServico";
            this.TaxaServico.Size = new System.Drawing.Size(100, 20);
            this.TaxaServico.TabIndex = 17;
            // 
            // Competencia
            // 
            this.Competencia.BackColor = System.Drawing.SystemColors.Control;
            this.Competencia.CorFundo = System.Drawing.SystemColors.Control;
            this.Competencia.DataMaxima = new System.DateTime(2609, 12, 31, 0, 0, 0, 0);
            this.Competencia.DataMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Competencia.Date = null;
            this.Competencia.formatoCompetencia = true;
            this.Competencia.Location = new System.Drawing.Point(77, 84);
            this.Competencia.Name = "Competencia";
            this.Competencia.Size = new System.Drawing.Size(100, 21);
            this.Competencia.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Competência:";
            // 
            // TaxaServicoId
            // 
            this.TaxaServicoId.Location = new System.Drawing.Point(314, 160);
            this.TaxaServicoId.Name = "TaxaServicoId";
            this.TaxaServicoId.Size = new System.Drawing.Size(100, 20);
            this.TaxaServicoId.TabIndex = 20;
            this.TaxaServicoId.Visible = false;
            // 
            // FormTaxas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 236);
            this.Name = "FormTaxas";
            this.Text = "Taxas";
            this.panelInferior.ResumeLayout(false);
            this.AlternaModo.ResumeLayout(false);
            this.AlternaModo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private componentes.CmpDataCalendario Competencia;
        private System.Windows.Forms.TextBox TaxaServico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TaxaServicoId;
        public componentes.CmpBuscaCombinada FuncionariosId;
    }
}