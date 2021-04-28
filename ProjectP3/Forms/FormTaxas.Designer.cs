
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
            this.FuncionariosId1 = new ProjectP3.componentes.CmpBuscaCombinada();
            this.label1 = new System.Windows.Forms.Label();
            this.TaxaServico = new System.Windows.Forms.TextBox();
            this.Competencia = new ProjectP3.componentes.CmpDataCalendario();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panelInferior.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(255, 15);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Competencia);
            this.panel1.Controls.Add(this.TaxaServico);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.FuncionariosId1);
            this.panel1.Size = new System.Drawing.Size(421, 236);
            this.panel1.Controls.SetChildIndex(this.panelInferior, 0);
            this.panel1.Controls.SetChildIndex(this.FuncionariosId1, 0);
            this.panel1.Controls.SetChildIndex(this.label6, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.TaxaServico, 0);
            this.panel1.Controls.SetChildIndex(this.Competencia, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.textBox2, 0);
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
            // FuncionariosId1
            // 
            this.FuncionariosId1.BackColor = System.Drawing.Color.Transparent;
            this.FuncionariosId1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FuncionariosId1.CorFundo = System.Drawing.Color.Transparent;
            this.FuncionariosId1.LarguraCodigo = 100;
            this.FuncionariosId1.Location = new System.Drawing.Point(77, 31);
            this.FuncionariosId1.Mascara = "";
            this.FuncionariosId1.Name = "FuncionariosId1";
            this.FuncionariosId1.Size = new System.Drawing.Size(330, 21);
            this.FuncionariosId1.TabIndex = 14;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(314, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 20;
            // 
            // FormTaxas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 236);
            this.Name = "FormTaxas";
            this.Text = "Taxas";
            this.panelInferior.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private componentes.CmpBuscaCombinada FuncionariosId1;
        private System.Windows.Forms.Label label2;
        private componentes.CmpDataCalendario Competencia;
        private System.Windows.Forms.TextBox TaxaServico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}