﻿
namespace ProjectP3
{
    partial class FormRegistroPonto
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
            this.RegistroPontoId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FuncionariosId1 = new ProjectP3.componentes.CmpBuscaCombinada();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Data = new ProjectP3.componentes.CmpDataCalendario();
            this.Entrada = new System.Windows.Forms.DateTimePicker();
            this.Saida = new System.Windows.Forms.DateTimePicker();
            this.FuncionariosId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Horas = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Horas);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.FuncionariosId);
            this.panel1.Controls.Add(this.RegistroPontoId);
            this.panel1.Size = new System.Drawing.Size(810, 231);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(148, 15);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Location = new System.Drawing.Point(229, 15);
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // panelInferior
            // 
            this.panelInferior.Location = new System.Drawing.Point(0, 183);
            this.panelInferior.Size = new System.Drawing.Size(810, 48);
            // 
            // RegistroPontoId
            // 
            this.RegistroPontoId.Location = new System.Drawing.Point(321, 143);
            this.RegistroPontoId.Name = "RegistroPontoId";
            this.RegistroPontoId.Size = new System.Drawing.Size(100, 20);
            this.RegistroPontoId.TabIndex = 1;
            this.RegistroPontoId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Funcionário";
            // 
            // FuncionariosId1
            // 
            this.FuncionariosId1.BackColor = System.Drawing.Color.Transparent;
            this.FuncionariosId1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FuncionariosId1.CorFundo = System.Drawing.Color.Transparent;
            this.FuncionariosId1.LarguraCodigo = 100;
            this.FuncionariosId1.Location = new System.Drawing.Point(80, 35);
            this.FuncionariosId1.Mascara = "";
            this.FuncionariosId1.Name = "FuncionariosId1";
            this.FuncionariosId1.Size = new System.Drawing.Size(330, 21);
            this.FuncionariosId1.TabIndex = 3;
            this.FuncionariosId1.ConsultarAPI += new ProjectP3.componentes.CmpBuscaCombinada.EventHandlerCustom(this.FuncionariosId1_ConsultarAPI);
            this.FuncionariosId1.ConsultarClick += new System.EventHandler(this.FuncionariosId1_ConsultarClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saída:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Entrada:";
            // 
            // Data
            // 
            this.Data.BackColor = System.Drawing.SystemColors.Control;
            this.Data.CorFundo = System.Drawing.SystemColors.Control;
            this.Data.DataMaxima = new System.DateTime(2110, 12, 31, 0, 0, 0, 0);
            this.Data.DataMinima = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Data.Date = null;
            this.Data.formatoCompetencia = false;
            this.Data.Location = new System.Drawing.Point(80, 62);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(101, 21);
            this.Data.TabIndex = 8;
            // 
            // Entrada
            // 
            this.Entrada.CustomFormat = "HH:mm:00";
            this.Entrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Entrada.Location = new System.Drawing.Point(80, 92);
            this.Entrada.Name = "Entrada";
            this.Entrada.ShowUpDown = true;
            this.Entrada.Size = new System.Drawing.Size(101, 20);
            this.Entrada.TabIndex = 9;
            // 
            // Saida
            // 
            this.Saida.CustomFormat = "HH:mm:00";
            this.Saida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Saida.Location = new System.Drawing.Point(80, 119);
            this.Saida.Name = "Saida";
            this.Saida.ShowUpDown = true;
            this.Saida.Size = new System.Drawing.Size(101, 20);
            this.Saida.TabIndex = 10;
            this.Saida.ValueChanged += new System.EventHandler(this.Saida_ValueChanged);
            // 
            // FuncionariosId
            // 
            this.FuncionariosId.Location = new System.Drawing.Point(187, 63);
            this.FuncionariosId.Name = "FuncionariosId";
            this.FuncionariosId.Size = new System.Drawing.Size(100, 20);
            this.FuncionariosId.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Horas:";
            // 
            // Horas
            // 
            this.Horas.Enabled = false;
            this.Horas.Location = new System.Drawing.Point(78, 143);
            this.Horas.Name = "Horas";
            this.Horas.Size = new System.Drawing.Size(100, 20);
            this.Horas.TabIndex = 12;
            // 
            // FormRegistroPonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 231);
            this.Controls.Add(this.Saida);
            this.Controls.Add(this.Entrada);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FuncionariosId1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormRegistroPonto";
            this.Text = "Registro de Ponto";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.FuncionariosId1, 0);
            this.Controls.SetChildIndex(this.panelInferior, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.Data, 0);
            this.Controls.SetChildIndex(this.Entrada, 0);
            this.Controls.SetChildIndex(this.Saida, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelInferior.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RegistroPontoId;
        private System.Windows.Forms.Label label1;
        private componentes.CmpBuscaCombinada FuncionariosId1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private componentes.CmpDataCalendario Data;
        private System.Windows.Forms.DateTimePicker Entrada;
        private System.Windows.Forms.DateTimePicker Saida;
        private System.Windows.Forms.TextBox FuncionariosId;
        private System.Windows.Forms.TextBox Horas;
        private System.Windows.Forms.Label label5;
    }
}