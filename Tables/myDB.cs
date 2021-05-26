using System;
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
                var result = myDBconnection.Execute(@"UPDATE ewu.pracownicy SET imie = @Name, 
                                                                                nazwisko = @Surname,
                                                                                plec = @Gender,
                                                                                numer_pesel = @PESEL,
                                                                                data_urodzenia = @BDate
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
                var result = myDBconnection.Execute(@"DELETE FROM ewu.pracownicy 
                                                        WHERE IDpracownika = @ID OR numer_pesel = @PESEL",
                new { PESEL = PESEL, ID = IDempolyee });

                return result == 1;
            }
        }
        #endregion
        public static IEnumerable<ComboOkresZatrudnienia> GetPeroidsOfEmployment(int IDperoid)
        {
            using (IDbConnection myDBconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EWUDatabase"].ConnectionString))
            {
                if (myDBconnection.State == ConnectionState.Closed)
                    myDBconnection.Open();
                return myDBconnection.Query<ComboOkresZatrudnienia>(@"SELECT OZ.IDzatrudnienia, OZ.IDpracownika, OZ.IDstanowiska, OZ.IDwymiar, OZ.nalezny_urlop, OZ.zatrudniony_od,
                                                                    OZ.zatrudniony_do, OZ.staz_pracy, nazwaWCP, nazwaST, opisST
                                                                    FROM ewu.pracownicy AS P	INNER JOIN ewu.okres_zatrudnienia AS OZ ON P.IDpracownika=OZ.IDpracownika
							                                        INNER JOIN ewu.stanowisko AS S ON OZ.IDstanowiska=S.IDstanowiska
							                                        INNER JOIN ewu.wymiar_czasu_pracy AS WCP ON OZ.IDwymiar=WCP.IDwymiar
                                                                    WHERE OZ.IDpracownika = @IDemp", new { IDemp = IDperoid }).ToList();
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
        public static bool InsertPeroid(OkresZatrudnienia newPeroid)
        {
            using (IDbConnection myDBconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EWUDatabase"].ConnectionString))
            {
                if (myDBconnection.State == ConnectionState.Closed)
                    myDBconnection.Open();
                var result = myDBconnection.Execute(@"INSERT INTO ewu.okres_zatrudnienia 
                                                    (IDpracownika, IDstanowiska, IDwymiar, staz_pracy, zatrudniony_od, zatrudniony_do) 
                                                    VALUES (@IDemp, @Position, @DayJob, @Practice ,@Since, @ToDate)",
                     new
                     {
                         IDemp = newPeroid.IDpracownika,
                         Position = newPeroid.IDstanowiska,
                         DayJob = newPeroid.IDwymiar,
                         Practice = newPeroid.staz_pracy,
                         Since = newPeroid.zatrudniony_od,
                         ToDate = newPeroid.zatrudniony_do
                     });
                return result == 1;
            }
        }

        public static bool DeletePeroid(int IDperoid)
        {
            using (IDbConnection myDBconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EWUDatabase"].ConnectionString))
            {
                if (myDBconnection.State == ConnectionState.Closed)
                    myDBconnection.Open();
                var result = myDBconnection.Execute(@"DELETE FROM ewu.okres_zatrudnienia WHERE IDzatrudnienia = @IDp",
                new { IDp = IDperoid });

                return result == 1;
            }
        }

        public static bool UpdatePeroid(OkresZatrudnienia updatedPeroid)
        {
            using (IDbConnection myDBconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EWUDatabase"].ConnectionString))
            {
                if (myDBconnection.State == ConnectionState.Closed)
                    myDBconnection.Open();
                var result = myDBconnection.Execute(@"UPDATE ewu.okres_zatrudnienia 
                                                    SET 
                                                    IDpracownika = @IDemployee,
                                                    IDstanowiska = @Position, 
                                                    IDwymiar = @DayJob, 
                                                    staz_pracy = @DayJob,
                                                    zatrudniony_od = @Since,
                                                    zatrudniony_do = @ToDate
                                                    WHERE IDzatrudnienia = @IDper",
                 new
                 {
                     IDemployee = updatedPeroid.IDpracownika,
                     IDper = updatedPeroid.IDzatrudnienia,
                     Position = updatedPeroid.IDstanowiska,
                     DayJob = updatedPeroid.IDwymiar,
                     Practice = updatedPeroid.staz_pracy,
                     Since = updatedPeroid.zatrudniony_od,
                     ToDate = updatedPeroid.zatrudniony_do
                 });
                return result == 1;
            }
        }












        public static bool InsertLeave(Urlopy newLeave)
        {
            using (IDbConnection myDBconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EWUDatabase"].ConnectionString))
            {
                if (myDBconnection.State == ConnectionState.Closed)
                    myDBconnection.Open();
                var result = myDBconnection.Execute(@"INSERT INTO ewu.urlopy
                                                    (IDzatrudnienia, IDstatus, IDurlopu_typ, data_wniosku, urlop_od, urlop_do, ilosc_dni_urlopu, uwagi) 
                                                    VALUES (@IDperoid, @Status, @IDLeaveType, @AppDate,@Since, @To, @Quantity, @Notes)",
                     new
                     {
                        IDperoid = newLeave.IDzatrudnienia,
                        Status = newLeave.IDstatus,
                        IDLeaveType = newLeave.IDurlopu_typ,
                        AppDate = newLeave.data_wniosku,
                        Since = newLeave.urlop_od,
                        To = newLeave.urlop_do,
                        Quantity = newLeave.ilosc_dni_urlopu,
                        Notes = newLeave.uwagi
                     });
                return result == 1;
            }
        }

        public static bool UpdateLeave(Urlopy editedLeave)
        {
            using (IDbConnection myDBconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EWUDatabase"].ConnectionString))
            {
                if (myDBconnection.State == ConnectionState.Closed)
                    myDBconnection.Open();
                var result = myDBconnection.Execute(@"UPDATE ewu.urlopy 
                                                    SET
                                                    IDstatus = @Status,
                                                    IDurlopu_typ = @IDLeaveType, 
                                                    data_wniosku = @AppDate, 
                                                    urlop_od = @Since,
                                                    urlop_do = @To,
                                                    ilosc_dni_urlopu = @Quantity,
                                                    uwagi = @Notes
                                                    WHERE IDewidencji = @IDLeave",
                 new
                 {
                     Status = editedLeave.IDstatus,
                     IDLeaveType = editedLeave.IDurlopu_typ,
                     AppDate = editedLeave.data_wniosku,
                     Since = editedLeave.urlop_od,
                     To = editedLeave.urlop_do,
                     Quantity = editedLeave.ilosc_dni_urlopu,
                     Notes = editedLeave.uwagi,
                     IDLeave = editedLeave.IDewidencji
                 });
                return result == 1;
            }
        }



        public static bool DeleteLeave(int IDleave)
        {
            using (IDbConnection myDBconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EWUDatabase"].ConnectionString))
            {
                if (myDBconnection.State == ConnectionState.Closed)
                    myDBconnection.Open();
                var result = myDBconnection.Execute(@"DELETE FROM ewu.urlopy WHERE IDewidencji = @IDl",
                new { IDl = IDleave });

                return result == 1;
            }
        }




        public static IEnumerable<TypUrlopu> GetLeaveType()
        {
            using (IDbConnection myDBconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EWUDatabase"].ConnectionString))
            {
                if (myDBconnection.State == ConnectionState.Closed)
                    myDBconnection.Open();
                return myDBconnection.Query<TypUrlopu>(@"SELECT * FROM ewu.typ_urlopu").ToList();
            }
        }

        public static IEnumerable<StatusUrlopu> GetLeaveStatus()
        {
            using (IDbConnection myDBconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EWUDatabase"].ConnectionString))
            {
                if (myDBconnection.State == ConnectionState.Closed)
                    myDBconnection.Open();
                return myDBconnection.Query<StatusUrlopu>(@"SELECT * FROM ewu.status_urlopu").ToList();
            }
        }

        public static IEnumerable<ComboUrlopy> GetEmployeeLeaves(int id)
        {
            using (IDbConnection myDBconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["EWUDatabase"].ConnectionString))
            {
                if (myDBconnection.State == ConnectionState.Closed)
                    myDBconnection.Open();
                return myDBconnection.Query<ComboUrlopy>(   @"SELECT* FROM ewu.urlopy AS U INNER JOIN ewu.status_urlopu AS SU ON U.IDstatus=SU.IDstatus
                                                            INNER JOIN EWU.typ_urlopu AS TU ON U.IDurlopu_typ=TU.IDurlopu_typ
                                                            WHERE IDzatrudnienia = @IDperoid", new { IDperoid = id }).ToList();
            }
        }


    }
}

