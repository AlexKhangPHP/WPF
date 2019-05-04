CREATE TABLE [dbo].[StateAbbreviations] (
    [Abbreviation]     CHAR (2)     NOT NULL,
    [StateName]        VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Abbreviation] ASC)
);

