CREATE TABLE [dbo].[tblMessage] (
    [tblMessageID]    VARCHAR (50)  NOT NULL,
    [Description]     VARCHAR (250) NOT NULL,
    [Subject]         VARCHAR (50)  NOT NULL,
    [CreatedAt]       DATETIME      NOT NULL,
    [ModifiedAt]      DATETIME      NOT NULL,
    [tblDepartmentID] INT           NOT NULL,
    [tblPriorityID]   INT           NOT NULL,
    [IsActive]        BIT           NOT NULL,
    CONSTRAINT [PK_tblMessage] PRIMARY KEY CLUSTERED ([tblMessageID] ASC),
    CONSTRAINT [FK_tblMessage_tblDepartment] FOREIGN KEY ([tblDepartmentID]) REFERENCES [dbo].[tblDepartment] ([tblDepartmentID]),
    CONSTRAINT [FK_tblMessage_tblPriority] FOREIGN KEY ([tblPriorityID]) REFERENCES [dbo].[tblPriority] ([tblPriorityID])
);

