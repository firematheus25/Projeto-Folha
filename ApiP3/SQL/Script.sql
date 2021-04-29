create table Funcionarios
(
	FuncionariosId int identity NOT NULL,
	TipoFuncionario int,
	Nome varchar(100) NOT NULL,
	MetodoPagamento int NOT NULL,
	Cep varchar(8),
	Rua varchar(70),
	Complemento varchar(100),
	Numero varchar(5),
	Cidade varchar(70),
	Uf varchar(2),
	Bairro varchar(50),
	TipoPagamento int,
	Banco varchar(100),
	Conta varchar(8),
	Agencia varchar(4),
	Operacao varchar(3),
	Sindicato varchar(1),
	TaxaSindical decimal,
	ComissionadoId int,
	HoristaId int,
	AssalariadoId int,

	Primary Key(FuncionariosId),
	Constraint fk_ComissionadoId foreign key (ComissionadoId) references Comissionado(ComissionadoId),
	Constraint fk_HoristaId foreign key (HoristaId) references Horista(HoristaId),
	Constraint fk_AssalariadoId foreign key (AssalariadoId) references Assalariado(AssalariadoId)
);

drop table Funcionario

create table Comissionados
(
	ComissionadoId int identity,
	Salario decimal,
	TaxaComissao decimal,

	primary key(ComissionadoId)
		
);

create table Horistas
(
	HoristaId int identity,
	ValorHora decimal,

	primary key(HoristaId)

);

create table Assalariados
(
	AssalariadoId int identity,
	Salario decimal,

	primary key(AssalariadoId)

);

create table Vendas
(
	VendasId int identity,
	FuncionariosId int,
	DtVenda date,
	ValorVenda decimal,
	Porcentagem decimal,

	primary key(VendasId),
	Constraint FK_FuncionariosId foreign key (funcionariosId) references Funcionarios(FuncionariosId)

);
create table RegistroPontos
(
	RegistroPontoId int identity,
	FuncionariosId int,
	DtPonto date,
	Entrada varchar(8),
	Saida varchar(8),
	Horas varchar(8),

	Primary Key(RegistroPontoId),
	Constraint FK_RP_FuncionariosId foreign key (funcionariosId) references Funcionarios(FuncionariosId)
);

create table Taxas
(
	TaxasId int identity,
	FuncionariosId int,
	TaxaSindExtra decimal,
	TaxaServico decimal,

	Primary Key(TaxasId),
	Constraint FK_TX_FuncionariosId foreign key (funcionariosId) references Funcionarios(FuncionariosId)
);

create table Folha
(
	FolhasId int identity,
	FuncionariosId int,
	DtPagamento date,
	Salario decimal,
	MetodoPagamento int,

	Primary Key(FolhasId),
	Constraint FK_FL_FuncionariosId foreign key (funcionariosId) references Funcionarios(FuncionariosId)
	
);

create or alter view FuncionariosVw AS
select F.*, A.Salario, C.Salario AS SalarioComissao, C.TaxaComissao, H.ValorHora from Funcionarios F
Left Join Assalariados A ON (F.AssalariadoId = A.AssalariadoId)
Left Join Comissionados C ON (F.ComissionadoId = C.ComissionadoId)
Left Join Horistas H ON (F.HoristaId = H.HoristaId)

GO