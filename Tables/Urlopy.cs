using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_PROJEKT_NR_1.Tables
{
    public class Urlopy
    {
        public int IDewidencji { get; set; }
        public int IDzatrudnienia { get; set; }
        public int IDstatus { get; set; }
        public int IDurlopu_typ { get; set; }
        public DateTime data_wniosku { get; set; }
        public DateTime urlop_od { get; set; }
        public DateTime urlop_do { get; set; }
        public int ilosc_dni_urlopu { get; set; }
        public string uwagi { get; set; }
    }
}
