USE Ewidencja_Urlopów
GO

INSERT INTO ewu.typ_urlopu ("nazwaTU") VALUES (N'Wypoczynkowy');
INSERT INTO ewu.typ_urlopu ("nazwaTU") VALUES (N'Macie¿yñski');
INSERT INTO ewu.typ_urlopu ("nazwaTU") VALUES (N'Wychowawczy');
INSERT INTO ewu.typ_urlopu ("nazwaTU") VALUES (N'Szkoleniowy');
INSERT INTO ewu.typ_urlopu ("nazwaTU") VALUES (N'Okolicznoœciowy');
INSERT INTO ewu.typ_urlopu ("nazwaTU") VALUES (N'Na ¿¹danie');
INSERT INTO ewu.typ_urlopu ("nazwaTU") VALUES (N'Bezp³atny');
INSERT INTO ewu.typ_urlopu ("nazwaTU") VALUES (N'Ustalony przez zarz¹d');

--###############################################################################################################################################

INSERT INTO ewu.status_urlopu ("nazwaSU") VALUES (N'ZAAKCEPTOWANY');
INSERT INTO ewu.status_urlopu ("nazwaSU") VALUES (N'ODRZUCONY');
INSERT INTO ewu.status_urlopu ("nazwaSU") VALUES (N'OCZEKUJ¥CY');

--###############################################################################################################################################

INSERT INTO ewu.wymiar_czasu_pracy ("etat", "nazwaWCP") VALUES (1.0, N'Pe³ny etat (1)');
INSERT INTO ewu.wymiar_czasu_pracy  ("etat", "nazwaWCP") VALUES (0.75, N'Trzy czwarte etatu (3/4)');
INSERT INTO ewu.wymiar_czasu_pracy  ("etat", "nazwaWCP") VALUES (0.5, N'Po³owa etatu (1/2)');
INSERT INTO ewu.wymiar_czasu_pracy  ("etat", "nazwaWCP") VALUES (0.25,N'Jedna czwarta etatu (1/4)');
INSERT INTO ewu.wymiar_czasu_pracy  ("etat", "nazwaWCP") VALUES (0.125, N'Jedna ósma etatu (1/8)');

--###############################################################################################################################################

INSERT INTO ewu.stanowisko ("nazwaST", "opisST") VALUES (N'Prezes', NULL);					--1
INSERT INTO ewu.stanowisko ("nazwaST", "opisST") VALUES (N'Wiceprezes', NULL);				--2
INSERT INTO ewu.stanowisko ("nazwaST", "opisST") VALUES (N'Ksiêgowy/a', NULL);				--3
INSERT INTO ewu.stanowisko ("nazwaST", "opisST") VALUES (N'Handlowiec', NULL);				--4
INSERT INTO ewu.stanowisko ("nazwaST", "opisST") VALUES (N'Projektant', NULL);				--5
INSERT INTO ewu.stanowisko ("nazwaST", "opisST") VALUES (N'Asystent projektanta', NULL);	--6
INSERT INTO ewu.stanowisko ("nazwaST", "opisST") VALUES (N'Konstruktor', NULL);				--7
INSERT INTO ewu.stanowisko ("nazwaST", "opisST") VALUES (N'In¿ynier budowy', 'Technik');	--8

--###############################################################################################################################################

INSERT INTO ewu.pracownicy 
		("imie","nazwisko","plec","numer_pesel","data_urodzenia") 
VALUES	('Marcin', 'Zuziak', N'Mê¿czyzna','95110806666','1995-11-08');

INSERT INTO ewu.pracownicy
		("imie","nazwisko","plec","numer_pesel","data_urodzenia") 
VALUES	('David', 'Weber', N'Mê¿czyzna','85081586556','1985-08-15');

INSERT INTO ewu.pracownicy
		("imie","nazwisko","plec","numer_pesel","data_urodzenia") 
VALUES	('Vanessa', 'Foster', N'Kobieta','92051145329','1992-05-11');

INSERT INTO ewu.pracownicy
		("imie","nazwisko","plec","numer_pesel","data_urodzenia") 
VALUES	(N'Bo¿ena', N'Œwi¹tek', N'Kobieta','86051887342','1986-05-18');

