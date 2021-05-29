USE master
GO

IF EXISTS (SELECT * FROM sysdatabases WHERE NAME = 'Ewidencja_Urlopów')
		DROP DATABASE Ewidencja_Urlopów
GO

IF NOT EXISTS (SELECT * FROM sys.databases WHERE NAME = 'Ewidencja_Urlopów')
BEGIN
	CREATE DATABASE [Ewidencja_Urlopów]  COLLATE Latin1_General_CI_AS;
END
GO

SET DATEFORMAT ymd
GO

USE Ewidencja_Urlopów
GO

CREATE SCHEMA ewu;
GO

 CREATE TABLE [ewu].[stanowisko](
	[IDstanowiska] [int] IDENTITY(1,1) NOT NULL,	--PL
	[nazwaST] [nvarchar](50) NOT NULL,
	[opisST] [nvarchar](255) NULL,

CONSTRAINT "PK_stanowisko" PRIMARY KEY CLUSTERED ("IDstanowiska") -- DOTYCZY SPOSOBU PRZECHOWYWANIA DANYCH NA DYSKU -  WED£UG TEGO KLUCZA DANE S¥ POSORTOWANE I PRZECHOWYWANE NA DYSKU
 );
GO


 CREATE TABLE [ewu].[status_urlopu](
	[IDstatus] [int] IDENTITY(1,1) NOT NULL,		--PK
	[nazwaSU] [nvarchar](20) NOT NULL,

CONSTRAINT "PK_status_urlopu" PRIMARY KEY CLUSTERED ("IDstatus")
 );
 GO


CREATE TABLE [ewu].[typ_urlopu](
	[IDurlopu_typ] [int] IDENTITY(1,1) NOT NULL,	--PK
	[nazwaTU] [nvarchar](25) NOT NULL,

CONSTRAINT "PK_typ_urlopu" PRIMARY KEY CLUSTERED ("IDurlopu_typ")
 );
GO


CREATE TABLE [ewu].[wymiar_czasu_pracy](
	[IDwymiar] [int] IDENTITY(1,1) NOT NULL,		--PK
	[etat] [float](6) NOT NULL,
	[nazwaWCP] [nvarchar](30) NULL,

CONSTRAINT "PK_wymiar_czasu_pracy" PRIMARY KEY clustered ("IDwymiar")
 );
 GO


CREATE TABLE [ewu].[pracownicy](
	[IDpracownika] [int] IDENTITY(1,1) NOT NULL,	--PK
	[imie] [nvarchar](25) NOT NULL,
	[nazwisko] [nvarchar](25) NOT NULL,
	[plec] [nvarchar](10) NOT NULL,
	[numer_pesel] [nvarchar](11) NOT NULL UNIQUE,
	[data_urodzenia] [date] NOT NULL,

CONSTRAINT "PK_pracownicy" PRIMARY KEY CLUSTERED ("IDpracownika"),

CONSTRAINT "CK_ok_data_urodzenia" CHECK (data_urodzenia < GETDATE()),
CONSTRAINT "CK_data_urodzenia" CHECK (DATEDIFF(YEAR, data_urodzenia, GETDATE()) >= 18)

 );
GO


CREATE TABLE [ewu].[okres_zatrudnienia](
	[IDzatrudnienia] [int] IDENTITY(1,1) NOT NULL,	--PK
	[IDpracownika] [int] NOT NULL,					--FK
	[IDstanowiska] [int] NOT NULL,					--FK
	[IDwymiar] [int] NOT NULL,						--FK
	[staz_pracy][tinyint] NOT NULL,	--staz_pracy iloœæ urlopu dla 0 = 20 dni, dla 1 -26 dni w skali roku
	[zatrudniony_od] [date] NOT NULL,
	[zatrudniony_do] [date] NULL,
	[nalezny_urlop] [int] NOT NULL,

CONSTRAINT "PK_okres_zatrudnienia" PRIMARY KEY CLUSTERED ("IDZatrudnienia"),
CONSTRAINT "FK_okres_zatrudnienia_pracownika" FOREIGN KEY ("IDpracownika") REFERENCES "ewu"."pracownicy" ("IDpracownika") ON UPDATE CASCADE,
CONSTRAINT "FK_okres_zatrudnienia_stanowisko" FOREIGN KEY ("IDstanowiska") REFERENCES "ewu"."stanowisko" ("IDstanowiska") ON UPDATE CASCADE,
CONSTRAINT "FK_okres_zatrudnienia_wymiar" FOREIGN KEY ("IDwymiar") REFERENCES "ewu"."wymiar_czasu_pracy" ("IDwymiar") ON UPDATE CASCADE,

CONSTRAINT "CK_okres_zatrudnienia" CHECK (zatrudniony_od < zatrudniony_do),
CONSTRAINT "CK_staz_pracy" CHECK (staz_pracy = 0 or staz_pracy = 1)
 );
