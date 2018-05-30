CREATE TABLE [dbo].[tblEmployee] (
    [tblEmployeeID] BIGINT       IDENTITY (1, 1) NOT NULL,
    [Name]          VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_tblEmployee] PRIMARY KEY CLUSTERED ([tblEmployeeID] ASC)
);

