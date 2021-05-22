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
        static List<string> myGender = new List<string>();
        static List<StazPracy> Practice = new List<StazPracy>();
        private int IDemployee;
        public Form1()
        {
            InitializeComponent();

            myGender.Add("Kobieta");
            myGender.Add("Mężczyzna");
            cBgender.DataSource = myGender;

            Practice.Add(new StazPracy { practice = 0, days = "20 dni" });
            Practice.Add(new StazPracy { practice = 1, days = "26 dni" });
            cBoxStazPracy.DataSource = Practice;
            cBoxStazPracy.DisplayMember = "days";
            cBoxStazPracy.ValueMember = "practice";

            cBoxStanowisko.DataSource = myDB.GetPosition();
            cBoxStanowisko.DisplayMember = "nazwaST";
            cBoxStanowisko.ValueMember = "IDstanowiska";

            cBoxWCP.DataSource = myDB.GetDayJob();
            cBoxWCP.DisplayMember = "nazwaWCP";
            cBoxWCP.ValueMember = "IDwymiar";

            cBoxEmployee.DataSource = myDB.GetEmployees();
            cBoxEmployee.DisplayMember = "FullName";
            cBoxEmployee.ValueMember = "IDpracownika";



        }
        private void Form1_Load(object sender, EventArgs e)
        {


            tBID.Enabled = false;
            buttonPracownikWykonaj.Enabled = false;

            EmployeeDecorator();

            panelUrlopy.Hide();
            panelZatrudnienie.Hide();
            panelPracownicy.Hide();

            tBoxSelectedEmployee.Text = null;

        }
        #region
        private void buttonShowEmployee_Click(object sender, EventArgs e)
        {
            EmployeeDecorator();
        }
        #region
        private void buttonPanelPracownicy_Click(object sender, EventArgs e)
        {
            panelUrlopy.Hide();
            panelZatrudnienie.Hide();
            panelPracownicy.Show();
            panelPracownicy.BringToFront();
        }

        private void buttonPanelZatrudnienie_Click(object sender, EventArgs e)
        {
            panelUrlopy.Hide();
            panelPracownicy.Hide();
            panelZatrudnienie.Show();
            panelZatrudnienie.BringToFront();
        }

        private void buttonPanelUrlopy_Click(object sender, EventArgs e)
        {
            panelZatrudnienie.Hide();
            panelPracownicy.Hide();
            panelUrlopy.BringToFront();
            panelUrlopy.Show();
        }

        private void buttonPracownikDodaj_Click(object sender, EventArgs e)
        {
            buttonPracownikAkt.Enabled = false;
            buttonPrawconikUsun.Enabled = false;
            buttonPracownikWykonaj.Enabled = true;
        }

        private void buttonPracownikAkt_Click(object sender, EventArgs e)
        {
            buttonPracownikDodaj.Enabled = false;
            buttonPrawconikUsun.Enabled = false;
            buttonPracownikWykonaj.Enabled = true;
        }

        private void buttonPrawconikUsun_Click(object sender, EventArgs e)
        {
            buttonPracownikDodaj.Enabled = false;
            buttonPracownikAkt.Enabled = false;
            buttonPracownikWykonaj.Enabled = true;
        }
        #endregion
        private void buttonPracownikWykonaj_Click(object sender, EventArgs e)
        {
            if (buttonPracownikDodaj.Enabled == true)
            {
                if (DataCheck() == true)
                {
                    Pracownicy newEmployee = new Pracownicy()
                    {
                        imie = tBImie.Text.ToString(),
                        nazwisko = tBNazwisko.Text.ToString(),
                        plec = cBgender.Text.ToString(),
                        numer_pesel = tBnPESEL.Text.ToString(),
                        data_urodzenia = DateTime.Parse(mTBDataUrodzenia.Text.ToString())
                    };
                    myDB.InsertEmployees(newEmployee);
                    EmployeeDecorator();
                    buttonPracownikWykonaj.Enabled = false;
                }
            }

            if (buttonPracownikAkt.Enabled == true)
            {
                if (DataCheck() == true)
                {
                    Pracownicy newEmployee = new Pracownicy()
                    {
                        IDpracownika = int.Parse(tBID.Text),
                        imie = tBImie.Text.ToString(),
                        nazwisko = tBNazwisko.Text.ToString(),
                        plec = cBgender.Text.ToString(),
                        numer_pesel = tBnPESEL.Text.ToString(),
                        data_urodzenia = DateTime.Parse(mTBDataUrodzenia.Text.ToString())
                    };
                    myDB.UpdateEmployees(newEmployee);
                    EmployeeDecorator();
                    buttonPracownikWykonaj.Enabled = false;
                }
            }

            if (buttonPrawconikUsun.Enabled == true)
            {
                if (DataCheck() == true)
                {
                    myDB.DeleteEmployee(tBnPESEL.Text.ToString(), int.Parse(tBID.Text));
                    EmployeeDecorator();
                    buttonPracownikWykonaj.Enabled = false;
                }
            }
            buttonPracownikDodaj.Enabled = true;
            buttonPracownikAkt.Enabled = true;
            buttonPrawconikUsun.Enabled = true;
        }

        private void dataGridViewEmployess_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewEmployess.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmployess.ReadOnly = true;

            tBID.Text = dataGridViewEmployess.CurrentRow.Cells[0].Value.ToString();
            tBImie.Text = dataGridViewEmployess.CurrentRow.Cells[1].Value.ToString();
            tBNazwisko.Text = dataGridViewEmployess.CurrentRow.Cells[2].Value.ToString();
            cBgender.Text = dataGridViewEmployess.CurrentRow.Cells[3].Value.ToString();
            tBnPESEL.Text = dataGridViewEmployess.CurrentRow.Cells[4].Value.ToString();
            mTBDataUrodzenia.Text = dataGridViewEmployess.CurrentRow.Cells[5].Value.ToString();
        }


        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            tBID.Text = "";
            tBImie.Text = "";
            tBNazwisko.Text = "";
            tBnPESEL.Text = "";
            mTBDataUrodzenia.Text = "";

            buttonPracownikDodaj.Enabled = true;
            buttonPracownikAkt.Enabled = true;
            buttonPrawconikUsun.Enabled = true;
            buttonPracownikWykonaj.Enabled = false;
            EmployeeDecorator();
        }
        private void EmployeeDecorator()
        {
            dataGridViewEmployess.DataSource = myDB.GetEmployees().ToList();
        }


        private void tBnPESEL_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("PESEL - tylko 11 cyfr!!!");
            }
        }
        private bool DataCheck()
        {
            if (tBImie.TextLength < 3)
            {
                MessageBox.Show("Niepoprawne imię!");
                return false;
            }
            else if (tBNazwisko.TextLength < 3)
            {
                MessageBox.Show("Niepoprawne nazwisko!");
                return false;
            }
            else if (!(cBgender.Text == "Mężczyzna" || cBgender.Text == "Kobieta"))
            {
                MessageBox.Show("Podaj poprawną płeć!");
                return false;
            }
            else if (tBnPESEL.TextLength != 11)
            {
                MessageBox.Show("Podaj poprawną płeć!");
                return false;
            }
            return true;
        }

        #endregion
        private void cBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            tBoxSelectedEmployee.Text = cBoxEmployee.SelectedValue.ToString();
            if (tBoxSelectedEmployee != null)
            {
                dataGridPeroidOfEmp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridPeroidOfEmp.ReadOnly = true;

                int.TryParse(tBoxSelectedEmployee.Text, out IDemployee);
                dataGridPeroidOfEmp.DataSource = myDB.GetPeroidsOfEmployment(IDemployee);
            }


        }

        //private void dataGridPeroidOfEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //dataGridViewEmployess.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //    //dataGridViewEmployess.ReadOnly = true;

        //    label1.Text = dataGridPeroidOfEmp.CurrentRow.Cells[0].Value.ToString();
        //    cBoxStanowisko.Text = dataGridPeroidOfEmp.CurrentRow.Cells[6].Value.ToString();
        //    tBnaleznyUrlop.Text = dataGridPeroidOfEmp.CurrentRow.Cells[0].Value.ToString();

        //}

        public int staz ()
        {


            return 1;
        }

        private void dataGridPeroidOfEmp_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            label1.Text = dataGridPeroidOfEmp.CurrentRow.Cells[0].Value.ToString();

            if(dataGridPeroidOfEmp.CurrentRow.Cells[4].Value.ToString() == "0")
            {
                cBoxStazPracy.SelectedIndex = Practice[0].practice;
            }
            if (dataGridPeroidOfEmp.CurrentRow.Cells[4].Value.ToString() == "1")
            {
                cBoxStazPracy.SelectedIndex = Practice[1].practice;
            }

            //cBoxStazPracy.Text = dataGridPeroidOfEmp.CurrentRow.Cells[4].Value.ToString();      //not ok
            dTPzatrudnionyOd.Text = dataGridPeroidOfEmp.CurrentRow.Cells[5].Value.ToString();    //ok
            if (dataGridPeroidOfEmp.CurrentRow.Cells[6].Value == null)
            {
                dTPzatrudnionyDo.Hide();
            }
            else
            {
                dTPzatrudnionyDo.Text = dataGridPeroidOfEmp.CurrentRow.Cells[6].Value.ToString();   //ok
                dTPzatrudnionyDo.Show();
            }
            tBnaleznyUrlop.Text = dataGridPeroidOfEmp.CurrentRow.Cells[7].Value.ToString();   //ok
            cBoxStanowisko.Text = dataGridPeroidOfEmp.CurrentRow.Cells[8].Value.ToString();     //ok
            cBoxWCP.Text = dataGridPeroidOfEmp.CurrentRow.Cells[11].Value.ToString();           //ok

        }
    }
}
