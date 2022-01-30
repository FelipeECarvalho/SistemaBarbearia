CREATE DATABASE [Barbearia]
GO

USE [Barbearia]
GO

CREATE TABLE [Cliente]
(
    [Id] INT IDENTITY,
	[Cpf] VARCHAR(15) NOT NULL UNIQUE,
	[Nome] VARCHAR(50) NOT NULL,
	[Telefone] VARCHAR(18) NOT NULL UNIQUE,
	[Email] VARCHAR(50) NOT NULL UNIQUE,

    CONSTRAINT PK_Cliente PRIMARY KEY ([Id])
);
GO

CREATE NONCLUSTERED INDEX IX_ClientCpf ON [Cliente]([Cpf]);


CREATE TABLE [Administrador]
(
    [Id] INT IDENTITY,
	[Usuario] VARCHAR(50) NOT NULL UNIQUE,
	[Senha] VARCHAR(50) NOT NULL,
	[Nome] VARCHAR(50) NOT NULL,

    CONSTRAINT PK_Administrador
    PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Agendamento]
(
	[Id] INT IDENTITY,
	[IdCliente] INT NOT NULL,
	[Data] DATETIME NOT NULL,
	[ValorTotal] MONEY NOT NULL,

    CONSTRAINT PK_Agendamento
    PRIMARY KEY ([Id])
);
GO


ALTER TABLE [Agendamento] ADD CONSTRAINT FK_Cliente_Agendamento
FOREIGN KEY ([IdCliente]) REFERENCES [Cliente]([Id]) ON DELETE CASCADE;
GO


CREATE TABLE [Servico]
(
	[Id] INT IDENTITY,
	[Descricao] VARCHAR(50) NOT NULL,
	[Valor] MONEY NOT NULL,

    CONSTRAINT PK_Servico
    PRIMARY KEY ([Id])
);
GO

CREATE TABLE [ServicoAgendamento]
(
	[IdAgendamento] INT NOT NULL,
	[IdServico] INT NOT NULL,

    CONSTRAINT PK_ServicoAgendamento
    PRIMARY KEY ([IdAgendamento], [IdServico])
);
GO

ALTER TABLE [ServicoAgendamento] ADD CONSTRAINT FK_Agendamento_ServicoAgendamento
FOREIGN KEY ([IdAgendamento]) REFERENCES [Agendamento]([Id]) ON DELETE CASCADE;
GO


ALTER TABLE [ServicoAgendamento] ADD CONSTRAINT FK_Servico_ServicoAgendamento
FOREIGN KEY ([IdServico]) REFERENCES [Servico]([Id]);
GO


CREATE TABLE [BackupCliente]
(
	[Id] INT IDENTITY,
    [IdCliente] INT NOT NULL,
	[CpfCliente] VARCHAR(15) NOT NULL,
	[Nome] VARCHAR(50) NOT NULL,
	[Telefone] VARCHAR(18) NOT NULL,
	[Email] VARCHAR(50) NOT NULL,
	[DataBackup] DATETIME NOT NULL,
	[Acao] VARCHAR(100),

    CONSTRAINT PK_BackupCliente
    PRIMARY KEY ([Id])
);
GO



CREATE TRIGGER TGR_UpdateCliente
ON [Cliente]
AFTER UPDATE
AS
	DECLARE @ACAO VARCHAR(100)

	SET @ACAO = 'UPDATE NO CLIENTE - TGR_UpdateCliente';
	INSERT INTO [BackupCliente]([IdCliente], [CpfCliente], [Nome], [Telefone], [Email], [DataBackup], [Acao]) 
	SELECT D.[Id], D.[Cpf], D.[Nome], D.[Telefone], D.[Email], GETDATE(), @ACAO FROM DELETED D, INSERTED I
	WHERE D.CPF = I.CPF
GO


CREATE TRIGGER TGR_DELETE_CLIENTE
ON [Cliente]
AFTER DELETE
AS
	DECLARE @ACAO VARCHAR(100)

	SET @ACAO = 'DELETE NO CLIENTE - TGR_DELETE_CLIENTE';

	INSERT INTO [BackupCliente]([IdCliente], [CpfCliente], [Nome], [Telefone], [Email], [DataBackup], [Acao])
	SELECT D.[Id], D.[Cpf], D.[Nome], D.[Telefone], D.[Email], GETDATE(), @ACAO FROM DELETED D
GO

	
	


