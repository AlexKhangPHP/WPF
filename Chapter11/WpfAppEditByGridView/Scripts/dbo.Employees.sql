CREATE TABLE [dbo].[Employees]
(
	[EmployeeId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] VARCHAR(50) NULL, 
    [DateOfBirth] SMALLDATETIME NULL, 
    [Address] NVARCHAR(100) NULL, 
    [Telephone] VARCHAR(12) NULL, 
    [Cellphone] VARCHAR(12) NULL, 
    [Email] NVARCHAR(50) NULL,
	[StateCode] CHAR (2)     NOT NULL,
	[IsActivated] BIT DEFAULT 1
)
