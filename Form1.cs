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
    public partial class FormEWU : Form
    {
        static List<string> myGender = new List<string>();
        static List<StazPracy> Practice = new List<StazPracy>();
        private int IDemployee;
        private int IDperoid;
        DateTime? UCNO;
        public FormEWU()
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

            checkBoxUCNO.Checked = false;
            SwitchPeroidsCB(false);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            tBID.Enabled = false;
            buttonPracownikWykonaj.Enabled = false;
            buttonExecutePeroid.Enabled = false;

            EmployeeRefresh();

            panelUrlopy.Hide();
            panelZatrudnienie.Hide();
            panelPracownicy.Hide();

            tBoxSelectedEmployee.Text = null;

            tBnaleznyUrlop.Enabled = false;
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
        private void buttonShowEmployee_Click(object sender, EventArgs e)
        {
            EmployeeRefresh();
        }

        #endregion
        #region
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

        private void buttonPracownikWykonaj_Click(object sender, EventArgs e)
        {
            if (buttonPracownikDodaj.Enabled == true)
            {
                if (DataCheckEmp() == true)
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
                    buttonPracownikWykonaj.Enabled = false;
                }
            }

            if (buttonPracownikAkt.Enabled == true)
            {
                if (DataCheckEmp() == true)
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
                    buttonPracownikWykonaj.Enabled = false;
                }
            }

            if (buttonPrawconikUsun.Enabled == true)
            {
                if (DataCheckEmp() == true)
                {
                    myDB.DeleteEmployee(tBnPESEL.Text.ToString(), int.Parse(tBID.Text));
                    buttonPracownikWykonaj.Enabled = false;
                }
            }
            buttonPracownikDodaj.Enabled = true;
            buttonPracownikAkt.Enabled = true;
            buttonPrawconikUsun.Enabled = true;
            cBoxEmployee.DataSource = myDB.GetEmployees();
            EmployeeRefresh();
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
            EmployeeRefresh();
        }
        private void EmployeeRefresh()
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
        private bool DataCheckEmp()
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

                dTPzatrudnionyOd.Text = DateTime.Now.ToString();
                dTPzatrudnionyDo.Text = DateTime.Now.AddMonths(3).ToString();
            }
        }
        private void dataGridPeroidOfEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = IDperoid.ToString();
            label2.Text = cBoxStazPracy.SelectedValue.ToString();
            label4.Text = dTPzatrudnionyOd.Text.ToString();
            label5.Text = dTPzatrudnionyDo.Text.ToString();
            label3.Text = cBoxWCP.SelectedValue.ToString();
            labelTEST.Text = cBoxStanowisko.SelectedValue.ToString();

            int.TryParse(dataGridPeroidOfEmp.CurrentRow.Cells[0].Value.ToString(), out IDperoid);
            if (dataGridPeroidOfEmp.CurrentRow.Cells[4].Value.ToString() == "0")
            {
                cBoxStazPracy.SelectedIndex = Practice[0].practice;
            }
            if (dataGridPeroidOfEmp.CurrentRow.Cells[4].Value.ToString() == "1")
            {
                cBoxStazPracy.SelectedIndex = Practice[1].practice;
            }

            dTPzatrudnionyOd.Text = dataGridPeroidOfEmp.CurrentRow.Cells[5].Value.ToString();    //ok
            if (dataGridPeroidOfEmp.CurrentRow.Cells[6].Value == null)
            {
                dTPzatrudnionyDo.Text = DateTime.Now.AddMonths(3).ToString();
            }
            else
            {
                dTPzatrudnionyDo.Text = dataGridPeroidOfEmp.CurrentRow.Cells[6].Value.ToString();   //ok
            }

            tBnaleznyUrlop.Text = dataGridPeroidOfEmp.CurrentRow.Cells[7].Value.ToString();   //ok
            cBoxStanowisko.Text = dataGridPeroidOfEmp.CurrentRow.Cells[8].Value.ToString();     //ok
            cBoxWCP.Text = dataGridPeroidOfEmp.CurrentRow.Cells[11].Value.ToString();           //ok
        }


        private void buttonExecutePeroid_Click(object sender, EventArgs e)
        {
            if (buttonAddPeroid.Enabled == true)
            {
                if (true)
                {
                    if (checkBoxUCNO.Checked)
                    {
                        UCNO = null;
                    }
                    else
                    {
                        UCNO = DateTime.Parse(dTPzatrudnionyDo.Text.ToString());
                    }
                    OkresZatrudnienia newPeroid = new OkresZatrudnienia()
                    {
                        IDpracownika = int.Parse(tBoxSelectedEmployee.Text.ToString()),
                        IDstanowiska = int.Parse(cBoxStanowisko.SelectedValue.ToString()),
                        IDwymiar = int.Parse(cBoxWCP.SelectedValue.ToString()),
                        staz_pracy = int.Parse(cBoxStazPracy.SelectedValue.ToString()),
                        zatrudniony_od = DateTime.Parse(dTPzatrudnionyOd.Text.ToString()),
                        zatrudniony_do = UCNO
                    };
                    myDB.InsertPeroid(newPeroid);
                    buttonExecutePeroid.Enabled = false;
                    dataGridPeroidOfEmp.Enabled = true;
                }
            }

            if (buttonUpdatePeroid.Enabled == true)
            {
                if (true)
                {
                    OkresZatrudnienia editedPeroid = new OkresZatrudnienia()
                    {
                        IDpracownika = IDemployee,
                        IDzatrudnienia = IDperoid,
                        IDstanowiska = int.Parse(cBoxStanowisko.SelectedValue.ToString()),
                        IDwymiar = int.Parse(cBoxWCP.SelectedValue.ToString()),
                        staz_pracy = int.Parse(cBoxStazPracy.SelectedValue.ToString()),
                        zatrudniony_od = DateTime.Parse(dTPzatrudnionyOd.Text.ToString()),
                        zatrudniony_do = DateTime.Parse(dTPzatrudnionyDo.Text.ToString()),

                    };
                    myDB.UpdatePeroid(editedPeroid);
                    buttonExecutePeroid.Enabled = false;
                    dataGridPeroidOfEmp.Enabled = true;
                }
            }

            if (buttonDeletePeroid.Enabled == true)
            {
                if (true)
                {
                    myDB.DeletePeroid(IDperoid);
                    buttonExecutePeroid.Enabled = false;
                    dataGridPeroidOfEmp.Enabled = true;
                }
            }
            buttonAddPeroid.Enabled = true;
            buttonUpdatePeroid.Enabled = true;
            buttonDeletePeroid.Enabled = true;
            SwitchPeroidsCB(false);
            PeroidRefresh(IDemployee);
        }

        private void buttonAddPeroid_Click(object sender, EventArgs e)
        {
            buttonUpdatePeroid.Enabled = false;
            buttonDeletePeroid.Enabled = false;
            buttonExecutePeroid.Enabled = true;
            dataGridPeroidOfEmp.Enabled = false;

            SwitchPeroidsCB(true);

            checkBoxUCNO.Show();
        }

        private void buttonUpdatePeroid_Click(object sender, EventArgs e)
        {
            buttonAddPeroid.Enabled = false;
            buttonDeletePeroid.Enabled = false;
            buttonExecutePeroid.Enabled = true;
            dataGridPeroidOfEmp.Enabled = false;

            dTPzatrudnionyDo.Show();
            SwitchPeroidsCB(true);

            checkBoxUCNO.Show();
        }

        private void buttonDeletePeroid_Click(object sender, EventArgs e)
        {
            buttonAddPeroid.Enabled = false;
            buttonUpdatePeroid.Enabled = false;
            buttonExecutePeroid.Enabled = true;
            dataGridPeroidOfEmp.Enabled = false;

            SwitchPeroidsCB(true);
        }


        public void SwitchPeroidsCB(bool mySwitch)
        {
            cBoxStanowisko.Enabled = mySwitch;
            cBoxWCP.Enabled = mySwitch;
            cBoxStazPracy.Enabled = mySwitch;
            dTPzatrudnionyOd.Enabled = mySwitch;
            dTPzatrudnionyDo.Enabled = mySwitch;
            checkBoxUCNO.Visible = mySwitch;
        }
        public void PeroidRefresh(int id)
        {
            buttonAddPeroid.Enabled = true;
            buttonDeletePeroid.Enabled = true;
            buttonUpdatePeroid.Enabled = true;
            dataGridPeroidOfEmp.Enabled = true;

            buttonExecutePeroid.Enabled = false;

            dataGridPeroidOfEmp.DataSource = myDB.GetPeroidsOfEmployment(id);
        }


        private void buttonPeroidCancel_Click(object sender, EventArgs e)
        {
            PeroidRefresh(IDemployee);
            SwitchPeroidsCB(false);
        }
    }
}
