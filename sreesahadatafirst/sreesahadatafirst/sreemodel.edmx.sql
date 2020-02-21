
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/18/2020 10:26:41
-- Generated from EDMX file: C:\Users\Admin\source\repos\sreesahadatafirst\sreesahadatafirst\sreemodel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [sd];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[sreemodelStoreContainer].[FK__banks__cid__267ABA7A]', 'F') IS NOT NULL
    ALTER TABLE [sreemodelStoreContainer].[banks] DROP CONSTRAINT [FK__banks__cid__267ABA7A];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[customers];
GO
IF OBJECT_ID(N'[sreemodelStoreContainer].[banks]', 'U') IS NOT NULL
    DROP TABLE [sreemodelStoreContainer].[banks];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'banks'
CREATE TABLE [dbo].[banks] (
    [bid] int IDENTITY(1,1) NOT NULL,
    [cid] int  NOT NULL
);
GO

-- Creating table 'customers'
CREATE TABLE [dbo].[customers] (
    [cid] int IDENTITY(1,1) NOT NULL,
    [cname] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [bid] in table 'banks'
ALTER TABLE [dbo].[banks]
ADD CONSTRAINT [PK_banks]
    PRIMARY KEY CLUSTERED ([bid] ASC);
GO

-- Creating primary key on [cid] in table 'customers'
ALTER TABLE [dbo].[customers]
ADD CONSTRAINT [PK_customers]
    PRIMARY KEY CLUSTERED ([cid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [cid] in table 'banks'
ALTER TABLE [dbo].[banks]
ADD CONSTRAINT [FK__banks__cid__267ABA7A]
    FOREIGN KEY ([cid])
    REFERENCES [dbo].[customers]
        ([cid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__banks__cid__267ABA7A'
CREATE INDEX [IX_FK__banks__cid__267ABA7A]
ON [dbo].[banks]
    ([cid]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------