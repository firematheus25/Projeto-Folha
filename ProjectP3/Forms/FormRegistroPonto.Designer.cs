
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
            this.FuncionariosId = new ProjectP3.componentes.CmpBuscaCombinada();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Data = new ProjectP3.componentes.CmpDataCalendario();
            this.Entrada = new System.Windows.Forms.DateTimePicker();
            this.Saida = new System.Windows.Forms.DateTimePicker();
            this.panelInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panelInferior.Location = new System.Drawing.Point(0, 190);
            this.panelInferior.Size = new System.Drawing.Size(421, 48);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(200, 13);
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(119, 13);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // RegistroPontoId
            // 
            this.RegistroPontoId.Location = new System.Drawing.Point(310, 164);
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
            // FuncionariosId
            // 
            this.FuncionariosId.BackColor = System.Drawing.Color.Transparent;
            this.FuncionariosId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FuncionariosId.CorFundo = System.Drawing.Color.Transparent;
            this.FuncionariosId.LarguraCodigo = 100;
            this.FuncionariosId.Location = new System.Drawing.Point(80, 35);
            this.FuncionariosId.Mascara = "";
            this.FuncionariosId.Name = "FuncionariosId";
            this.FuncionariosId.Size = new System.Drawing.Size(330, 21);
            this.FuncionariosId.TabIndex = 3;
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
            this.Entrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Entrada.Location = new System.Drawing.Point(80, 92);
            this.Entrada.Name = "Entrada";
            this.Entrada.ShowUpDown = true;
            this.Entrada.Size = new System.Drawing.Size(101, 20);
            this.Entrada.TabIndex = 9;
            // 
            // Saida
            // 
            this.Saida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Saida.Location = new System.Drawing.Point(80, 119);
            this.Saida.Name = "Saida";
            this.Saida.ShowUpDown = true;
            this.Saida.Size = new System.Drawing.Size(101, 20);
            this.Saida.TabIndex = 10;
            // 
            // FormRegistroPonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 238);
            this.Controls.Add(this.Saida);
            this.Controls.Add(this.Entrada);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FuncionariosId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegistroPontoId);
            this.Name = "FormRegistroPonto";
            this.Text = "Registro de Ponto";
            this.Controls.SetChildIndex(this.RegistroPontoId, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.FuncionariosId, 0);
            this.Controls.SetChildIndex(this.panelInferior, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.Data, 0);
            this.Controls.SetChildIndex(this.Entrada, 0);
            this.Controls.SetChildIndex(this.Saida, 0);
            this.panelInferior.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RegistroPontoId;
        private System.Windows.Forms.Label label1;
        private componentes.CmpBuscaCombinada FuncionariosId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private componentes.CmpDataCalendario Data;
        private System.Windows.Forms.DateTimePicker Entrada;
        private System.Windows.Forms.DateTimePicker Saida;
    }
}