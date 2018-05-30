CREATE TABLE [dbo].[tblDepartment] (
    [tblDepartmentID] INT          IDENTITY (1, 1) NOT NULL,
    [Name]            VARCHAR (50) NOT NULL,
    [LabelColor]      VARCHAR (50) NOT NULL,
    [Initial]         VARCHAR (3)  NOT NULL,
    CONSTRAINT [PK_tblDepartment] PRIMARY KEY CLUSTERED ([tblDepartmentID] ASC)
);



