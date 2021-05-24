using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_PROJEKT_NR_1.Tables
{
    public class ComboOkresZatrudnienia
    {
        public int IDzatrudnienia { get; set; }     //0
        public int IDpracownika { get; set; }       //1
        public int IDstanowiska { get; set; }        //2
        public int IDwymiar { get; set; }            //3 
        public int staz_pracy { get; set; }         //4
        public DateTime zatrudniony_od { get; set; }//5
        public DateTime? zatrudniony_do { get; set; }//6
        public int nalezny_urlop { get; set; }      //7
        public string nazwaST { get; set; }         //8
        public string opisST { get; set; }          //9
        public float etat { get; set; }             //10   
        public string nazwaWCP { get; set; }        //11


        public string FullPeroid => $"ID: {IDzatrudnienia}, Zatrudniony: {zatrudniony_od.ToString()[..^8]} -  {(zatrudniony_do == null ? "" : zatrudniony_do.ToString()[..^8])}";
    }
}
