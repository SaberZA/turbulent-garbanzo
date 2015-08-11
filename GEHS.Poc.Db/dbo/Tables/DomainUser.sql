CREATE TABLE [dbo].[DomainUser] (
    [Id]        INT           NOT NULL,
    [FirstName] VARCHAR (50)  NOT NULL,
    [LastName]  VARCHAR (100) NOT NULL,
    [IdNumber]  VARCHAR (50)  NOT NULL, 
    CONSTRAINT [PK_DomainUser] PRIMARY KEY ([Id])
);

