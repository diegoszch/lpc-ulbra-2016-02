create database Agenda

go

use Agenda

go

CREATE TABLE [dbo].[Usuario] (
    [Id]    INT         IDENTITY (1, 1) NOT NULL,
    [Login] NVARCHAR(60)  NOT NULL,
    [Senha] NVARCHAR(255) NOT NULL,
    [Nome]  NVARCHAR(255) NOT NULL,
    [Email] NVARCHAR(255) NOT NULL,
    CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Login] ASC)
);

go

INSERT INTO Usuario (Login,Nome, Senha,Email) VALUES ('diego.zuge','Diego Zuge', '1','diegoszch@gmail.com')