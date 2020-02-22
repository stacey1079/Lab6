CREATE TABLE [dbo].[Student] (
    [StudentId]  INT            IDENTITY (1, 1) NOT NULL, 
    [LastName] NVARCHAR (MAX) NULL,
    [FirstName]  NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Student] PRIMARY KEY CLUSTERED ([StudentId] ASC)
);


