
namespace ProjectP3.Forms
{
    partial class FormFolha
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
            this.GerarFolha = new System.Windows.Forms.Button();
            this.DtPagamento = new ProjectP3.componentes.CmpDataCalendario();
            this.GridFolha = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFolha)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.GridFolha);
            this.panel1.Controls.Add(this.DtPagamento);
            this.panel1.Controls.Add(this.GerarFolha);
            this.panel1.Size = new System.Drawing.Size(555, 397);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(379, 12);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(460, 12);
            // 
            // panelInferior
            // 
            this.panelInferior.Location = new System.Drawing.Point(0, 397);
            this.panelInferior.Size = new System.Drawing.Size(555, 53);
            // 
            // GerarFolha
            // 
            this.GerarFolha.Location = new System.Drawing.Point(12, 30);
            this.GerarFolha.Name = "GerarFolha";
            this.GerarFolha.Size = new System.Drawing.Size(424, 23);
            this.GerarFolha.TabIndex = 0;
            this.GerarFolha.Text = " Gerar";
            this.GerarFolha.UseVisualStyleBackColor = true;
            this.GerarFolha.Click += new System.EventHandler(this.GerarFolha_Click);
            // 
            // DtPagamento
            // 
            this.DtPagamento.BackColor = System.Drawing.SystemColors.Control;
            this.DtPagamento.CorFundo = System.Drawing.SystemColors.Control;
            this.DtPagamento.DataMaxima = new System.DateTime(2109, 12, 31, 0, 0, 0, 0);
            this.DtPagamento.DataMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DtPagamento.Date = null;
            this.DtPagamento.formatoCompetencia = false;
            this.DtPagamento.Location = new System.Drawing.Point(442, 30);
            this.DtPagamento.Name = "DtPagamento";
            this.DtPagamento.Size = new System.Drawing.Size(101, 21);
            this.DtPagamento.TabIndex = 1;
            // 
            // GridFolha
            // 
            this.GridFolha.AllowUserToAddRows = false;
            this.GridFolha.AllowUserToDeleteRows = false;
            this.GridFolha.AllowUserToResizeRows = false;
            this.GridFolha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFolha.Location = new System.Drawing.Point(12, 59);
            this.GridFolha.Name = "GridFolha";
            this.GridFolha.RowHeadersVisible = false;
            this.GridFolha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridFolha.ShowEditingIcon = false;
            this.GridFolha.Size = new System.Drawing.Size(531, 326);
            this.GridFolha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data Pagamento";
            // 
            // FormFolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.MaximizeBox = false;
            this.Name = "FormFolha";
            this.Text = "FormFolha";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridFolha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private componentes.CmpDataCalendario DtPagamento;
        private System.Windows.Forms.Button GerarFolha;
        public System.Windows.Forms.DataGridView GridFolha;
        private System.Windows.Forms.Label label1;
    }
}