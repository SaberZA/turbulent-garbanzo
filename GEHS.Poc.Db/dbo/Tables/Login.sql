CREATE TABLE [dbo].[Login] (
    [Id]           INT          NOT NULL,
    [Username]     VARCHAR (50) NOT NULL,
    [Password]     VARCHAR (50) NOT NULL,
    [DomainUserId] INT          NOT NULL, 
    CONSTRAINT [PK_Login] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Login_DomainUser] FOREIGN KEY ([DomainUserId]) REFERENCES [DomainUser]([Id])
);

