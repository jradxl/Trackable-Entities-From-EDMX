
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 06/02/2013 17:11:35
-- Generated from EDMX file: C:\VSProjects\VS2012\TrackableEntities\TrackableEntities2\DomainModel\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TestDummy1];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PersonPhone]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Phones] DROP CONSTRAINT [FK_PersonPhone];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonPersonInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonInfoes] DROP CONSTRAINT [FK_PersonPersonInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonAddress_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonAddress] DROP CONSTRAINT [FK_PersonAddress_Person];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonAddress_Address]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PersonAddress] DROP CONSTRAINT [FK_PersonAddress_Address];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[People]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People];
GO
IF OBJECT_ID(N'[dbo].[Phones]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Phones];
GO
IF OBJECT_ID(N'[dbo].[PersonInfoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonInfoes];
GO
IF OBJECT_ID(N'[dbo].[Addresses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Addresses];
GO
IF OBJECT_ID(N'[dbo].[PersonAddress]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonAddress];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [PersonID] int IDENTITY(1,1) NOT NULL,
    [Lastname] nvarchar(max)  NOT NULL,
    [Firstname] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Phones'
CREATE TABLE [dbo].[Phones] (
    [PhoneID] int IDENTITY(1,1) NOT NULL,
    [PhoneNumber] nvarchar(max)  NOT NULL,
    [PersonID] int  NOT NULL
);
GO

-- Creating table 'PersonInfoes'
CREATE TABLE [dbo].[PersonInfoes] (
    [PersonID] int IDENTITY(1,1) NOT NULL,
    [Data1] nvarchar(max)  NOT NULL,
    [Data2] nvarchar(max)  NOT NULL,
    [Person_PersonID] int  NOT NULL
);
GO

-- Creating table 'Addresses'
CREATE TABLE [dbo].[Addresses] (
    [AddressID] int IDENTITY(1,1) NOT NULL,
    [Address1] nvarchar(max)  NOT NULL,
    [Address2] nvarchar(max)  NOT NULL,
    [Address3] nvarchar(max)  NOT NULL,
    [City] nvarchar(max)  NOT NULL,
    [Country] nvarchar(max)  NOT NULL,
    [Postcode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PersonAddress'
CREATE TABLE [dbo].[PersonAddress] (
    [People_PersonID] int  NOT NULL,
    [Addresses_AddressID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [PersonID] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([PersonID] ASC);
GO

-- Creating primary key on [PhoneID] in table 'Phones'
ALTER TABLE [dbo].[Phones]
ADD CONSTRAINT [PK_Phones]
    PRIMARY KEY CLUSTERED ([PhoneID] ASC);
GO

-- Creating primary key on [PersonID] in table 'PersonInfoes'
ALTER TABLE [dbo].[PersonInfoes]
ADD CONSTRAINT [PK_PersonInfoes]
    PRIMARY KEY CLUSTERED ([PersonID] ASC);
GO

-- Creating primary key on [AddressID] in table 'Addresses'
ALTER TABLE [dbo].[Addresses]
ADD CONSTRAINT [PK_Addresses]
    PRIMARY KEY CLUSTERED ([AddressID] ASC);
GO

-- Creating primary key on [People_PersonID], [Addresses_AddressID] in table 'PersonAddress'
ALTER TABLE [dbo].[PersonAddress]
ADD CONSTRAINT [PK_PersonAddress]
    PRIMARY KEY NONCLUSTERED ([People_PersonID], [Addresses_AddressID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PersonID] in table 'Phones'
ALTER TABLE [dbo].[Phones]
ADD CONSTRAINT [FK_PersonPhone]
    FOREIGN KEY ([PersonID])
    REFERENCES [dbo].[People]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonPhone'
CREATE INDEX [IX_FK_PersonPhone]
ON [dbo].[Phones]
    ([PersonID]);
GO

-- Creating foreign key on [Person_PersonID] in table 'PersonInfoes'
ALTER TABLE [dbo].[PersonInfoes]
ADD CONSTRAINT [FK_PersonPersonInfo]
    FOREIGN KEY ([Person_PersonID])
    REFERENCES [dbo].[People]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonPersonInfo'
CREATE INDEX [IX_FK_PersonPersonInfo]
ON [dbo].[PersonInfoes]
    ([Person_PersonID]);
GO

-- Creating foreign key on [People_PersonID] in table 'PersonAddress'
ALTER TABLE [dbo].[PersonAddress]
ADD CONSTRAINT [FK_PersonAddress_Person]
    FOREIGN KEY ([People_PersonID])
    REFERENCES [dbo].[People]
        ([PersonID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Addresses_AddressID] in table 'PersonAddress'
ALTER TABLE [dbo].[PersonAddress]
ADD CONSTRAINT [FK_PersonAddress_Address]
    FOREIGN KEY ([Addresses_AddressID])
    REFERENCES [dbo].[Addresses]
        ([AddressID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonAddress_Address'
CREATE INDEX [IX_FK_PersonAddress_Address]
ON [dbo].[PersonAddress]
    ([Addresses_AddressID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------