
namespace ProjectP3
{
    partial class FormVendas
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
            this.FuncionariosId1 = new ProjectP3.componentes.CmpBuscaCombinada();
            this.Funcionarios = new System.Windows.Forms.Label();
            this.DtVenda = new ProjectP3.componentes.CmpDataCalendario();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ValorVenda = new ProjectP3.componentes.CmpNumerico();
            this.label1 = new System.Windows.Forms.Label();
            this.PorcentagemVenda = new ProjectP3.componentes.CmpNumerico();
            this.VendasId = new System.Windows.Forms.TextBox();
            this.FuncionariosId = new System.Windows.Forms.TextBox();
            this.panelInferior.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(249, 15);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Location = new System.Drawing.Point(330, 15);
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // panelInferior
            // 
            this.panelInferior.Location = new System.Drawing.Point(0, 185);
            this.panelInferior.Size = new System.Drawing.Size(435, 46);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(279, 13);
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            this.GridConsultaP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridConsultaP_CellDoubleClick);
            // 
            // btn_Retornar
            // 
            this.btn_Retornar.Location = new System.Drawing.Point(348, 12);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PorcentagemVenda);
            this.panel1.Controls.Add(this.VendasId);
            this.panel1.Controls.Add(this.ValorVenda);
            this.panel1.Controls.Add(this.FuncionariosId);
            this.panel1.Controls.Add(this.FuncionariosId1);
            this.panel1.Controls.Add(this.DtVenda);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Funcionarios);
            this.panel1.Size = new System.Drawing.Size(421, 236);
            this.panel1.Controls.SetChildIndex(this.Funcionarios, 0);
            this.panel1.Controls.SetChildIndex(this.label4, 0);
            this.panel1.Controls.SetChildIndex(this.DtVenda, 0);
            this.panel1.Controls.SetChildIndex(this.FuncionariosId1, 0);
            this.panel1.Controls.SetChildIndex(this.FuncionariosId, 0);
            this.panel1.Controls.SetChildIndex(this.ValorVenda, 0);
            this.panel1.Controls.SetChildIndex(this.VendasId, 0);
            this.panel1.Controls.SetChildIndex(this.panelInferior, 0);
            this.panel1.Controls.SetChildIndex(this.PorcentagemVenda, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            // 
            // PalavraChave
            // 
            this.PalavraChave.Size = new System.Drawing.Size(178, 20);
            // 
            // FuncionariosId1
            // 
            this.FuncionariosId1.BackColor = System.Drawing.Color.Transparent;
            this.FuncionariosId1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FuncionariosId1.CorFundo = System.Drawing.Color.Transparent;
            this.FuncionariosId1.LarguraCodigo = 100;
            this.FuncionariosId1.Location = new System.Drawing.Point(87, 15);
            this.FuncionariosId1.Mascara = "";
            this.FuncionariosId1.Name = "FuncionariosId1";
            this.FuncionariosId1.Size = new System.Drawing.Size(320, 21);
            this.FuncionariosId1.TabIndex = 1;
            this.FuncionariosId1.ConsultarAPI += new ProjectP3.componentes.CmpBuscaCombinada.EventHandlerCustom(this.FuncionariosId1_ConsultarAPI);
            this.FuncionariosId1.ConsultarClick += new System.EventHandler(this.FuncionariosId1_ConsultarClick);
            // 
            // Funcionarios
            // 
            this.Funcionarios.AutoSize = true;
            this.Funcionarios.Location = new System.Drawing.Point(10, 19);
            this.Funcionarios.Name = "Funcionarios";
            this.Funcionarios.Size = new System.Drawing.Size(65, 13);
            this.Funcionarios.TabIndex = 2;
            this.Funcionarios.Text = "Funcionário:";
            // 
            // DtVenda
            // 
            this.DtVenda.BackColor = System.Drawing.SystemColors.Control;
            this.DtVenda.CorFundo = System.Drawing.SystemColors.Control;
            this.DtVenda.DataMaxima = new System.DateTime(2109, 12, 31, 0, 0, 0, 0);
            this.DtVenda.DataMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtVenda.Date = null;
            this.DtVenda.formatoCompetencia = false;
            this.DtVenda.Location = new System.Drawing.Point(87, 42);
            this.DtVenda.Name = "DtVenda";
            this.DtVenda.Size = new System.Drawing.Size(101, 21);
            this.DtVenda.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "R$:";
            // 
            // ValorVenda
            // 
            this.ValorVenda.CasasDecimais = 2;
            this.ValorVenda.Location = new System.Drawing.Point(88, 69);
            this.ValorVenda.Name = "ValorVenda";
            this.ValorVenda.Size = new System.Drawing.Size(100, 20);
            this.ValorVenda.TabIndex = 6;
            this.ValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ValorVenda.Valor = null;
            this.ValorVenda.ValorMaximo = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Porcentagem:";
            // 
            // PorcentagemVenda
            // 
            this.PorcentagemVenda.CasasDecimais = 2;
            this.PorcentagemVenda.Enabled = false;
            this.PorcentagemVenda.Location = new System.Drawing.Point(88, 95);
            this.PorcentagemVenda.Name = "PorcentagemVenda";
            this.PorcentagemVenda.Size = new System.Drawing.Size(100, 20);
            this.PorcentagemVenda.TabIndex = 8;
            this.PorcentagemVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PorcentagemVenda.Valor = null;
            this.PorcentagemVenda.ValorMaximo = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            // 
            // VendasId
            // 
            this.VendasId.Location = new System.Drawing.Point(277, 69);
            this.VendasId.Name = "VendasId";
            this.VendasId.Size = new System.Drawing.Size(100, 20);
            this.VendasId.TabIndex = 9;
            this.VendasId.Visible = false;
            // 
            // FuncionariosId
            // 
            this.FuncionariosId.Location = new System.Drawing.Point(277, 43);
            this.FuncionariosId.Name = "FuncionariosId";
            this.FuncionariosId.Size = new System.Drawing.Size(100, 20);
            this.FuncionariosId.TabIndex = 10;
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 236);
            this.MaximizeBox = false;
            this.Name = "FormVendas";
            this.Text = "Vendas";
            this.panelInferior.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private componentes.CmpBuscaCombinada FuncionariosId1;
        private System.Windows.Forms.Label Funcionarios;
        private componentes.CmpDataCalendario DtVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private componentes.CmpNumerico ValorVenda;
        private System.Windows.Forms.Label label1;
        private componentes.CmpNumerico PorcentagemVenda;
        private System.Windows.Forms.TextBox VendasId;
        private System.Windows.Forms.TextBox FuncionariosId;
    }
}