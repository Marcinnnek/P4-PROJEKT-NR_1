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
        private static List<string> myGender = new List<string>();
        private static List<StazPracy> Practice = new List<StazPracy>();
        private int IDemployee;
        private int IDperoid = 0;

        private int IDemployee_Leave;
        private int IDperoid_Leave;
        private int IDleave = 0;
        DateTime? UCNO;
        public FormEWU()
        {
            InitializeComponent();

            myGender.Add("Kobieta");    // panel 1
            myGender.Add("Mężczyzna");
            cBgender.DataSource = myGender;

            Practice.Add(new StazPracy { practice = 0, days = "20 dni" }); // panel 2
            Practice.Add(new StazPracy { practice = 1, days = "26 dni" });
            cBoxStazPracy.DataSource = Practice;
            cBoxStazPracy.DisplayMember = "days";
            cBoxStazPracy.ValueMember = "practice";

            cBoxStanowisko.DataSource = myDB.GetPosition(); // panel 2
            cBoxStanowisko.DisplayMember = "nazwaST";
            cBoxStanowisko.ValueMember = "IDstanowiska";

            cBoxWCP.DataSource = myDB.GetDayJob(); // panel 2
            cBoxWCP.DisplayMember = "nazwaWCP";
            cBoxWCP.ValueMember = "IDwymiar";

            cBoxEmployee.DataSource = myDB.GetEmployees(); // panel 2
            cBoxEmployee.DisplayMember = "FullName";
            cBoxEmployee.ValueMember = "IDpracownika";

            CBoxLeaveEmpID.DataSource = myDB.GetEmployees(); // panel 3
            CBoxLeaveEmpID.DisplayMember = "FullName";
            CBoxLeaveEmpID.ValueMember = "IDpracownika";

            CBoxLeaveEmpPeroids.DisplayMember = "FullPeroid";  // panel 3
            CBoxLeaveEmpPeroids.ValueMember = "IDzatrudnienia";

            cBoxLeaveStatus.DataSource = myDB.GetLeaveStatus(); //panel 3
            cBoxLeaveStatus.DisplayMember = "nazwaSU";
            cBoxLeaveStatus.ValueMember = "IDstatus";

            cBoxLeaveType.DataSource = myDB.GetLeaveType();     //panel 3
            cBoxLeaveType.DisplayMember = "nazwaTU";
            cBoxLeaveType.ValueMember = "IDurlopu_typ";

            checkBoxUCNO.Checked = false;
            SwitchPeroidsCB(false);
            SwitchLeaveCB(false);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tBID.Enabled = false;
            buttonPracownikWykonaj.Enabled = false;
            buttonExecutePeroid.Enabled = false;
            BtExecuteLeave.Enabled = false;

            EmployeeRefresh();

            panelUrlopy.Hide();
            panelZatrudnienie.Hide();
            panelPracownicy.Hide();

            tBoxSelectedEmployee.Text = null;
            tBoxSelectedEmployeeLeave.Text = null;

            DefaultLeaveData();
        }
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
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
        #endregion
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

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
            try
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
            catch (SqlException mySQLexception)
            {
                MessageBox.Show(mySQLexception.Message + " Sprawdź poprawność danych!");
            }
        }

        private void dataGridViewEmployess_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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

        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        #region
        private void cBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            tBoxSelectedEmployee.Text = cBoxEmployee.SelectedValue.ToString();
            if (tBoxSelectedEmployee != null)
            {
                int.TryParse(tBoxSelectedEmployee.Text, out IDemployee);
                dataGridPeroidOfEmp.DataSource = myDB.GetPeroidsOfEmployment(IDemployee);

                dTPzatrudnionyOd.Text = DateTime.Now.ToString();
                dTPzatrudnionyDo.Text = DateTime.Now.AddMonths(3).ToString();
            }
        }
        private void dataGridPeroidOfEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
            try
            {
                if (checkBoxUCNO.Checked)
                {
                    UCNO = null;
                }
                else
                {
                    UCNO = DateTime.Parse(dTPzatrudnionyDo.Text.ToString());
                }

                if (buttonAddPeroid.Enabled == true)
                {
                    if (DataCheckPeroid() == true)
                    {

                        OkresZatrudnienia newPeroid = new OkresZatrudnienia()
                        {
                            IDpracownika = int.Parse(cBoxEmployee.SelectedValue.ToString()),
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
                    if (DataCheckPeroid() == true)
                    {
                        if (IDperoid != 0)
                        {
                            OkresZatrudnienia editedPeroid = new OkresZatrudnienia()
                            {
                                IDpracownika = IDemployee,
                                IDzatrudnienia = IDperoid,
                                IDstanowiska = int.Parse(cBoxStanowisko.SelectedValue.ToString()),
                                IDwymiar = int.Parse(cBoxWCP.SelectedValue.ToString()),
                                staz_pracy = int.Parse(cBoxStazPracy.SelectedValue.ToString()),
                                zatrudniony_od = DateTime.Parse(dTPzatrudnionyOd.Text.ToString()),
                                zatrudniony_do = UCNO,
                            };
                            myDB.UpdatePeroid(editedPeroid);
                            buttonExecutePeroid.Enabled = false;
                            dataGridPeroidOfEmp.Enabled = true;
                        }
                        else
                            MessageBox.Show("Wybierz okres zatrudnienia!");
                    }
                }

                if (buttonDeletePeroid.Enabled == true)
                {
                    if (DataCheckPeroid() == true)
                    {
                        if (IDperoid != 0)
                        {
                            myDB.DeletePeroid(IDperoid);
                            buttonExecutePeroid.Enabled = false;
                            dataGridPeroidOfEmp.Enabled = true;
                        }
                        else
                            MessageBox.Show("Wybierz okres zatrudnienia!");
                    }

                }
                buttonAddPeroid.Enabled = true;
                buttonUpdatePeroid.Enabled = true;
                buttonDeletePeroid.Enabled = true;
                SwitchPeroidsCB(false);
                PeroidRefresh(IDemployee);
            }
            catch (SqlException mySQLexception)
            {
                MessageBox.Show(mySQLexception.Message + " Sprawdź poprawność danych!");
            }
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

        private void SwitchPeroidsCB(bool mySwitch)
        {
            cBoxStanowisko.Enabled = mySwitch;
            cBoxWCP.Enabled = mySwitch;
            cBoxStazPracy.Enabled = mySwitch;
            dTPzatrudnionyOd.Enabled = mySwitch;
            dTPzatrudnionyDo.Enabled = mySwitch;
            checkBoxUCNO.Visible = mySwitch;
        }
        private void PeroidRefresh(int id)
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

        private bool DataCheckPeroid()
        {
            if (tBoxSelectedEmployee.Text.ToString() == "")
            {
                MessageBox.Show("Wybierz pracownika!");
                return false;
            }
            else if (dTPzatrudnionyDo != null)
            {
                if (DateTime.Parse(dTPzatrudnionyDo.Text) < DateTime.Parse(dTPzatrudnionyOd.Text))
                {
                    MessageBox.Show("Niepoprawne daty okresu zatrdunienia!");
                    return false;
                }
            }
            return true;
        }

        #endregion

        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

        #region
        private void dataGridViewLeave_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cBoxLeaveStatus.Text = dataGridViewLeave.CurrentRow.Cells[2].Value.ToString();
            cBoxLeaveType.Text = dataGridViewLeave.CurrentRow.Cells[3].Value.ToString();
            dTPLeaveDateApp.Text = dataGridViewLeave.CurrentRow.Cells[4].Value.ToString();
            dTPLeaveSince.Text = dataGridViewLeave.CurrentRow.Cells[5].Value.ToString();
            dTPLeaveTo.Text = dataGridViewLeave.CurrentRow.Cells[6].Value.ToString();
            tBoxLeaveDays.Text = dataGridViewLeave.CurrentRow.Cells[7].Value.ToString();
            if (dataGridViewLeave.CurrentRow.Cells[8].Value == null)
            {
                tBoxLeaveNote.Text = "brak";
            }
            else
            {
                tBoxLeaveNote.Text = dataGridViewLeave.CurrentRow.Cells[8].Value.ToString();
            }
            IDleave = int.Parse(dataGridViewLeave.CurrentRow.Cells[0].Value.ToString());
        }

        private void CBoxLeaveEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            tBoxSelectedEmployeeLeave.Text = CBoxLeaveEmpID.SelectedValue.ToString();
            if (tBoxSelectedEmployeeLeave != null)
            {
                int.TryParse(tBoxSelectedEmployeeLeave.Text, out IDemployee_Leave);
                CBoxLeaveEmpPeroids.DataSource = myDB.GetPeroidsOfEmployment(IDemployee_Leave);
            }
        }

        private void CBoxLeaveEmpPeroids_SelectedIndexChanged(object sender, EventArgs e)
        {
            tBoxSelectedPeroidsLeave.Text = CBoxLeaveEmpPeroids.SelectedValue.ToString();
            int.TryParse(tBoxSelectedPeroidsLeave.Text, out IDperoid_Leave);
            dataGridViewLeave.DataSource = myDB.GetEmployeeLeaves(IDperoid_Leave);
        }

        private void BtAddLeave_Click(object sender, EventArgs e)
        {
            BtUpdateLeave.Enabled = false;
            BtDeleteLeave.Enabled = false;
            BtExecuteLeave.Enabled = true;
            dataGridViewLeave.Enabled = false;

            SwitchLeaveCB(true);
        }

        private void BtUpdateLeave_Click(object sender, EventArgs e)
        {
            BtAddLeave.Enabled = false;
            BtDeleteLeave.Enabled = false;
            BtExecuteLeave.Enabled = true;
            dataGridViewLeave.Enabled = false;

            SwitchLeaveCB(true);
        }

        private void BtDeleteLeave_Click(object sender, EventArgs e)
        {
            BtAddLeave.Enabled = false;
            BtUpdateLeave.Enabled = false;
            BtExecuteLeave.Enabled = true;
            dataGridViewLeave.Enabled = false;

            SwitchLeaveCB(true);
        }

        private void BtCancelLeave_Click(object sender, EventArgs e)
        {
            LeaveRefresh(IDperoid_Leave);
            SwitchLeaveCB(false);
        }


        private void BtExecuteLeave_Click(object sender, EventArgs e)
        {
            try
            {
                string? notes = tBoxLeaveNote.Text.ToString();
                notes = notes.Trim();
                if (tBoxLeaveNote.Text.ToString() == "brak")
                {
                    notes = null;
                }

                if (BtAddLeave.Enabled == true)
                {
                    if (DateTime.Parse(dTPLeaveDateApp.Text.ToString()) < DateTime.Parse(dTPLeaveSince.Text.ToString()))
                    {
                        Urlopy newLeave = new Urlopy()
                        {
                            IDzatrudnienia = IDperoid_Leave,
                            IDstatus = int.Parse(cBoxLeaveStatus.SelectedValue.ToString()),
                            IDurlopu_typ = int.Parse(cBoxLeaveType.SelectedValue.ToString()),
                            data_wniosku = DateTime.Parse(dTPLeaveDateApp.Text.ToString()),
                            urlop_od = DateTime.Parse(dTPLeaveSince.Text.ToString()),
                            urlop_do = DateTime.Parse(dTPLeaveTo.Text.ToString()),
                            ilosc_dni_urlopu = int.Parse(tBoxLeaveDays.Text.ToString()),
                            uwagi = notes
                        };
                        myDB.InsertLeave(newLeave);
                        BtExecuteLeave.Enabled = false;
                        dataGridViewLeave.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Sprawdź poprawność danych!");
                    }
                }

                if (BtUpdateLeave.Enabled == true)
                {
                    if (IDperoid_Leave != 0 || IDleave != 0)
                    {
                        Urlopy editedLeave = new Urlopy()
                        {
                            IDewidencji = IDleave,
                            IDzatrudnienia = IDperoid_Leave,
                            IDstatus = int.Parse(cBoxLeaveStatus.SelectedValue.ToString()),
                            IDurlopu_typ = int.Parse(cBoxLeaveType.SelectedValue.ToString()),
                            data_wniosku = DateTime.Parse(dTPLeaveDateApp.Text.ToString()),
                            urlop_od = DateTime.Parse(dTPLeaveSince.Text.ToString()),
                            urlop_do = DateTime.Parse(dTPLeaveTo.Text.ToString()),
                            ilosc_dni_urlopu = int.Parse(tBoxLeaveDays.Text.ToString()),
                            uwagi = notes
                        };
                        myDB.UpdateLeave(editedLeave);
                        buttonExecutePeroid.Enabled = false;
                        dataGridViewLeave.Enabled = true;
                    }
                    else
                        MessageBox.Show("Wybierz odpowiedni urlop!");
                }

                if (BtDeleteLeave.Enabled == true)
                {

                    if (IDperoid_Leave != 0)
                    {
                        myDB.DeleteLeave(IDleave);
                        buttonExecutePeroid.Enabled = false;
                        dataGridViewLeave.Enabled = true;
                    }
                    else
                        MessageBox.Show("Wybierz który urlop chcesz usunąć!");
                }
                BtAddLeave.Enabled = true;
                BtUpdateLeave.Enabled = true;
                BtDeleteLeave.Enabled = true;
                SwitchLeaveCB(false);
                LeaveRefresh(IDperoid_Leave);
            }
            catch (SqlException mySQLexception)
            {
                MessageBox.Show(mySQLexception.Message + " Sprawdź poprawność danych!");
            }

        }


        private void LeaveRefresh(int id)
        {
            BtAddLeave.Enabled = true;
            BtDeleteLeave.Enabled = true;
            BtUpdateLeave.Enabled = true;
            dataGridViewLeave.Enabled = true;

            BtExecuteLeave.Enabled = false;

            dataGridViewLeave.DataSource = myDB.GetEmployeeLeaves(id);
        }

        private void SwitchLeaveCB(bool mySwitch)
        {
            cBoxLeaveStatus.Enabled = mySwitch;
            cBoxLeaveType.Enabled = mySwitch;
            dTPLeaveDateApp.Enabled = mySwitch;
            dTPLeaveSince.Enabled = mySwitch;
            dTPLeaveTo.Enabled = mySwitch;
            tBoxLeaveDays.Enabled = mySwitch;
            tBoxLeaveNote.Enabled = mySwitch;
        }

        public void DefaultLeaveData()
        {
            dTPLeaveDateApp.Text = DateTime.Now.AddDays(-1).ToString();
            dTPLeaveSince.Text = DateTime.Now.ToString();
            dTPLeaveTo.Text = DateTime.Now.ToString();
            tBoxLeaveNote.Text = "brak";

        }
        private void dTPLeaveDateApp_ValueChanged(object sender, EventArgs e)
        {
            dTPLeaveSince.MinDate = DateTime.Parse(dTPLeaveDateApp.Text.ToString());
        }

        private void dTPLeaveSince_ValueChanged(object sender, EventArgs e)
        {
            tBoxLeaveDays.Text = AmountLeaveDays(DateTime.Parse(dTPLeaveSince.Text.ToString()), DateTime.Parse(dTPLeaveTo.Text.ToString())).ToString();
            dTPLeaveTo.MinDate = DateTime.Parse(dTPLeaveSince.Text.ToString());
        }

        private void dTPLeaveTo_ValueChanged(object sender, EventArgs e)
        {
            tBoxLeaveDays.Text = AmountLeaveDays(DateTime.Parse(dTPLeaveSince.Text.ToString()), DateTime.Parse(dTPLeaveTo.Text.ToString())).ToString();
        }

        private int AmountLeaveDays(DateTime since, DateTime to)
        {
            var dates = new List<DateTime>();
            DateTime dt = since;
            DateTime start = since;
            DateTime end = to;

            for (dt = start; dt <= end; dt = dt.AddDays(1))
            {
                dates.Add(dt);
            }

            int DniUrlopu = 0;
            for (int i = 0; i < dates.Count; i++)
            {
                if (CzySwieto(dates[i]) == true)
                {
                    DniUrlopu--;
                }
                else
                    DniUrlopu++;
            }
            return DniUrlopu;
        }
        private static bool CzySwieto(DateTime Day)
        {
            if (Day.DayOfWeek == DayOfWeek.Sunday) return true;
            if (Day.Month == 1 && Day.Day == 1) return true; // Nowy Rok
            if (Day.Month == 1 && Day.Day == 6) return true; // 3 króli
            if (Day.Month == 5 && Day.Day == 1) return true; // 1 maja
            if (Day.Month == 5 && Day.Day == 3) return true; // 3 maja
            if (Day.Month == 8 && Day.Day == 15) return true; // Święto Wojska Polskiego
            if (Day.Month == 11 && Day.Day == 1) return true; // Wszystkich Świętych
            if (Day.Month == 11 && Day.Day == 11) return true; // Dzień Niepodległości
            if (Day.Month == 12 && Day.Day == 25) return true; // Boże Narodzenie
            if (Day.Month == 12 && Day.Day == 26) return true; // Boże Narodzenie
            int a = Day.Year % 19;
            int b = Day.Year % 4;
            int c = Day.Year % 7;
            int d = (a * 19 + 24) % 30;
            int e = (2 * b + 4 * c + 6 * d + 5) % 7;
            if (d == 29 && e == 6) d -= 7;
            if (d == 28 && e == 6 && a > 10) d -= 7;
            DateTime wielkanoc = new DateTime(Day.Year, 3, 22).AddDays(d + e);
            if (Day.AddDays(-1) == wielkanoc)
                return true; // Wielkanoc (poniedziałek)
            if (Day.AddDays(-60) == wielkanoc)
                return true; // Boże Ciało
            return false;
        }


        #endregion


    }
}
