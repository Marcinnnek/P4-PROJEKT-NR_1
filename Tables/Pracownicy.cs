using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_PROJEKT_NR_1.Tables
{
    public class Pracownicy
    {
        public int IDpracownika { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string plec { get; set; }
        public string numer_pesel { get; set; }
        public DateTime data_urodzenia { get; set; }

        //public string FullName => $"ID: {IDpracownika}, {imie} {nazwisko}, PESEL: {numer_pesel}";
        public string FullName => $"ID: {IDpracownika},{(IDpracownika.ToString().Length <= 5 ? new string(' ', 5 - IDpracownika.ToString().Length) : " ")} " +
            $"{imie} {(imie.ToString().Length < 14 ? new string(' ', 14 - imie.ToString().Length) : " ")} " +
            $"{nazwisko} {(nazwisko.ToString().Length < 14 ? new string(' ', 14 - nazwisko.ToString().Length) : " ")}  PESEL: {numer_pesel}";
    }
}
