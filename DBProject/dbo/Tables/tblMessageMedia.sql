CREATE TABLE [dbo].[tblMessageMedia] (
    [tblMessageMediaID] BIGINT        IDENTITY (1, 1) NOT NULL,
    [tblMessageID]      VARCHAR (50)  NOT NULL,
    [Path]              VARCHAR (500) NOT NULL,
    [tblMediaType]      INT           NOT NULL,
    CONSTRAINT [PK_tblMessageMedia] PRIMARY KEY CLUSTERED ([tblMessageMediaID] ASC),
    CONSTRAINT [FK_tblMessageMedia_tblMessage] FOREIGN KEY ([tblMessageID]) REFERENCES [dbo].[tblMessage] ([tblMessageID])
);