GO


CREATE TABLE [ewu].[urlopy](
	[IDewidencji] [int] IDENTITY(1,1) NOT NULL,		--PK
	[IDzatrudnienia] [int] NOT NULL,				--FK
	[IDstatus] [int] NOT NULL,						--FK
	[IDurlopu_typ] [int] NOT NULL,					--FK
	[data_wniosku] [date] NOT NULL,
	[urlop_od] [date] NOT NULL,
	[urlop_do] [date] NOT NULL,
	[ilosc_dni_urlopu] [int] NOT NULL,
	[uwagi] [nvarchar](255) NULL,


CONSTRAINT "PK_urlopy" PRIMARY KEY CLUSTERED ("IDewidencji"),
CONSTRAINT "FK_urlopy_zatrudnienie" FOREIGN KEY ("IDzatrudnienia") REFERENCES "ewu"."okres_zatrudnienia" ("IDzatrudnienia") ON UPDATE CASCADE,
CONSTRAINT "FK_urlopy_status" FOREIGN KEY ("IDstatus") REFERENCES "ewu"."status_urlopu" ("IDstatus") ON UPDATE CASCADE,
CONSTRAINT "FK_urlopy_urlop_typ" FOREIGN KEY ("IDurlopu_typ") REFERENCES "ewu"."typ_urlopu" ("IDurlopu_typ") ON UPDATE CASCADE,

CONSTRAINT "CK_ilosc_dni_urlopu" CHECK (ilosc_dni_urlopu >= 0),
CONSTRAINT "CK_urlop_od_do" CHECK (urlop_od <= urlop_do),
CONSTRAINT "CK_data_wniosku" CHECK (data_wniosku <= urlop_od),
CONSTRAINT "CK_rok_urlopu" CHECK (YEAR(urlop_od) = YEAR(urlop_do))
 );
 GO


 USE Ewidencja_Urlopów
 GO

--###############################################################################################################################################

CREATE OR ALTER TRIGGER ewu.TR_nale¿ny_urlop 
ON ewu.okres_zatrudnienia 
INSTEAD OF INSERT 
AS
BEGIN
	SET NOCOUNT ON;
	IF (SELECT COUNT(*) FROM inserted) = 1
	BEGIN
		IF NOT EXISTS(SELECT TOP 1 IDpracownika FROM ewu.okres_zatrudnienia 
		WHERE IDpracownika = (SELECT TOP 1 IDpracownika FROM inserted 
								WHERE zatrudniony_do IS NULL) AND zatrudniony_do IS NULL
		)
		BEGIN
			DECLARE @urlop_wypoczynkowy int;
			DECLARE @staz int;
			DECLARE @etacik float;
			DECLARE @zatr_od date = (SELECT zatrudniony_od FROM inserted);
			DECLARE @zatr_do date = (SELECT zatrudniony_do FROM inserted);
			DECLARE @okr_zatr float;
		
			IF @zatr_do IS NOT NULL
			BEGIN
				SET @okr_zatr = (DATEDIFF(MONTH, @zatr_od, @zatr_do))/12.0;
			END

			IF @zatr_do IS  NULL
			BEGIN
				SET @okr_zatr = (DATEDIFF(MONTH, @zatr_od, DATEFROMPARTS(YEAR(GETDATE()), 12, 31)))/12.0; 
			END

			SET @staz = (SELECT staz_pracy FROM inserted);
			SET @etacik = (SELECT WCP.etat FROM inserted AS INS inner join wymiar_czasu_pracy AS WCP ON INS.IDwymiar=WCP.IDwymiar )
			--print @etacik;
			
			IF (@staz) = 0
			BEGIN
				SET @urlop_wypoczynkowy  = CEILING(20 * @etacik * @okr_zatr);
				INSERT INTO "okres_zatrudnienia" (IDpracownika,"IDstanowiska","IDwymiar", "staz_pracy", "zatrudniony_od", "zatrudniony_do", "nalezny_urlop") 
				SELECT INS.IDpracownika, INS.IDstanowiska, INS.IDwymiar, INS.staz_pracy, INS.zatrudniony_od, INS.zatrudniony_do, @urlop_wypoczynkowy FROM inserted AS INS
			END

			IF (@staz) = 1
			BEGIN
				SET @urlop_wypoczynkowy = CEILING(26 * @etacik * @okr_zatr);
				INSERT INTO "okres_zatrudnienia" (IDpracownika,"IDstanowiska","IDwymiar", "staz_pracy", "zatrudniony_od", "zatrudniony_do", "nalezny_urlop") 
				SELECT INS.IDpracownika, INS.IDstanowiska, INS.IDwymiar, INS.staz_pracy, INS.zatrudniony_od, INS.zatrudniony_do, @urlop_wypoczynkowy FROM inserted AS INS
			END
		END
	END
	ELSE
	BEGIN
		RAISERROR ('Nie mo¿na dodaæ dla pracownika kolejneij umowy na czas nieokreœlony',16,1)
		--ROLLBACK TRANSACTION
	END
