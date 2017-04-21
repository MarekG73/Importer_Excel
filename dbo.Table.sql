CREATE TABLE [dbo].[Nabywca]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Nr_zapasu] NVARCHAR(50) NULL, 
    [Opis1] NVARCHAR(50) NULL, 
    [Opis2] NVARCHAR(50) NULL, 
    [Data] NVARCHAR(50) NULL, 
    [Typ_zapisu] NVARCHAR(50) NULL, 
    [Dostawca] NVARCHAR(50) NULL, 
    [Podst_jm] NVARCHAR(50) NULL, 
    [Ilosc] NVARCHAR(50) NULL, 
    [Nr_partii] NVARCHAR(50) NULL, 
    [Koszt jednostkowy] NVARCHAR(50) NULL, 
    [Wycena_zapasow] NVARCHAR(50) NULL, 
    [Kod_lokalizacji] NVARCHAR(50) NULL
)
