CREATE TABLE [dbo].[Table]
(
	[EmployeeId] INT NOT NULL , 
    	[RelationType] NVARCHAR(20) NOT NULL, 
    	[FullName] NVARCHAR(50) NOT NULL, 
	[Address] NVARCHAR(100) NOT NULL, 
    	[Age] TINYINT NULL DEFAULT 0, 
    	[CareerTitle] VARCHAR(50) NULL, 
	[UrgentContact] VARCHAR(50) NULL, 
    	PRIMARY KEY ([RelationType], [EmployeeId])
)
