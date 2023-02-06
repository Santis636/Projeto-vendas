
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/03/2023 19:31:47
-- Generated from EDMX file: D:\Projetos\Projeto-Vendas\Vendas\Mercearia.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MercadinhoSeuFelipe];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[MercadinhoSeuFelipeModelStoreContainer].[FK__Contas__Id_Pesso__52593CB8]', 'F') IS NOT NULL
    ALTER TABLE [MercadinhoSeuFelipeModelStoreContainer].[Contas] DROP CONSTRAINT [FK__Contas__Id_Pesso__52593CB8];
GO
IF OBJECT_ID(N'[MercadinhoSeuFelipeModelStoreContainer].[FK__Contas__Id_Venda__5165187F]', 'F') IS NOT NULL
    ALTER TABLE [MercadinhoSeuFelipeModelStoreContainer].[Contas] DROP CONSTRAINT [FK__Contas__Id_Venda__5165187F];
GO
IF OBJECT_ID(N'[dbo].[FK__Vendas__Id_Vende__4D94879B]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vendas] DROP CONSTRAINT [FK__Vendas__Id_Vende__4D94879B];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Pessoa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoa];
GO
IF OBJECT_ID(N'[dbo].[ProdutosEstoque]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProdutosEstoque];
GO
IF OBJECT_ID(N'[dbo].[ProdutosLista]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProdutosLista];
GO
IF OBJECT_ID(N'[dbo].[Vendas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vendas];
GO
IF OBJECT_ID(N'[dbo].[Vendedor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vendedor];
GO
IF OBJECT_ID(N'[MercadinhoSeuFelipeModelStoreContainer].[Contas]', 'U') IS NOT NULL
    DROP TABLE [MercadinhoSeuFelipeModelStoreContainer].[Contas];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Pessoa'
CREATE TABLE [dbo].[Pessoa] (
    [Id_Pessoa] int IDENTITY(1,1) NOT NULL,
    [Nome_Pessoa] varchar(80)  NOT NULL
);
GO

-- Creating table 'ProdutosEstoque'
CREATE TABLE [dbo].[ProdutosEstoque] (
    [Id_Produto] int IDENTITY(1,1) NOT NULL,
    [Nome] varchar(80)  NOT NULL,
    [Cod_Barra] int  NULL,
    [Preco] int  NOT NULL
);
GO

-- Creating table 'ProdutosLista'
CREATE TABLE [dbo].[ProdutosLista] (
    [Id_Produto] int IDENTITY(1,1) NOT NULL,
    [Nome] varchar(80)  NOT NULL,
    [Preco] int  NOT NULL
);
GO

-- Creating table 'Vendas'
CREATE TABLE [dbo].[Vendas] (
    [Id_Venda] int IDENTITY(1,1) NOT NULL,
    [Nome_Produto] varchar(50)  NOT NULL,
    [Preco] int  NOT NULL,
    [Id_Vendedor] int  NOT NULL
);
GO

-- Creating table 'Vendedor'
CREATE TABLE [dbo].[Vendedor] (
    [Id_Vendedor] int IDENTITY(1,1) NOT NULL,
    [Nome_Vendedor] varchar(80)  NOT NULL,
    [Senha] int  NOT NULL
);
GO

-- Creating table 'Contas'
CREATE TABLE [dbo].[Contas] (
    [Id_Venda] int  NOT NULL,
    [Id_Pessoa] int  NULL,
    [Produto] varchar(50)  NOT NULL,
    [Preco] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id_Pessoa] in table 'Pessoa'
ALTER TABLE [dbo].[Pessoa]
ADD CONSTRAINT [PK_Pessoa]
    PRIMARY KEY CLUSTERED ([Id_Pessoa] ASC);
GO

-- Creating primary key on [Id_Produto] in table 'ProdutosEstoque'
ALTER TABLE [dbo].[ProdutosEstoque]
ADD CONSTRAINT [PK_ProdutosEstoque]
    PRIMARY KEY CLUSTERED ([Id_Produto] ASC);
GO

-- Creating primary key on [Id_Produto] in table 'ProdutosLista'
ALTER TABLE [dbo].[ProdutosLista]
ADD CONSTRAINT [PK_ProdutosLista]
    PRIMARY KEY CLUSTERED ([Id_Produto] ASC);
GO

-- Creating primary key on [Id_Venda] in table 'Vendas'
ALTER TABLE [dbo].[Vendas]
ADD CONSTRAINT [PK_Vendas]
    PRIMARY KEY CLUSTERED ([Id_Venda] ASC);
GO

-- Creating primary key on [Id_Vendedor] in table 'Vendedor'
ALTER TABLE [dbo].[Vendedor]
ADD CONSTRAINT [PK_Vendedor]
    PRIMARY KEY CLUSTERED ([Id_Vendedor] ASC);
GO

-- Creating primary key on [Id_Venda], [Produto], [Preco] in table 'Contas'
ALTER TABLE [dbo].[Contas]
ADD CONSTRAINT [PK_Contas]
    PRIMARY KEY CLUSTERED ([Id_Venda], [Produto], [Preco] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Id_Pessoa] in table 'Contas'
ALTER TABLE [dbo].[Contas]
ADD CONSTRAINT [FK__Contas__Id_Pesso__52593CB8]
    FOREIGN KEY ([Id_Pessoa])
    REFERENCES [dbo].[Pessoa]
        ([Id_Pessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Contas__Id_Pesso__52593CB8'
CREATE INDEX [IX_FK__Contas__Id_Pesso__52593CB8]
ON [dbo].[Contas]
    ([Id_Pessoa]);
GO

-- Creating foreign key on [Id_Venda] in table 'Contas'
ALTER TABLE [dbo].[Contas]
ADD CONSTRAINT [FK__Contas__Id_Venda__5165187F]
    FOREIGN KEY ([Id_Venda])
    REFERENCES [dbo].[Vendas]
        ([Id_Venda])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id_Vendedor] in table 'Vendas'
ALTER TABLE [dbo].[Vendas]
ADD CONSTRAINT [FK__Vendas__Id_Vende__4D94879B]
    FOREIGN KEY ([Id_Vendedor])
    REFERENCES [dbo].[Vendedor]
        ([Id_Vendedor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Vendas__Id_Vende__4D94879B'
CREATE INDEX [IX_FK__Vendas__Id_Vende__4D94879B]
ON [dbo].[Vendas]
    ([Id_Vendedor]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------