INSERT INTO ewu.pracownicy
		("imie","nazwisko","plec","numer_pesel","data_urodzenia") 
VALUES	('Carl', 'Farrow', N'Mê¿czyzna','77061731891','1977-06-17');

INSERT INTO ewu.pracownicy
		("imie","nazwisko","plec","numer_pesel","data_urodzenia") 
VALUES	('Ravinder', 'Cooley', N'Mê¿czyzna','87101266352','1987-01-12');

INSERT INTO ewu.pracownicy 
		("imie","nazwisko","plec","numer_pesel","data_urodzenia") 
VALUES	('Darci', 'Hamilton', N'Kobieta','89071343989','1989-07-13');

INSERT INTO ewu.pracownicy 
		("imie","nazwisko","plec","numer_pesel","data_urodzenia") 
VALUES	('Rachael', 'Brook', N'Kobieta','93041214648','1993-04-12');

--###############################################################################################################################################

INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (1, 5, 1, 0, '2020-07-01', '2020-10-01')

INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (1, 5, 1, 1, '2020-10-01', '2021-04-01')

INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (1, 5, 1, 1, '2021-04-01', NULL)


INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (2, 5, 1, 0, '2013-11-23', '2014-02-23')

INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (2, 5, 1, 1, '2014-02-23', '2014-08-23')

INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (2, 5, 1, 1,'2014-08-23', '2015-08-23')

INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (2, 5, 1, 1, '2015-08-23', NULL)


INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (3, 8, 2, 1 , '2015-05-07', '2015-08-07')

INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (3, 8, 1, 1, '2015-08-07', '2016-02-07')

INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (3, 8, 1, 1, '2016-02-07', '2017-02-07')

INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (3, 8, 1, 1, '2017-02-07', NULL)


INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (4, 8, 3, 0, '2012-11-14', '2013-02-14')

INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (4, 4, 1, 1, '2013-02-14', '2013-08-14')

INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (4, 4, 1, 1, '2013-08-14', '2014-09-14')

INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (4, 7, 1, 1, '2014-09-14', NULL)


INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (5, 1, 1, 1, '2010-03-05', NULL)


INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (6, 6, 2, 1, '2019-04-08', '2019-07-08')

INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (6, 6, 2, 1, '2019-07-08', '2020-01-08')

INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (6, 6, 1, 1, '2020-01-08', '2021-01-08')

INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (6, 6, 1, 1, '2021-01-08', NULL)


INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (7, 8, 2, 0, '2015-10-11', '2016-01-11')

INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (7, 8, 2, 1, '2016-01-11', '2016-07-11')

INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (7, 8, 2, 1, '2016-07-11', '2017-07-11')

INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (7, 2, 2, 1, '2017-07-11', NULL)


INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (8, 3, 2, 1, '2018-02-01', '2018-05-01')

INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (8, 3, 1, 1,'2018-05-01', '2018-11-01')

INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (8, 3, 1, 1,'2018-11-01', '2019-11-01')

INSERT INTO ewu.okres_zatrudnienia ("IDpracownika", "IDstanowiska", "IDwymiar", "staz_pracy",  "zatrudniony_od", "zatrudniony_do")
			VALUES (8, 3, 1, 1, '2019-11-01', NULL)


--###############################################################################################################################################

INSERT INTO ewu.urlopy ("IDzatrudnienia", "IDstatus", "IDurlopu_typ", "data_wniosku", "urlop_od", "urlop_do", "ilosc_dni_urlopu", "uwagi")
			VALUES (1, 1, 1, '2020-08-10', '2020-08-18', '2020-08-19', 2, NULL)

INSERT INTO ewu.urlopy ("IDzatrudnienia", "IDstatus", "IDurlopu_typ", "data_wniosku", "urlop_od", "urlop_do", "ilosc_dni_urlopu", "uwagi")
			VALUES (2, 1, 1, '2020-11-06', '2020-11-16', '2020-11-20', 5, NULL)

INSERT INTO ewu.urlopy ("IDzatrudnienia", "IDstatus", "IDurlopu_typ", "data_wniosku", "urlop_od", "urlop_do", "ilosc_dni_urlopu", "uwagi")
			VALUES (3, 1, 1, '2021-05-06', '2021-05-17', '2021-05-28', 10, NULL)