END
GO

 --###############################################################################################################################################

USE Ewidencja_Urlopów
GO
CREATE OR ALTER PROCEDURE ewu.PR_zmiana_daty_zakonczenia_pracy (@id_pracownika INT, @data_zakonczenia DATE)

AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @urlop_wypoczynkowy int;
	BEGIN
		DECLARE @staz int;
		DECLARE @etacik float;
		DECLARE @zatr_od date = (SELECT zatrudniony_od FROM ewu.okres_zatrudnienia
								WHERE zatrudniony_do IS NULL AND IDpracownika = @id_pracownika);
		DECLARE @okr_zatr float;
		
		SET @okr_zatr = (DATEDIFF(MONTH, @zatr_od, @data_zakonczenia))/12.0;

		SET @staz =		(SELECT staz_pracy FROM ewu.okres_zatrudnienia
						WHERE zatrudniony_do IS NULL AND IDpracownika = @id_pracownika);
		SET @etacik =	(SELECT WCP.etat FROM ewu.okres_zatrudnienia AS OZ inner join wymiar_czasu_pracy as WCP ON OZ.IDwymiar=WCP.IDwymiar
						WHERE zatrudniony_do IS NULL AND IDpracownika = @id_pracownika);
		IF (@staz) = 0
			BEGIN
				SET @urlop_wypoczynkowy  = CEILING(20 * @etacik * @okr_zatr);
				UPDATE ewu.okres_zatrudnienia SET zatrudniony_do = @data_zakonczenia , nalezny_urlop = @urlop_wypoczynkowy
				WHERE zatrudniony_do IS NULL AND IDpracownika= @id_pracownika
			END

		IF (@staz) = 1
			BEGIN
				SET @urlop_wypoczynkowy = CEILING(26 * @etacik * @okr_zatr);
				UPDATE ewu.okres_zatrudnienia SET zatrudniony_do = @data_zakonczenia, nalezny_urlop = @urlop_wypoczynkowy
				WHERE zatrudniony_do IS NULL AND IDpracownika= @id_pracownika
			END
	END
END
GO

 --###############################################################################################################################################

CREATE OR ALTER PROCEDURE ewu.PR_coroczny_urlop_wypoczynkowy
AS
	BEGIN
		DECLARE @temporary_id int;
		DECLARE @urlop_wypoczynkowy int;
		DECLARE @staz int;
		DECLARE @etacik float;
		DECLARE @MAX_ID int;

		SET @MAX_ID = (SELECT MAX(IDzatrudnienia) from ewu.okres_zatrudnienia);
		SET @temporary_id = 0;

		WHILE (@temporary_id < @MAX_ID)
		BEGIN
			SET @temporary_id = @temporary_id + 1;
			DECLARE @ID_PR int = (SELECT DISTINCT IDpracownika FROM ewu.okres_zatrudnienia WHERE IDzatrudnienia = @temporary_id);
			DECLARE @zatr_od date = (SELECT zatrudniony_od FROM ewu.okres_zatrudnienia
									WHERE zatrudniony_do IS NULL AND IDpracownika = @ID_PR);
		
			DECLARE @okr_zatr float;
		
			SET @okr_zatr = (DATEDIFF(MONTH, @zatr_od, DATEFROMPARTS(YEAR(GETDATE()), 12, 31)))/12.0;

			SET @staz =		(SELECT staz_pracy FROM ewu.okres_zatrudnienia
							WHERE zatrudniony_do IS NULL AND IDpracownika = @ID_PR);
			SET @etacik =	(SELECT WCP.etat FROM ewu.okres_zatrudnienia AS OZ inner join wymiar_czasu_pracy as WCP ON OZ.IDwymiar=WCP.IDwymiar
							WHERE zatrudniony_do IS NULL AND IDpracownika = @ID_PR);
	
			IF (@staz) = 0
			BEGIN
				SET @urlop_wypoczynkowy  = CEILING(20 * @etacik * @okr_zatr);
				UPDATE ewu.okres_zatrudnienia SET nalezny_urlop = @urlop_wypoczynkowy
				WHERE zatrudniony_do IS NULL AND IDpracownika = @ID_PR
			END

			IF (@staz) = 1
			BEGIN
				SET @urlop_wypoczynkowy = CEILING(26 * @etacik * @okr_zatr);
				UPDATE ewu.okres_zatrudnienia SET nalezny_urlop = @urlop_wypoczynkowy
				WHERE zatrudniony_do IS NULL AND IDpracownika = @ID_PR
			END
		END
	END
GO

USE master
GO