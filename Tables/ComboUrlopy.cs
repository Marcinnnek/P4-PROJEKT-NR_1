using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_PROJEKT_NR_1.Tables
{
    public class ComboUrlopy
    {
        //urlopy
        public int IDewidencji { get; set; }             //0
        public int IDzatrudnienia { get; set; }          //1
        public int IDstatus { get; set; }                //2
        public int IDurlopu_typ { get; set; }            //3
        public DateTime data_wniosku { get; set; }       //4
        public DateTime urlop_od { get; set; }           //5
        public DateTime urlop_do { get; set; }           //6
        public int ilosc_dni_urlopu { get; set; }        //7  
        public string uwagi { get; set; }                //8

        //typ_urlopu
        public string nazwaTU { get; set; }              //9
        //status urlopu
        public string nazwaSU { get; set; }              //10
    }
}
