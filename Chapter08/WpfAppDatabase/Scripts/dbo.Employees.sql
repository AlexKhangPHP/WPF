CREATE TABLE [dbo].[Employees] (
    [EmployeeId]  INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]   NVARCHAR (50)  NULL,
    [LastName]    VARCHAR (50)   NULL,
    [DateOfBirth] SMALLDATETIME  NULL,
    [Address]     NVARCHAR (100) NULL,
    [Telephone]   VARCHAR (12)   NULL,
    [Cellphone]   VARCHAR (12)   NULL,
    [Email]       NVARCHAR (50)  NULL,
    [StateCode]   CHAR (2)       DEFAULT 'AA' NULL,
    [IsActivated] BIT            DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([EmployeeId] ASC)
);