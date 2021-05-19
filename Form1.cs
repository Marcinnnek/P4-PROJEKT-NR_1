using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P4_PROJEKT_NR_1.Tables;
using System.Data;
using System.Data.SqlClient;

namespace P4_PROJEKT_NR_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            
            InitializeComponent();
        }

        private void buttonShowEmployee_Click(object sender, EventArgs e)
        {
            using (SqlConnection myDBconection = new SqlConnection(ConfigurationManager.ConnectionStrings["EWUDatabase"].ConnectionString))
            {
                myDBconection.Open();
                SqlDataAdapter SQLdata = new SqlDataAdapter(    @"SELECT IDpracownika AS 'ID', imie AS 'Imię', nazwisko AS 'Nazwisko', plec AS 'Płeć',
                                                                data_urodzenia AS 'Data Urodzenia', numer_pesel AS 'Numer PESEL' 
                                                                FROM ewu.pracownicy", myDBconection);
                DataTable dataTable = new DataTable();
                SQLdata.Fill(dataTable);

                dataGridViewEmployess.DataSource = dataTable;

            }


        }
    }
}