INSERT INTO ewu.urlopy ("IDzatrudnienia", "IDstatus", "IDurlopu_typ", "data_wniosku", "urlop_od", "urlop_do", "ilosc_dni_urlopu", "uwagi")
			VALUES (4, 1, 1, '2014-01-03', '2014-01-16', '2014-01-17', 2, NULL)

INSERT INTO ewu.urlopy ("IDzatrudnienia", "IDstatus", "IDurlopu_typ", "data_wniosku", "urlop_od", "urlop_do", "ilosc_dni_urlopu", "uwagi")
			VALUES (8, 1, 1, '2015-05-27', '2015-06-01', '2015-06-01', 1, NULL)

INSERT INTO ewu.urlopy ("IDzatrudnienia", "IDstatus", "IDurlopu_typ", "data_wniosku", "urlop_od", "urlop_do", "ilosc_dni_urlopu", "uwagi")
			VALUES (12, 1, 1, '2012-12-06', '2012-12-17', '2012-12-17', 1, NULL)

INSERT INTO ewu.urlopy ("IDzatrudnienia", "IDstatus", "IDurlopu_typ", "data_wniosku", "urlop_od", "urlop_do", "ilosc_dni_urlopu", "uwagi")
			VALUES (16, 1, 1, '2010-03-25', '2010-04-06', '2010-04-06', 1, NULL)

INSERT INTO ewu.urlopy ("IDzatrudnienia", "IDstatus", "IDurlopu_typ", "data_wniosku", "urlop_od", "urlop_do", "ilosc_dni_urlopu", "uwagi")
			VALUES (16, 1, 1, '2010-04-25', '2010-05-06', '2010-05-26', 1, NULL)

INSERT INTO ewu.urlopy ("IDzatrudnienia", "IDstatus", "IDurlopu_typ", "data_wniosku", "urlop_od", "urlop_do", "ilosc_dni_urlopu", "uwagi")
			VALUES (16, 1, 1, '2011-03-25', '2011-04-06', '2011-04-12', 1, NULL)

INSERT INTO ewu.urlopy ("IDzatrudnienia", "IDstatus", "IDurlopu_typ", "data_wniosku", "urlop_od", "urlop_do", "ilosc_dni_urlopu", "uwagi")
			VALUES (16, 1, 1, '2013-03-25', '2013-04-06', '2013-04-06', 1, NULL)

INSERT INTO ewu.urlopy ("IDzatrudnienia", "IDstatus", "IDurlopu_typ", "data_wniosku", "urlop_od", "urlop_do", "ilosc_dni_urlopu", "uwagi")
			VALUES (16, 1, 1, '2016-03-25', '2016-04-06', '2016-04-06', 1, NULL)

INSERT INTO ewu.urlopy ("IDzatrudnienia", "IDstatus", "IDurlopu_typ", "data_wniosku", "urlop_od", "urlop_do", "ilosc_dni_urlopu", "uwagi")
			VALUES (16, 1, 1, '2018-03-25', '2018-04-06', '2018-04-06', 1, NULL)

INSERT INTO ewu.urlopy ("IDzatrudnienia", "IDstatus", "IDurlopu_typ", "data_wniosku", "urlop_od", "urlop_do", "ilosc_dni_urlopu", "uwagi")
			VALUES (17, 1, 1, '2019-04-22', '2019-04-29', '2019-04-30', 2, NULL)

INSERT INTO ewu.urlopy ("IDzatrudnienia", "IDstatus", "IDurlopu_typ", "data_wniosku", "urlop_od", "urlop_do", "ilosc_dni_urlopu", "uwagi")
			VALUES (21, 1, 1, '2015-11-06', '2015-11-18', '2015-11-18', 1, NULL)

INSERT INTO ewu.urlopy ("IDzatrudnienia", "IDstatus", "IDurlopu_typ", "data_wniosku", "urlop_od", "urlop_do", "ilosc_dni_urlopu", "uwagi")
			VALUES (25, 1, 1, '2018-02-21', '2018-03-06', '2018-03-06', 1, NULL)

USE master
GO