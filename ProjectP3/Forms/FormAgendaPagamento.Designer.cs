﻿
namespace ProjectP3.Forms
{
    partial class FormAgendaPagamento
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
            this.AgendaId = new System.Windows.Forms.TextBox();
            this.Tipo = new System.Windows.Forms.ComboBox();
            this.Dia = new System.Windows.Forms.ComboBox();
            this.DiaSemana = new System.Windows.Forms.ComboBox();
            this.lbl_dia = new System.Windows.Forms.Label();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.agenda = new System.Windows.Forms.TextBox();
            this.panelInferior.SuspendLayout();
            this.AlternaModo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(233, 16);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(314, 16);
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(10, 16);
            // 
            // panelInferior
            // 
            this.panelInferior.Location = new System.Drawing.Point(-2, 183);
            this.panelInferior.Size = new System.Drawing.Size(396, 53);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(236, 12);
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Retornar
            // 
            this.btn_Retornar.Location = new System.Drawing.Point(321, 12);
            // 
            // panel1
            // 
            this.AlternaModo.Controls.Add(this.agenda);
            this.AlternaModo.Controls.Add(this.lbl_Tipo);
            this.AlternaModo.Controls.Add(this.lbl_dia);
            this.AlternaModo.Controls.Add(this.DiaSemana);
            this.AlternaModo.Controls.Add(this.AgendaId);
            this.AlternaModo.Controls.Add(this.Dia);
            this.AlternaModo.Controls.Add(this.Tipo);
            this.AlternaModo.Size = new System.Drawing.Size(396, 238);
            this.AlternaModo.Controls.SetChildIndex(this.panelInferior, 0);
            this.AlternaModo.Controls.SetChildIndex(this.Tipo, 0);
            this.AlternaModo.Controls.SetChildIndex(this.Dia, 0);
            this.AlternaModo.Controls.SetChildIndex(this.AgendaId, 0);
            this.AlternaModo.Controls.SetChildIndex(this.DiaSemana, 0);
            this.AlternaModo.Controls.SetChildIndex(this.lbl_dia, 0);
            this.AlternaModo.Controls.SetChildIndex(this.lbl_Tipo, 0);
            this.AlternaModo.Controls.SetChildIndex(this.agenda, 0);
            // 
            // PalavraChave
            // 
            this.PalavraChave.Size = new System.Drawing.Size(133, 20);
            // 
            // AgendaId
            // 
            this.AgendaId.Location = new System.Drawing.Point(143, 27);
            this.AgendaId.Name = "AgendaId";
            this.AgendaId.Size = new System.Drawing.Size(121, 20);
            this.AgendaId.TabIndex = 1;
            this.AgendaId.Visible = false;
            // 
            // Tipo
            // 
            this.Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tipo.FormattingEnabled = true;
            this.Tipo.Location = new System.Drawing.Point(143, 53);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(121, 21);
            this.Tipo.TabIndex = 2;
            this.Tipo.SelectedIndexChanged += new System.EventHandler(this.Tipo_SelectedIndexChanged);
            // 
            // Dia
            // 
            this.Dia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dia.FormattingEnabled = true;
            this.Dia.Location = new System.Drawing.Point(143, 80);
            this.Dia.Name = "Dia";
            this.Dia.Size = new System.Drawing.Size(121, 21);
            this.Dia.TabIndex = 7;
            this.Dia.SelectedIndexChanged += new System.EventHandler(this.Dia_SelectedIndexChanged);
            // 
            // DiaSemana
            // 
            this.DiaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DiaSemana.FormattingEnabled = true;
            this.DiaSemana.Location = new System.Drawing.Point(143, 80);
            this.DiaSemana.Name = "DiaSemana";
            this.DiaSemana.Size = new System.Drawing.Size(121, 21);
            this.DiaSemana.TabIndex = 8;
            this.DiaSemana.SelectedIndexChanged += new System.EventHandler(this.DiaSemana_SelectedIndexChanged);
            // 
            // lbl_dia
            // 
            this.lbl_dia.AutoSize = true;
            this.lbl_dia.Location = new System.Drawing.Point(111, 83);
            this.lbl_dia.Name = "lbl_dia";
            this.lbl_dia.Size = new System.Drawing.Size(26, 13);
            this.lbl_dia.TabIndex = 9;
            this.lbl_dia.Text = "Dia:";
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Location = new System.Drawing.Point(111, 56);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(31, 13);
            this.lbl_Tipo.TabIndex = 10;
            this.lbl_Tipo.Text = "Tipo:";
            // 
            // agenda
            // 
            this.agenda.Enabled = false;
            this.agenda.Location = new System.Drawing.Point(95, 107);
            this.agenda.Name = "agenda";
            this.agenda.Size = new System.Drawing.Size(213, 20);
            this.agenda.TabIndex = 11;
            // 
            // FormAgendaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 238);
            this.Name = "FormAgendaPagamento";
            this.Text = "Agenda de Pagamento";
            this.panelInferior.ResumeLayout(false);
            this.AlternaModo.ResumeLayout(false);
            this.AlternaModo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.Label lbl_dia;
        private System.Windows.Forms.ComboBox DiaSemana;
        private System.Windows.Forms.ComboBox Dia;
        private System.Windows.Forms.ComboBox Tipo;
        private System.Windows.Forms.TextBox AgendaId;
        private System.Windows.Forms.TextBox agenda;
    }
}