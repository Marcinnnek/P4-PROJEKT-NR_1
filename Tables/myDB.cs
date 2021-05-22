﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using System.Configuration;

namespace P4_PROJEKT_NR_1.Tables
{
    public static class myDB
    {
        #region
        public static IEnumerable<Pracownicy> GetEmployees()
        {
            using (IDbConnection myDBconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EWUDatabase"].ConnectionString))
            {
                if (myDBconnection.State == ConnectionState.Closed)
                    myDBconnection.Open();
                return myDBconnection.Query<Pracownicy>(@"SELECT IDpracownika, imie, nazwisko, plec, numer_pesel, data_urodzenia FROM ewu.pracownicy").ToList();
            }
        }

        public static bool InsertEmployees(Pracownicy emp)
        {
            using (IDbConnection myDBconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EWUDatabase"].ConnectionString))
            {
                if (myDBconnection.State == ConnectionState.Closed)
                    myDBconnection.Open();
                var result = myDBconnection.Execute(@"INSERT INTO ewu.pracownicy(imie, nazwisko, plec, numer_pesel, data_urodzenia) 
                                                        VALUES (@Name, @Surname, @Gender, @PESEL, @BDate)",
                    new { Name = emp.imie, SurName = emp.nazwisko, Gender = emp.plec, PESEL = emp.numer_pesel, BDate = emp.data_urodzenia });
                return result == 1;
            }
        }

        public static bool UpdateEmployees(Pracownicy emp)
        {
            using (IDbConnection myDBconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EWUDatabase"].ConnectionString))
            {
                if (myDBconnection.State == ConnectionState.Closed)
                    myDBconnection.Open();
                var result = myDBconnection.Execute(@"UPDATE ewu.pracownicy SET imie = @Name, nazwisko = @Surname, plec = @Gender, numer_pesel = @PESEL, data_urodzenia = @BDate
                                                     WHERE IDpracownika = @ID",
                 new
                 {
                     Name = emp.imie,
                     SurName = emp.nazwisko,
                     Gender = emp.plec,
                     PESEL = emp.numer_pesel,
                     BDate = emp.data_urodzenia,
                     ID = emp.IDpracownika
                 });
                return result == 1;
            }
        }

        public static bool DeleteEmployee(string PESEL, int IDempolyee)
        {
            using (IDbConnection myDBconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EWUDatabase"].ConnectionString))
            {
                if (myDBconnection.State == ConnectionState.Closed)
                    myDBconnection.Open();
                var result = myDBconnection.Execute(@"DELETE FROM ewu.pracownicy WHERE IDpracownika = @ID OR numer_pesel = @PESEL",
                new { PESEL = PESEL, ID = IDempolyee});

                return result == 1;
            }
        }
        #endregion
        public static IEnumerable<ComboOkresZatrudnienia> GetPeroidsOfEmployment(int id )
        {

            using (IDbConnection myDBconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EWUDatabase"].ConnectionString))
            {
                if (myDBconnection.State == ConnectionState.Closed)
                    myDBconnection.Open();
                return myDBconnection.Query<ComboOkresZatrudnienia>(@"SELECT OZ.IDzatrudnienia, OZ. IDpracownika, OZ.IDstanowiska, OZ.IDwymiar, OZ.nalezny_urlop, OZ.zatrudniony_od,
                                                                    OZ.zatrudniony_do, OZ.staz_pracy, nazwaWCP, nazwaST, opisST
                                                                    FROM ewu.pracownicy AS P	INNER JOIN ewu.okres_zatrudnienia AS OZ ON P.IDpracownika=OZ.IDpracownika
							                                        INNER JOIN ewu.stanowisko AS S ON OZ.IDstanowiska=S.IDstanowiska
							                                        INNER JOIN ewu.wymiar_czasu_pracy AS WCP ON OZ.IDwymiar=WCP.IDwymiar
                                                                    WHERE OZ.IDpracownika = @IDemp", new { IDemp = id }).ToList();
            }
        }


        public static IEnumerable<Stanowisko> GetPosition()
        {

            using (IDbConnection myDBconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EWUDatabase"].ConnectionString))
            {
                if (myDBconnection.State == ConnectionState.Closed)
                    myDBconnection.Open();
                return myDBconnection.Query<Stanowisko>(@"SELECT * FROM ewu.stanowisko").ToList();
            }
        }

        public static IEnumerable<WymiarCzasuPracy> GetDayJob()
        {

            using (IDbConnection myDBconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EWUDatabase"].ConnectionString))
            {
                if (myDBconnection.State == ConnectionState.Closed)
                    myDBconnection.Open();
                return myDBconnection.Query<WymiarCzasuPracy>(@"SELECT * FROM ewu.wymiar_czasu_pracy").ToList();
            }
        }
    }

}