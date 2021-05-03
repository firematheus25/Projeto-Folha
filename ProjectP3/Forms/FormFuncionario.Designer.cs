
namespace ProjectP3
{
    partial class FormFuncionario
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
            this.FuncionariosId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MetodoPagamento = new System.Windows.Forms.ComboBox();
            this.Assalariado = new System.Windows.Forms.RadioButton();
            this.Comissionado = new System.Windows.Forms.RadioButton();
            this.Horista = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Endereco = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.TextBox();
            this.Complemento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Bairro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UF = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Cidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Rua = new System.Windows.Forms.TextBox();
            this.Cep = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Conta = new System.Windows.Forms.TextBox();
            this.Agencia = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Operacao = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Banco = new System.Windows.Forms.TextBox();
            this.lbl_ValorHora = new System.Windows.Forms.Label();
            this.ValorHora = new System.Windows.Forms.TextBox();
            this.lbl_TaxaComissao = new System.Windows.Forms.Label();
            this.TaxaComissao = new System.Windows.Forms.TextBox();
            this.lbl_Salario = new System.Windows.Forms.Label();
            this.Salario = new ProjectP3.componentes.CmpNumerico();
            this.ComissionadoId = new System.Windows.Forms.TextBox();
            this.AssalariadoId = new System.Windows.Forms.TextBox();
            this.HoristaId = new System.Windows.Forms.TextBox();
            this.lbl_TxSindical = new System.Windows.Forms.Label();
            this.TaxaSindical = new System.Windows.Forms.TextBox();
            this.FuncionarioSindicalId = new ProjectP3.componentes.CmpBuscaCombinada();
            this.AgendaId = new ProjectP3.componentes.CmpBuscaCombinada();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panelInferior.SuspendLayout();
            this.AlternaModo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Endereco.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(357, 16);
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(438, 16);
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // panelInferior
            // 
            this.panelInferior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInferior.Location = new System.Drawing.Point(-1, 453);
            this.panelInferior.Size = new System.Drawing.Size(540, 46);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(400, 13);
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Retornar
            // 
            this.btn_Retornar.Location = new System.Drawing.Point(469, 13);
            // 
            // AlternaModo
            // 
            this.AlternaModo.Controls.Add(this.label17);
            this.AlternaModo.Controls.Add(this.label16);
            this.AlternaModo.Controls.Add(this.FuncionarioSindicalId);
            this.AlternaModo.Controls.Add(this.AgendaId);
            this.AlternaModo.Controls.Add(this.lbl_TxSindical);
            this.AlternaModo.Controls.Add(this.TaxaSindical);
            this.AlternaModo.Controls.Add(this.groupBox1);
            this.AlternaModo.Controls.Add(this.FuncionariosId);
            this.AlternaModo.Controls.Add(this.HoristaId);
            this.AlternaModo.Controls.Add(this.label1);
            this.AlternaModo.Controls.Add(this.AssalariadoId);
            this.AlternaModo.Controls.Add(this.Nome);
            this.AlternaModo.Controls.Add(this.ComissionadoId);
            this.AlternaModo.Controls.Add(this.label7);
            this.AlternaModo.Controls.Add(this.Salario);
            this.AlternaModo.Controls.Add(this.label8);
            this.AlternaModo.Controls.Add(this.MetodoPagamento);
            this.AlternaModo.Controls.Add(this.lbl_Salario);
            this.AlternaModo.Controls.Add(this.tabControl1);
            this.AlternaModo.Controls.Add(this.lbl_TaxaComissao);
            this.AlternaModo.Controls.Add(this.ValorHora);
            this.AlternaModo.Controls.Add(this.TaxaComissao);
            this.AlternaModo.Controls.Add(this.lbl_ValorHora);
            this.AlternaModo.Size = new System.Drawing.Size(541, 501);
            this.AlternaModo.Controls.SetChildIndex(this.lbl_ValorHora, 0);
            this.AlternaModo.Controls.SetChildIndex(this.TaxaComissao, 0);
            this.AlternaModo.Controls.SetChildIndex(this.ValorHora, 0);
            this.AlternaModo.Controls.SetChildIndex(this.lbl_TaxaComissao, 0);
            this.AlternaModo.Controls.SetChildIndex(this.tabControl1, 0);
            this.AlternaModo.Controls.SetChildIndex(this.lbl_Salario, 0);
            this.AlternaModo.Controls.SetChildIndex(this.MetodoPagamento, 0);
            this.AlternaModo.Controls.SetChildIndex(this.label8, 0);
            this.AlternaModo.Controls.SetChildIndex(this.Salario, 0);
            this.AlternaModo.Controls.SetChildIndex(this.label7, 0);
            this.AlternaModo.Controls.SetChildIndex(this.ComissionadoId, 0);
            this.AlternaModo.Controls.SetChildIndex(this.Nome, 0);
            this.AlternaModo.Controls.SetChildIndex(this.AssalariadoId, 0);
            this.AlternaModo.Controls.SetChildIndex(this.label1, 0);
            this.AlternaModo.Controls.SetChildIndex(this.HoristaId, 0);
            this.AlternaModo.Controls.SetChildIndex(this.FuncionariosId, 0);
            this.AlternaModo.Controls.SetChildIndex(this.groupBox1, 0);
            this.AlternaModo.Controls.SetChildIndex(this.TaxaSindical, 0);
            this.AlternaModo.Controls.SetChildIndex(this.panelInferior, 0);
            this.AlternaModo.Controls.SetChildIndex(this.lbl_TxSindical, 0);
            this.AlternaModo.Controls.SetChildIndex(this.AgendaId, 0);
            this.AlternaModo.Controls.SetChildIndex(this.FuncionarioSindicalId, 0);
            this.AlternaModo.Controls.SetChildIndex(this.label16, 0);
            this.AlternaModo.Controls.SetChildIndex(this.label17, 0);
            // 
            // PalavraChave
            // 
            this.PalavraChave.Location = new System.Drawing.Point(109, 15);
            // 
            // lbl_palavrachave
            // 
            this.lbl_palavrachave.Location = new System.Drawing.Point(12, 18);
            // 
            // FuncionariosId
            // 
            this.FuncionariosId.Enabled = false;
            this.FuncionariosId.Location = new System.Drawing.Point(114, 71);
            this.FuncionariosId.Name = "FuncionariosId";
            this.FuncionariosId.Size = new System.Drawing.Size(100, 20);
            this.FuncionariosId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matrícula:";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(114, 97);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(327, 20);
            this.Nome.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cep:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Método Pagemento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nome:";
            // 
            // MetodoPagamento
            // 
            this.MetodoPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MetodoPagamento.FormattingEnabled = true;
            this.MetodoPagamento.Location = new System.Drawing.Point(114, 177);
            this.MetodoPagamento.Name = "MetodoPagamento";
            this.MetodoPagamento.Size = new System.Drawing.Size(100, 21);
            this.MetodoPagamento.TabIndex = 10;
            // 
            // Assalariado
            // 
            this.Assalariado.AutoSize = true;
            this.Assalariado.Location = new System.Drawing.Point(24, 19);
            this.Assalariado.Name = "Assalariado";
            this.Assalariado.Size = new System.Drawing.Size(79, 17);
            this.Assalariado.TabIndex = 11;
            this.Assalariado.TabStop = true;
            this.Assalariado.Text = "Assalariado";
            this.Assalariado.UseVisualStyleBackColor = true;
            this.Assalariado.CheckedChanged += new System.EventHandler(this.Assalariado_CheckedChanged);
            // 
            // Comissionado
            // 
            this.Comissionado.AutoSize = true;
            this.Comissionado.Location = new System.Drawing.Point(210, 19);
            this.Comissionado.Name = "Comissionado";
            this.Comissionado.Size = new System.Drawing.Size(90, 17);
            this.Comissionado.TabIndex = 12;
            this.Comissionado.TabStop = true;
            this.Comissionado.Text = "Comissionado";
            this.Comissionado.UseVisualStyleBackColor = true;
            this.Comissionado.CheckedChanged += new System.EventHandler(this.Comissionado_CheckedChanged);
            // 
            // Horista
            // 
            this.Horista.AutoSize = true;
            this.Horista.Location = new System.Drawing.Point(431, 19);
            this.Horista.Name = "Horista";
            this.Horista.Size = new System.Drawing.Size(58, 17);
            this.Horista.TabIndex = 13;
            this.Horista.TabStop = true;
            this.Horista.Text = "Horista";
            this.Horista.UseVisualStyleBackColor = true;
            this.Horista.CheckedChanged += new System.EventHandler(this.Horista_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Horista);
            this.groupBox1.Controls.Add(this.Assalariado);
            this.groupBox1.Controls.Add(this.Comissionado);
            this.groupBox1.Location = new System.Drawing.Point(3, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 55);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Funcionário";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Endereco);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 302);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(517, 145);
            this.tabControl1.TabIndex = 17;
            // 
            // Endereco
            // 
            this.Endereco.BackColor = System.Drawing.Color.Transparent;
            this.Endereco.Controls.Add(this.label4);
            this.Endereco.Controls.Add(this.Numero);
            this.Endereco.Controls.Add(this.Complemento);
            this.Endereco.Controls.Add(this.label3);
            this.Endereco.Controls.Add(this.Bairro);
            this.Endereco.Controls.Add(this.label2);
            this.Endereco.Controls.Add(this.UF);
            this.Endereco.Controls.Add(this.label12);
            this.Endereco.Controls.Add(this.Cidade);
            this.Endereco.Controls.Add(this.label11);
            this.Endereco.Controls.Add(this.label10);
            this.Endereco.Controls.Add(this.Rua);
            this.Endereco.Controls.Add(this.Cep);
            this.Endereco.Controls.Add(this.label6);
            this.Endereco.Location = new System.Drawing.Point(4, 22);
            this.Endereco.Name = "Endereco";
            this.Endereco.Padding = new System.Windows.Forms.Padding(3);
            this.Endereco.Size = new System.Drawing.Size(509, 119);
            this.Endereco.TabIndex = 0;
            this.Endereco.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Complemento:";
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(310, 13);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(48, 20);
            this.Numero.TabIndex = 35;
            // 
            // Complemento
            // 
            this.Complemento.Location = new System.Drawing.Point(84, 92);
            this.Complemento.Name = "Complemento";
            this.Complemento.Size = new System.Drawing.Size(419, 20);
            this.Complemento.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Bairro:";
            // 
            // Bairro
            // 
            this.Bairro.Location = new System.Drawing.Point(318, 66);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(185, 20);
            this.Bairro.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "UF:";
            // 
            // UF
            // 
            this.UF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UF.FormattingEnabled = true;
            this.UF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.UF.Location = new System.Drawing.Point(452, 13);
            this.UF.Name = "UF";
            this.UF.Size = new System.Drawing.Size(51, 21);
            this.UF.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Cidade:";
            // 
            // Cidade
            // 
            this.Cidade.Location = new System.Drawing.Point(84, 66);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(185, 20);
            this.Cidade.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(283, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Nr:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Rua:";
            // 
            // Rua
            // 
            this.Rua.Location = new System.Drawing.Point(84, 40);
            this.Rua.Name = "Rua";
            this.Rua.Size = new System.Drawing.Size(419, 20);
            this.Rua.TabIndex = 8;
            // 
            // Cep
            // 
            this.Cep.Location = new System.Drawing.Point(84, 14);
            this.Cep.Name = "Cep";
            this.Cep.Size = new System.Drawing.Size(100, 20);
            this.Cep.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.Conta);
            this.tabPage2.Controls.Add(this.Agencia);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.Operacao);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.Banco);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(509, 119);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dados Bancários";
            // 
            // Conta
            // 
            this.Conta.Location = new System.Drawing.Point(224, 49);
            this.Conta.Name = "Conta";
            this.Conta.Size = new System.Drawing.Size(100, 20);
            this.Conta.TabIndex = 36;
            // 
            // Agencia
            // 
            this.Agencia.Location = new System.Drawing.Point(63, 50);
            this.Agencia.Name = "Agencia";
            this.Agencia.Size = new System.Drawing.Size(100, 20);
            this.Agencia.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(335, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Operação:";
            // 
            // Operacao
            // 
            this.Operacao.Location = new System.Drawing.Point(398, 50);
            this.Operacao.Name = "Operacao";
            this.Operacao.Size = new System.Drawing.Size(100, 20);
            this.Operacao.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(180, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Conta:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Agência:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Banco";
            // 
            // Banco
            // 
            this.Banco.Location = new System.Drawing.Point(63, 21);
            this.Banco.Name = "Banco";
            this.Banco.Size = new System.Drawing.Size(435, 20);
            this.Banco.TabIndex = 1;
            // 
            // lbl_ValorHora
            // 
            this.lbl_ValorHora.AutoSize = true;
            this.lbl_ValorHora.Location = new System.Drawing.Point(10, 210);
            this.lbl_ValorHora.Name = "lbl_ValorHora";
            this.lbl_ValorHora.Size = new System.Drawing.Size(78, 13);
            this.lbl_ValorHora.TabIndex = 19;
            this.lbl_ValorHora.Text = "Valor por Hora:";
            // 
            // ValorHora
            // 
            this.ValorHora.Location = new System.Drawing.Point(114, 204);
            this.ValorHora.Name = "ValorHora";
            this.ValorHora.Size = new System.Drawing.Size(100, 20);
            this.ValorHora.TabIndex = 18;
            // 
            // lbl_TaxaComissao
            // 
            this.lbl_TaxaComissao.AutoSize = true;
            this.lbl_TaxaComissao.Location = new System.Drawing.Point(7, 233);
            this.lbl_TaxaComissao.Name = "lbl_TaxaComissao";
            this.lbl_TaxaComissao.Size = new System.Drawing.Size(82, 13);
            this.lbl_TaxaComissao.TabIndex = 21;
            this.lbl_TaxaComissao.Text = "Taxa Comissão:";
            // 
            // TaxaComissao
            // 
            this.TaxaComissao.Location = new System.Drawing.Point(114, 230);
            this.TaxaComissao.Name = "TaxaComissao";
            this.TaxaComissao.Size = new System.Drawing.Size(100, 20);
            this.TaxaComissao.TabIndex = 20;
            // 
            // lbl_Salario
            // 
            this.lbl_Salario.AutoSize = true;
            this.lbl_Salario.Location = new System.Drawing.Point(10, 210);
            this.lbl_Salario.Name = "lbl_Salario";
            this.lbl_Salario.Size = new System.Drawing.Size(42, 13);
            this.lbl_Salario.TabIndex = 23;
            this.lbl_Salario.Text = "Salário:";
            // 
            // Salario
            // 
            this.Salario.CasasDecimais = 2;
            this.Salario.Location = new System.Drawing.Point(114, 204);
            this.Salario.Name = "Salario";
            this.Salario.Size = new System.Drawing.Size(100, 20);
            this.Salario.TabIndex = 28;
            this.Salario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Salario.Valor = null;
            this.Salario.ValorMaximo = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            // 
            // ComissionadoId
            // 
            this.ComissionadoId.Location = new System.Drawing.Point(434, 289);
            this.ComissionadoId.Name = "ComissionadoId";
            this.ComissionadoId.Size = new System.Drawing.Size(97, 20);
            this.ComissionadoId.TabIndex = 29;
            this.ComissionadoId.Visible = false;
            // 
            // AssalariadoId
            // 
            this.AssalariadoId.Location = new System.Drawing.Point(434, 289);
            this.AssalariadoId.Name = "AssalariadoId";
            this.AssalariadoId.Size = new System.Drawing.Size(100, 20);
            this.AssalariadoId.TabIndex = 30;
            this.AssalariadoId.Visible = false;
            // 
            // HoristaId
            // 
            this.HoristaId.Location = new System.Drawing.Point(434, 289);
            this.HoristaId.Name = "HoristaId";
            this.HoristaId.Size = new System.Drawing.Size(100, 20);
            this.HoristaId.TabIndex = 31;
            this.HoristaId.Visible = false;
            // 
            // lbl_TxSindical
            // 
            this.lbl_TxSindical.AutoSize = true;
            this.lbl_TxSindical.Location = new System.Drawing.Point(256, 180);
            this.lbl_TxSindical.Name = "lbl_TxSindical";
            this.lbl_TxSindical.Size = new System.Drawing.Size(74, 13);
            this.lbl_TxSindical.TabIndex = 34;
            this.lbl_TxSindical.Text = "Taxa Sindical:";
            this.lbl_TxSindical.Visible = false;
            // 
            // TaxaSindical
            // 
            this.TaxaSindical.Location = new System.Drawing.Point(341, 177);
            this.TaxaSindical.Name = "TaxaSindical";
            this.TaxaSindical.Size = new System.Drawing.Size(100, 20);
            this.TaxaSindical.TabIndex = 35;
            this.TaxaSindical.Visible = false;
            // 
            // FuncionarioSindicalId
            // 
            this.FuncionarioSindicalId.BackColor = System.Drawing.Color.Transparent;
            this.FuncionarioSindicalId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FuncionarioSindicalId.CorFundo = System.Drawing.Color.Transparent;
            this.FuncionarioSindicalId.LarguraCodigo = 100;
            this.FuncionarioSindicalId.Location = new System.Drawing.Point(33, 150);
            this.FuncionarioSindicalId.Mascara = "";
            this.FuncionarioSindicalId.Name = "FuncionarioSindicalId";
            this.FuncionarioSindicalId.Size = new System.Drawing.Size(408, 21);
            this.FuncionarioSindicalId.TabIndex = 36;
            this.FuncionarioSindicalId.ConsultarAPI += new ProjectP3.componentes.CmpBuscaCombinada.EventHandlerCustom(this.FuncionarioSindicalId_ConsultarAPI);
            this.FuncionarioSindicalId.ConsultarClick += new System.EventHandler(this.FuncionarioSindicalId_ConsultarClick);
            // 
            // AgendaId
            // 
            this.AgendaId.BackColor = System.Drawing.Color.Transparent;
            this.AgendaId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AgendaId.CorFundo = System.Drawing.Color.Transparent;
            this.AgendaId.LarguraCodigo = 100;
            this.AgendaId.Location = new System.Drawing.Point(33, 123);
            this.AgendaId.Mascara = "";
            this.AgendaId.Name = "AgendaId";
            this.AgendaId.Size = new System.Drawing.Size(408, 21);
            this.AgendaId.TabIndex = 37;
            this.AgendaId.ConsultarAPI += new ProjectP3.componentes.CmpBuscaCombinada.EventHandlerCustom(this.AgendaId_ConsultarAPI);
            this.AgendaId.ConsultarClick += new System.EventHandler(this.AgendaId_ConsultarClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 127);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Agenda Pagamento:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 154);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Sindicato:";
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 501);
            this.MaximizeBox = false;
            this.Name = "FormFuncionario";
            this.Text = "Funcionário";
            this.panelInferior.ResumeLayout(false);
            this.AlternaModo.ResumeLayout(false);
            this.AlternaModo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Endereco.ResumeLayout(false);
            this.Endereco.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FuncionariosId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox MetodoPagamento;
        private System.Windows.Forms.RadioButton Assalariado;
        private System.Windows.Forms.RadioButton Comissionado;
        private System.Windows.Forms.RadioButton Horista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Endereco;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Cidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Rua;
        private System.Windows.Forms.TextBox Cep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox UF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Bairro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Complemento;
        private System.Windows.Forms.TextBox Banco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Operacao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_ValorHora;
        private System.Windows.Forms.TextBox ValorHora;
        private System.Windows.Forms.Label lbl_TaxaComissao;
        private System.Windows.Forms.TextBox TaxaComissao;
        private System.Windows.Forms.Label lbl_Salario;
        private componentes.CmpNumerico Salario;
        private System.Windows.Forms.TextBox ComissionadoId;
        private System.Windows.Forms.TextBox AssalariadoId;
        private System.Windows.Forms.TextBox HoristaId;
        private System.Windows.Forms.Label lbl_TxSindical;
        private System.Windows.Forms.TextBox Numero;
        private System.Windows.Forms.TextBox Conta;
        private System.Windows.Forms.TextBox Agencia;
        private System.Windows.Forms.TextBox TaxaSindical;
        public componentes.CmpBuscaCombinada FuncionarioSindicalId;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        public componentes.CmpBuscaCombinada AgendaId;
    }
}

