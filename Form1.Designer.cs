
namespace P4_PROJEKT_NR_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonShowEmployee = new System.Windows.Forms.Button();
            this.panelPracownicy = new System.Windows.Forms.Panel();
            this.cBgender = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.mTBDataUrodzenia = new System.Windows.Forms.MaskedTextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.tBID = new System.Windows.Forms.TextBox();
            this.labelDataUrodzenia = new System.Windows.Forms.Label();
            this.labelPESEL = new System.Windows.Forms.Label();
            this.labelPlec = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelImie = new System.Windows.Forms.Label();
            this.tBnPESEL = new System.Windows.Forms.TextBox();
            this.tBNazwisko = new System.Windows.Forms.TextBox();
            this.tBImie = new System.Windows.Forms.TextBox();
            this.buttonPracownikWykonaj = new System.Windows.Forms.Button();
            this.buttonPracownikDodaj = new System.Windows.Forms.Button();
            this.buttonPrawconikUsun = new System.Windows.Forms.Button();
            this.buttonPracownikAkt = new System.Windows.Forms.Button();
            this.dataGridViewEmployess = new System.Windows.Forms.DataGridView();
            this.IDpracownika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numer_pesel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_urodzenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelZatrudnienie = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridPeroidOfEmp = new System.Windows.Forms.DataGridView();
            this.IDzatrudnienia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZatrudnionyOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZatrudnionyDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naleznyUrlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stazPracy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stanowisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpracownikahidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etathidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDStanowisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDwymiar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBoxStanowisko = new System.Windows.Forms.ComboBox();
            this.cBoxWCP = new System.Windows.Forms.ComboBox();
            this.tBnaleznyUrlop = new System.Windows.Forms.TextBox();
            this.dTPzatrudnionyDo = new System.Windows.Forms.DateTimePicker();
            this.dTPzatrudnionyOd = new System.Windows.Forms.DateTimePicker();
            this.cBoxStazPracy = new System.Windows.Forms.ComboBox();
            this.labelStanowisko = new System.Windows.Forms.Label();
            this.labelWCP = new System.Windows.Forms.Label();
            this.labelNaleznyUrlop = new System.Windows.Forms.Label();
            this.labelZatrudnionyDo = new System.Windows.Forms.Label();
            this.labelZatrudnionyOd = new System.Windows.Forms.Label();
            this.labelStazPracy = new System.Windows.Forms.Label();
            this.cBoxEmployee = new System.Windows.Forms.ComboBox();
            this.tBoxSelectedEmployee = new System.Windows.Forms.TextBox();
            this.buttonDeletePeroid = new System.Windows.Forms.Button();
            this.buttonUpdatePeroid = new System.Windows.Forms.Button();
            this.buttonAddPeroid = new System.Windows.Forms.Button();
            this.buttonExecutePeroid = new System.Windows.Forms.Button();
            this.labelSelEmpID = new System.Windows.Forms.Label();
            this.buttonZatrWykonaj = new System.Windows.Forms.Button();
            this.panelUrlopy = new System.Windows.Forms.Panel();
            this.buttonUrlopZapisz = new System.Windows.Forms.Button();
            this.buttonPanelPracownicy = new System.Windows.Forms.Button();
            this.buttonPanelZatrudnienie = new System.Windows.Forms.Button();
            this.buttonPanelUrlopy = new System.Windows.Forms.Button();
            this.panelPracownicy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployess)).BeginInit();
            this.panelZatrudnienie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPeroidOfEmp)).BeginInit();
            this.panelUrlopy.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShowEmployee
            // 
            this.buttonShowEmployee.Location = new System.Drawing.Point(0, 0);
            this.buttonShowEmployee.Name = "buttonShowEmployee";
            this.buttonShowEmployee.Size = new System.Drawing.Size(155, 28);
            this.buttonShowEmployee.TabIndex = 1;
            this.buttonShowEmployee.Text = "Pokaż pracowników";
            this.buttonShowEmployee.UseVisualStyleBackColor = true;
            this.buttonShowEmployee.Click += new System.EventHandler(this.buttonShowEmployee_Click);
            // 
            // panelPracownicy
            // 
            this.panelPracownicy.Controls.Add(this.cBgender);
            this.panelPracownicy.Controls.Add(this.buttonRefresh);
            this.panelPracownicy.Controls.Add(this.mTBDataUrodzenia);
            this.panelPracownicy.Controls.Add(this.labelID);
            this.panelPracownicy.Controls.Add(this.tBID);
            this.panelPracownicy.Controls.Add(this.labelDataUrodzenia);
            this.panelPracownicy.Controls.Add(this.labelPESEL);
            this.panelPracownicy.Controls.Add(this.labelPlec);
            this.panelPracownicy.Controls.Add(this.labelNazwisko);
            this.panelPracownicy.Controls.Add(this.labelImie);
            this.panelPracownicy.Controls.Add(this.tBnPESEL);
            this.panelPracownicy.Controls.Add(this.tBNazwisko);
            this.panelPracownicy.Controls.Add(this.tBImie);
            this.panelPracownicy.Controls.Add(this.buttonPracownikWykonaj);
            this.panelPracownicy.Controls.Add(this.buttonPracownikDodaj);
            this.panelPracownicy.Controls.Add(this.buttonPrawconikUsun);
            this.panelPracownicy.Controls.Add(this.buttonPracownikAkt);
            this.panelPracownicy.Controls.Add(this.buttonShowEmployee);
            this.panelPracownicy.Controls.Add(this.dataGridViewEmployess);
            this.panelPracownicy.Location = new System.Drawing.Point(190, 12);
            this.panelPracownicy.Name = "panelPracownicy";
            this.panelPracownicy.Size = new System.Drawing.Size(1002, 548);
            this.panelPracownicy.TabIndex = 2;
            // 
            // cBgender
            // 
            this.cBgender.FormattingEnabled = true;
            this.cBgender.Location = new System.Drawing.Point(105, 311);
            this.cBgender.Name = "cBgender";
            this.cBgender.Size = new System.Drawing.Size(128, 27);
            this.cBgender.TabIndex = 20;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(0, 522);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(86, 26);
            this.buttonRefresh.TabIndex = 19;
            this.buttonRefresh.Text = "Odświerz";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // mTBDataUrodzenia
            // 
            this.mTBDataUrodzenia.Location = new System.Drawing.Point(145, 376);
            this.mTBDataUrodzenia.Mask = "00-00-0000";
            this.mTBDataUrodzenia.Name = "mTBDataUrodzenia";
            this.mTBDataUrodzenia.Size = new System.Drawing.Size(88, 26);
            this.mTBDataUrodzenia.TabIndex = 18;
            this.mTBDataUrodzenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mTBDataUrodzenia.ValidatingType = typeof(System.DateTime);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(0, 219);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 19);
            this.labelID.TabIndex = 17;
            this.labelID.Text = "ID:";
            // 
            // tBID
            // 
            this.tBID.Location = new System.Drawing.Point(105, 216);
            this.tBID.Name = "tBID";
            this.tBID.Size = new System.Drawing.Size(128, 26);
            this.tBID.TabIndex = 16;
            // 
            // labelDataUrodzenia
            // 
            this.labelDataUrodzenia.AutoSize = true;
            this.labelDataUrodzenia.Location = new System.Drawing.Point(0, 379);
            this.labelDataUrodzenia.Name = "labelDataUrodzenia";
            this.labelDataUrodzenia.Size = new System.Drawing.Size(105, 19);
            this.labelDataUrodzenia.TabIndex = 15;
            this.labelDataUrodzenia.Text = "Data urodzenia:";
            // 
            // labelPESEL
            // 
            this.labelPESEL.AutoSize = true;
            this.labelPESEL.Location = new System.Drawing.Point(0, 347);
            this.labelPESEL.Name = "labelPESEL";
            this.labelPESEL.Size = new System.Drawing.Size(94, 19);
            this.labelPESEL.TabIndex = 14;
            this.labelPESEL.Text = "Numer PESEL:";
            // 
            // labelPlec
            // 
            this.labelPlec.AutoSize = true;
            this.labelPlec.Location = new System.Drawing.Point(0, 315);
            this.labelPlec.Name = "labelPlec";
            this.labelPlec.Size = new System.Drawing.Size(37, 19);
            this.labelPlec.TabIndex = 13;
            this.labelPlec.Text = "Płeć:";
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(0, 283);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(69, 19);
            this.labelNazwisko.TabIndex = 12;
            this.labelNazwisko.Text = "Nazwisko:";
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Location = new System.Drawing.Point(0, 251);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(38, 19);
            this.labelImie.TabIndex = 11;
            this.labelImie.Text = "Imie:";
            // 
            // tBnPESEL
            // 
            this.tBnPESEL.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tBnPESEL.Location = new System.Drawing.Point(105, 344);
            this.tBnPESEL.MaxLength = 11;
            this.tBnPESEL.Name = "tBnPESEL";
            this.tBnPESEL.Size = new System.Drawing.Size(128, 26);
            this.tBnPESEL.TabIndex = 9;
            this.tBnPESEL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBnPESEL_KeyPress_1);
            // 
            // tBNazwisko
            // 
            this.tBNazwisko.Location = new System.Drawing.Point(105, 280);
            this.tBNazwisko.Name = "tBNazwisko";
            this.tBNazwisko.Size = new System.Drawing.Size(128, 26);
            this.tBNazwisko.TabIndex = 7;
            // 
            // tBImie
            // 
            this.tBImie.Location = new System.Drawing.Point(105, 248);
            this.tBImie.Name = "tBImie";
            this.tBImie.Size = new System.Drawing.Size(128, 26);
            this.tBImie.TabIndex = 6;
            // 
            // buttonPracownikWykonaj
            // 
            this.buttonPracownikWykonaj.Location = new System.Drawing.Point(0, 161);
            this.buttonPracownikWykonaj.Name = "buttonPracownikWykonaj";
            this.buttonPracownikWykonaj.Size = new System.Drawing.Size(155, 26);
            this.buttonPracownikWykonaj.TabIndex = 5;
            this.buttonPracownikWykonaj.Text = "Wykonaj";
            this.buttonPracownikWykonaj.UseVisualStyleBackColor = true;
            this.buttonPracownikWykonaj.Click += new System.EventHandler(this.buttonPracownikWykonaj_Click);
            // 
            // buttonPracownikDodaj
            // 
            this.buttonPracownikDodaj.Location = new System.Drawing.Point(0, 65);
            this.buttonPracownikDodaj.Name = "buttonPracownikDodaj";
            this.buttonPracownikDodaj.Size = new System.Drawing.Size(155, 26);
            this.buttonPracownikDodaj.TabIndex = 2;
            this.buttonPracownikDodaj.Text = "Dodaj";
            this.buttonPracownikDodaj.UseVisualStyleBackColor = true;
            this.buttonPracownikDodaj.Click += new System.EventHandler(this.buttonPracownikDodaj_Click);
            // 
            // buttonPrawconikUsun
            // 
            this.buttonPrawconikUsun.Location = new System.Drawing.Point(0, 129);
            this.buttonPrawconikUsun.Name = "buttonPrawconikUsun";
            this.buttonPrawconikUsun.Size = new System.Drawing.Size(155, 26);
            this.buttonPrawconikUsun.TabIndex = 4;
            this.buttonPrawconikUsun.Text = "Usuń";
            this.buttonPrawconikUsun.UseVisualStyleBackColor = true;
            this.buttonPrawconikUsun.Click += new System.EventHandler(this.buttonPrawconikUsun_Click);
            // 
            // buttonPracownikAkt
            // 
            this.buttonPracownikAkt.Location = new System.Drawing.Point(0, 97);
            this.buttonPracownikAkt.Name = "buttonPracownikAkt";
            this.buttonPracownikAkt.Size = new System.Drawing.Size(155, 26);
            this.buttonPracownikAkt.TabIndex = 3;
            this.buttonPracownikAkt.Text = "Aktualizuj";
            this.buttonPracownikAkt.UseVisualStyleBackColor = true;
            this.buttonPracownikAkt.Click += new System.EventHandler(this.buttonPracownikAkt_Click);
            // 
            // dataGridViewEmployess
            // 
            this.dataGridViewEmployess.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridViewEmployess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDpracownika,
            this.FullName,
            this.imie,
            this.nazwisko,
            this.plec,
            this.numer_pesel,
            this.data_urodzenia});
            this.dataGridViewEmployess.Location = new System.Drawing.Point(313, 0);
            this.dataGridViewEmployess.MinimumSize = new System.Drawing.Size(15, 0);
            this.dataGridViewEmployess.Name = "dataGridViewEmployess";
            this.dataGridViewEmployess.RowHeadersWidth = 47;
            this.dataGridViewEmployess.RowTemplate.Height = 28;
            this.dataGridViewEmployess.Size = new System.Drawing.Size(689, 548);
            this.dataGridViewEmployess.TabIndex = 0;
            this.dataGridViewEmployess.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployess_CellContentClick);
            // 
            // IDpracownika
            // 
            this.IDpracownika.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IDpracownika.DataPropertyName = "IDpracownika";
            this.IDpracownika.HeaderText = "ID";
            this.IDpracownika.MinimumWidth = 6;
            this.IDpracownika.Name = "IDpracownika";
            this.IDpracownika.ReadOnly = true;
            this.IDpracownika.Width = 40;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "FullName";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Visible = false;
            // 
            // imie
            // 
            this.imie.DataPropertyName = "imie";
            this.imie.FillWeight = 94.86911F;
            this.imie.HeaderText = "Imię";
            this.imie.MinimumWidth = 6;
            this.imie.Name = "imie";
            this.imie.ReadOnly = true;
            // 
            // nazwisko
            // 
            this.nazwisko.DataPropertyName = "nazwisko";
            this.nazwisko.FillWeight = 94.86911F;
            this.nazwisko.HeaderText = "Nazwisko";
            this.nazwisko.MinimumWidth = 6;
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.ReadOnly = true;
            // 
            // plec
            // 
            this.plec.DataPropertyName = "plec";
            this.plec.FillWeight = 94.86911F;
            this.plec.HeaderText = "Płeć";
            this.plec.MinimumWidth = 6;
            this.plec.Name = "plec";
            this.plec.ReadOnly = true;
            // 
            // numer_pesel
            // 
            this.numer_pesel.DataPropertyName = "numer_pesel";
            this.numer_pesel.FillWeight = 94.86911F;
            this.numer_pesel.HeaderText = "PESEL";
            this.numer_pesel.MinimumWidth = 6;
            this.numer_pesel.Name = "numer_pesel";
            this.numer_pesel.ReadOnly = true;
            // 
            // data_urodzenia
            // 
            this.data_urodzenia.DataPropertyName = "data_urodzenia";
            this.data_urodzenia.FillWeight = 94.86911F;
            this.data_urodzenia.HeaderText = "Data urodzenia";
            this.data_urodzenia.MinimumWidth = 6;
            this.data_urodzenia.Name = "data_urodzenia";
            this.data_urodzenia.ReadOnly = true;
            // 
            // panelZatrudnienie
            // 
            this.panelZatrudnienie.Controls.Add(this.label1);
            this.panelZatrudnienie.Controls.Add(this.dataGridPeroidOfEmp);
            this.panelZatrudnienie.Controls.Add(this.cBoxStanowisko);
            this.panelZatrudnienie.Controls.Add(this.cBoxWCP);
            this.panelZatrudnienie.Controls.Add(this.tBnaleznyUrlop);
            this.panelZatrudnienie.Controls.Add(this.dTPzatrudnionyDo);
            this.panelZatrudnienie.Controls.Add(this.dTPzatrudnionyOd);
            this.panelZatrudnienie.Controls.Add(this.cBoxStazPracy);
            this.panelZatrudnienie.Controls.Add(this.labelStanowisko);
            this.panelZatrudnienie.Controls.Add(this.labelWCP);
            this.panelZatrudnienie.Controls.Add(this.labelNaleznyUrlop);
            this.panelZatrudnienie.Controls.Add(this.labelZatrudnionyDo);
            this.panelZatrudnienie.Controls.Add(this.labelZatrudnionyOd);
            this.panelZatrudnienie.Controls.Add(this.labelStazPracy);
            this.panelZatrudnienie.Controls.Add(this.cBoxEmployee);
            this.panelZatrudnienie.Controls.Add(this.tBoxSelectedEmployee);
            this.panelZatrudnienie.Controls.Add(this.buttonDeletePeroid);
            this.panelZatrudnienie.Controls.Add(this.buttonUpdatePeroid);
            this.panelZatrudnienie.Controls.Add(this.buttonAddPeroid);
            this.panelZatrudnienie.Controls.Add(this.buttonExecutePeroid);
            this.panelZatrudnienie.Controls.Add(this.labelSelEmpID);
            this.panelZatrudnienie.Controls.Add(this.buttonZatrWykonaj);
            this.panelZatrudnienie.Location = new System.Drawing.Point(41, 253);
            this.panelZatrudnienie.Name = "panelZatrudnienie";
            this.panelZatrudnienie.Size = new System.Drawing.Size(1366, 609);
            this.panelZatrudnienie.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "label1";
            // 
            // dataGridPeroidOfEmp
            // 
            this.dataGridPeroidOfEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPeroidOfEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDzatrudnienia,
            this.ZatrudnionyOD,
            this.ZatrudnionyDO,
            this.naleznyUrlop,
            this.stazPracy,
            this.etat,
            this.Stanowisko,
            this.opisST,
            this.idpracownikahidden,
            this.etathidden,
            this.IDStanowisko,
            this.IDwymiar});
            this.dataGridPeroidOfEmp.Location = new System.Drawing.Point(412, 74);
            this.dataGridPeroidOfEmp.Name = "dataGridPeroidOfEmp";
            this.dataGridPeroidOfEmp.RowHeadersWidth = 47;
            this.dataGridPeroidOfEmp.RowTemplate.Height = 28;
            this.dataGridPeroidOfEmp.Size = new System.Drawing.Size(925, 390);
            this.dataGridPeroidOfEmp.TabIndex = 25;
            this.dataGridPeroidOfEmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPeroidOfEmp_CellContentClick_1);
            // 
            // IDzatrudnienia
            // 
            this.IDzatrudnienia.DataPropertyName = "IDzatrudnienia";
            this.IDzatrudnienia.HeaderText = "ID (z)";
            this.IDzatrudnienia.MinimumWidth = 6;
            this.IDzatrudnienia.Name = "IDzatrudnienia";
            this.IDzatrudnienia.ReadOnly = true;
            this.IDzatrudnienia.Width = 50;
            // 
            // ZatrudnionyOD
            // 
            this.ZatrudnionyOD.DataPropertyName = "zatrudniony_od";
            this.ZatrudnionyOD.HeaderText = "Zatrudniony od";
            this.ZatrudnionyOD.MinimumWidth = 6;
            this.ZatrudnionyOD.Name = "ZatrudnionyOD";
            this.ZatrudnionyOD.ReadOnly = true;
            this.ZatrudnionyOD.Width = 140;
            // 
            // ZatrudnionyDO
            // 
            this.ZatrudnionyDO.DataPropertyName = "zatrudniony_do";
            this.ZatrudnionyDO.HeaderText = "Zatrudniony do";
            this.ZatrudnionyDO.MinimumWidth = 6;
            this.ZatrudnionyDO.Name = "ZatrudnionyDO";
            this.ZatrudnionyDO.ReadOnly = true;
            this.ZatrudnionyDO.Width = 140;
            // 
            // naleznyUrlop
            // 
            this.naleznyUrlop.DataPropertyName = "nalezny_urlop";
            this.naleznyUrlop.HeaderText = "Należny urlop";
            this.naleznyUrlop.MinimumWidth = 6;
            this.naleznyUrlop.Name = "naleznyUrlop";
            this.naleznyUrlop.ReadOnly = true;
            this.naleznyUrlop.Width = 130;
            // 
            // stazPracy
            // 
            this.stazPracy.DataPropertyName = "staz_pracy";
            this.stazPracy.HeaderText = "Staż Pracy";
            this.stazPracy.MinimumWidth = 6;
            this.stazPracy.Name = "stazPracy";
            this.stazPracy.ReadOnly = true;
            this.stazPracy.Width = 115;
            // 
            // etat
            // 
            this.etat.DataPropertyName = "nazwaWCP";
            this.etat.HeaderText = "Etat";
            this.etat.MinimumWidth = 6;
            this.etat.Name = "etat";
            this.etat.ReadOnly = true;
            this.etat.Width = 140;
            // 
            // Stanowisko
            // 
            this.Stanowisko.DataPropertyName = "nazwaST";
            this.Stanowisko.HeaderText = "Stanowisko";
            this.Stanowisko.MinimumWidth = 6;
            this.Stanowisko.Name = "Stanowisko";
            this.Stanowisko.ReadOnly = true;
            this.Stanowisko.Width = 115;
            // 
            // opisST
            // 
            this.opisST.DataPropertyName = "opisST";
            this.opisST.HeaderText = "opisST";
            this.opisST.MinimumWidth = 6;
            this.opisST.Name = "opisST";
            this.opisST.ReadOnly = true;
            this.opisST.Visible = false;
            this.opisST.Width = 115;
            // 
            // idpracownikahidden
            // 
            this.idpracownikahidden.DataPropertyName = "IDpracownika";
            this.idpracownikahidden.HeaderText = "IDpracownika";
            this.idpracownikahidden.MinimumWidth = 6;
            this.idpracownikahidden.Name = "idpracownikahidden";
            this.idpracownikahidden.ReadOnly = true;
            this.idpracownikahidden.Visible = false;
            this.idpracownikahidden.Width = 115;
            // 
            // etathidden
            // 
            this.etathidden.DataPropertyName = "etat";
            this.etathidden.HeaderText = "etat";
            this.etathidden.MinimumWidth = 6;
            this.etathidden.Name = "etathidden";
            this.etathidden.ReadOnly = true;
            this.etathidden.Visible = false;
            this.etathidden.Width = 115;
            // 
            // IDStanowisko
            // 
            this.IDStanowisko.DataPropertyName = "IDstanowiska";
            this.IDStanowisko.HeaderText = "ID (s)";
            this.IDStanowisko.MinimumWidth = 6;
            this.IDStanowisko.Name = "IDStanowisko";
            this.IDStanowisko.ReadOnly = true;
            this.IDStanowisko.Visible = false;
            this.IDStanowisko.Width = 50;
            // 
            // IDwymiar
            // 
            this.IDwymiar.DataPropertyName = "IDwymiar";
            this.IDwymiar.HeaderText = "ID (wcp)";
            this.IDwymiar.MinimumWidth = 6;
            this.IDwymiar.Name = "IDwymiar";
            this.IDwymiar.ReadOnly = true;
            this.IDwymiar.Visible = false;
            this.IDwymiar.Width = 50;
            // 
            // cBoxStanowisko
            // 
            this.cBoxStanowisko.FormattingEnabled = true;
            this.cBoxStanowisko.Location = new System.Drawing.Point(150, 453);
            this.cBoxStanowisko.Name = "cBoxStanowisko";
            this.cBoxStanowisko.Size = new System.Drawing.Size(256, 27);
            this.cBoxStanowisko.TabIndex = 24;
            // 
            // cBoxWCP
            // 
            this.cBoxWCP.FormattingEnabled = true;
            this.cBoxWCP.Location = new System.Drawing.Point(150, 419);
            this.cBoxWCP.Name = "cBoxWCP";
            this.cBoxWCP.Size = new System.Drawing.Size(256, 27);
            this.cBoxWCP.TabIndex = 23;
            // 
            // tBnaleznyUrlop
            // 
            this.tBnaleznyUrlop.Location = new System.Drawing.Point(150, 386);
            this.tBnaleznyUrlop.Name = "tBnaleznyUrlop";
            this.tBnaleznyUrlop.Size = new System.Drawing.Size(256, 26);
            this.tBnaleznyUrlop.TabIndex = 22;
            // 
            // dTPzatrudnionyDo
            // 
            this.dTPzatrudnionyDo.Location = new System.Drawing.Point(150, 353);
            this.dTPzatrudnionyDo.Name = "dTPzatrudnionyDo";
            this.dTPzatrudnionyDo.Size = new System.Drawing.Size(256, 26);
            this.dTPzatrudnionyDo.TabIndex = 21;
            // 
            // dTPzatrudnionyOd
            // 
            this.dTPzatrudnionyOd.Location = new System.Drawing.Point(150, 320);
            this.dTPzatrudnionyOd.Name = "dTPzatrudnionyOd";
            this.dTPzatrudnionyOd.Size = new System.Drawing.Size(256, 26);
            this.dTPzatrudnionyOd.TabIndex = 0;
            // 
            // cBoxStazPracy
            // 
            this.cBoxStazPracy.FormattingEnabled = true;
            this.cBoxStazPracy.Location = new System.Drawing.Point(150, 287);
            this.cBoxStazPracy.Name = "cBoxStazPracy";
            this.cBoxStazPracy.Size = new System.Drawing.Size(256, 27);
            this.cBoxStazPracy.TabIndex = 20;
            // 
            // labelStanowisko
            // 
            this.labelStanowisko.AutoSize = true;
            this.labelStanowisko.Location = new System.Drawing.Point(0, 456);
            this.labelStanowisko.Name = "labelStanowisko";
            this.labelStanowisko.Size = new System.Drawing.Size(81, 19);
            this.labelStanowisko.TabIndex = 18;
            this.labelStanowisko.Text = "Stanowisko:";
            // 
            // labelWCP
            // 
            this.labelWCP.AutoSize = true;
            this.labelWCP.Location = new System.Drawing.Point(0, 422);
            this.labelWCP.Name = "labelWCP";
            this.labelWCP.Size = new System.Drawing.Size(133, 19);
            this.labelWCP.TabIndex = 17;
            this.labelWCP.Text = "Wymiar czasu pracy:";
            // 
            // labelNaleznyUrlop
            // 
            this.labelNaleznyUrlop.AutoSize = true;
            this.labelNaleznyUrlop.Location = new System.Drawing.Point(0, 389);
            this.labelNaleznyUrlop.Name = "labelNaleznyUrlop";
            this.labelNaleznyUrlop.Size = new System.Drawing.Size(96, 19);
            this.labelNaleznyUrlop.TabIndex = 16;
            this.labelNaleznyUrlop.Text = "Należny urlop:";
            // 
            // labelZatrudnionyDo
            // 
            this.labelZatrudnionyDo.AutoSize = true;
            this.labelZatrudnionyDo.Location = new System.Drawing.Point(-2, 359);
            this.labelZatrudnionyDo.Name = "labelZatrudnionyDo";
            this.labelZatrudnionyDo.Size = new System.Drawing.Size(107, 19);
            this.labelZatrudnionyDo.TabIndex = 15;
            this.labelZatrudnionyDo.Text = "Zatrudniony do:";
            // 
            // labelZatrudnionyOd
            // 
            this.labelZatrudnionyOd.AutoSize = true;
            this.labelZatrudnionyOd.Location = new System.Drawing.Point(0, 326);
            this.labelZatrudnionyOd.Name = "labelZatrudnionyOd";
            this.labelZatrudnionyOd.Size = new System.Drawing.Size(107, 19);
            this.labelZatrudnionyOd.TabIndex = 14;
            this.labelZatrudnionyOd.Text = "Zatrudniony od:";
            // 
            // labelStazPracy
            // 
            this.labelStazPracy.AutoSize = true;
            this.labelStazPracy.Location = new System.Drawing.Point(0, 290);
            this.labelStazPracy.Name = "labelStazPracy";
            this.labelStazPracy.Size = new System.Drawing.Size(74, 19);
            this.labelStazPracy.TabIndex = 13;
            this.labelStazPracy.Text = "Staż pracy:";
            // 
            // cBoxEmployee
            // 
            this.cBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxEmployee.FormattingEnabled = true;
            this.cBoxEmployee.Location = new System.Drawing.Point(453, 37);
            this.cBoxEmployee.Name = "cBoxEmployee";
            this.cBoxEmployee.Size = new System.Drawing.Size(494, 27);
            this.cBoxEmployee.TabIndex = 10;
            this.cBoxEmployee.SelectedIndexChanged += new System.EventHandler(this.cBoxEmployee_SelectedIndexChanged);
            // 
            // tBoxSelectedEmployee
            // 
            this.tBoxSelectedEmployee.Enabled = false;
            this.tBoxSelectedEmployee.Location = new System.Drawing.Point(379, 38);
            this.tBoxSelectedEmployee.Name = "tBoxSelectedEmployee";
            this.tBoxSelectedEmployee.Size = new System.Drawing.Size(68, 26);
            this.tBoxSelectedEmployee.TabIndex = 9;
            // 
            // buttonDeletePeroid
            // 
            this.buttonDeletePeroid.Location = new System.Drawing.Point(0, 145);
            this.buttonDeletePeroid.Name = "buttonDeletePeroid";
            this.buttonDeletePeroid.Size = new System.Drawing.Size(86, 26);
            this.buttonDeletePeroid.TabIndex = 7;
            this.buttonDeletePeroid.Text = "Usuń";
            this.buttonDeletePeroid.UseVisualStyleBackColor = true;
            // 
            // buttonUpdatePeroid
            // 
            this.buttonUpdatePeroid.Location = new System.Drawing.Point(0, 113);
            this.buttonUpdatePeroid.Name = "buttonUpdatePeroid";
            this.buttonUpdatePeroid.Size = new System.Drawing.Size(86, 26);
            this.buttonUpdatePeroid.TabIndex = 6;
            this.buttonUpdatePeroid.Text = "Aktualizuj";
            this.buttonUpdatePeroid.UseVisualStyleBackColor = true;
            // 
            // buttonAddPeroid
            // 
            this.buttonAddPeroid.Location = new System.Drawing.Point(0, 80);
            this.buttonAddPeroid.Name = "buttonAddPeroid";
            this.buttonAddPeroid.Size = new System.Drawing.Size(86, 26);
            this.buttonAddPeroid.TabIndex = 5;
            this.buttonAddPeroid.Text = "Dodaj";
            this.buttonAddPeroid.UseVisualStyleBackColor = true;
            // 
            // buttonExecutePeroid
            // 
            this.buttonExecutePeroid.Location = new System.Drawing.Point(0, 177);
            this.buttonExecutePeroid.Name = "buttonExecutePeroid";
            this.buttonExecutePeroid.Size = new System.Drawing.Size(86, 26);
            this.buttonExecutePeroid.TabIndex = 4;
            this.buttonExecutePeroid.Text = "Wykonaj";
            this.buttonExecutePeroid.UseVisualStyleBackColor = true;
            // 
            // labelSelEmpID
            // 
            this.labelSelEmpID.AutoSize = true;
            this.labelSelEmpID.Location = new System.Drawing.Point(345, 41);
            this.labelSelEmpID.Name = "labelSelEmpID";
            this.labelSelEmpID.Size = new System.Drawing.Size(23, 19);
            this.labelSelEmpID.TabIndex = 2;
            this.labelSelEmpID.Text = "ID";
            // 
            // buttonZatrWykonaj
            // 
            this.buttonZatrWykonaj.Location = new System.Drawing.Point(0, 14);
            this.buttonZatrWykonaj.Name = "buttonZatrWykonaj";
            this.buttonZatrWykonaj.Size = new System.Drawing.Size(86, 26);
            this.buttonZatrWykonaj.TabIndex = 0;
            this.buttonZatrWykonaj.Text = "Wykonaj";
            this.buttonZatrWykonaj.UseVisualStyleBackColor = true;
            // 
            // panelUrlopy
            // 
            this.panelUrlopy.Controls.Add(this.buttonUrlopZapisz);
            this.panelUrlopy.Location = new System.Drawing.Point(1429, 34);
            this.panelUrlopy.Name = "panelUrlopy";
            this.panelUrlopy.Size = new System.Drawing.Size(184, 344);
            this.panelUrlopy.TabIndex = 1;
            // 
            // buttonUrlopZapisz
            // 
            this.buttonUrlopZapisz.Location = new System.Drawing.Point(49, 249);
            this.buttonUrlopZapisz.Name = "buttonUrlopZapisz";
            this.buttonUrlopZapisz.Size = new System.Drawing.Size(86, 26);
            this.buttonUrlopZapisz.TabIndex = 0;
            this.buttonUrlopZapisz.Text = "Zapisz";
            this.buttonUrlopZapisz.UseVisualStyleBackColor = true;
            // 
            // buttonPanelPracownicy
            // 
            this.buttonPanelPracownicy.Location = new System.Drawing.Point(12, 12);
            this.buttonPanelPracownicy.Name = "buttonPanelPracownicy";
            this.buttonPanelPracownicy.Size = new System.Drawing.Size(147, 26);
            this.buttonPanelPracownicy.TabIndex = 4;
            this.buttonPanelPracownicy.Text = "Pracownicy";
            this.buttonPanelPracownicy.UseVisualStyleBackColor = true;
            this.buttonPanelPracownicy.Click += new System.EventHandler(this.buttonPanelPracownicy_Click);
            // 
            // buttonPanelZatrudnienie
            // 
            this.buttonPanelZatrudnienie.Location = new System.Drawing.Point(12, 44);
            this.buttonPanelZatrudnienie.Name = "buttonPanelZatrudnienie";
            this.buttonPanelZatrudnienie.Size = new System.Drawing.Size(147, 26);
            this.buttonPanelZatrudnienie.TabIndex = 5;
            this.buttonPanelZatrudnienie.Text = "Okres zatrudnienia";
            this.buttonPanelZatrudnienie.UseVisualStyleBackColor = true;
            this.buttonPanelZatrudnienie.Click += new System.EventHandler(this.buttonPanelZatrudnienie_Click);
            // 
            // buttonPanelUrlopy
            // 
            this.buttonPanelUrlopy.Location = new System.Drawing.Point(13, 77);
            this.buttonPanelUrlopy.Name = "buttonPanelUrlopy";
            this.buttonPanelUrlopy.Size = new System.Drawing.Size(146, 26);
            this.buttonPanelUrlopy.TabIndex = 6;
            this.buttonPanelUrlopy.Text = "Urlopy";
            this.buttonPanelUrlopy.UseVisualStyleBackColor = true;
            this.buttonPanelUrlopy.Click += new System.EventHandler(this.buttonPanelUrlopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1681, 899);
            this.Controls.Add(this.panelUrlopy);
            this.Controls.Add(this.buttonPanelUrlopy);
            this.Controls.Add(this.buttonPanelZatrudnienie);
            this.Controls.Add(this.buttonPanelPracownicy);
            this.Controls.Add(this.panelZatrudnienie);
            this.Controls.Add(this.panelPracownicy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelPracownicy.ResumeLayout(false);
            this.panelPracownicy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployess)).EndInit();
            this.panelZatrudnienie.ResumeLayout(false);
            this.panelZatrudnienie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPeroidOfEmp)).EndInit();
            this.panelUrlopy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonShowEmployee;
        private System.Windows.Forms.Panel panelPracownicy;
        private System.Windows.Forms.Panel panelZatrudnienie;
        private System.Windows.Forms.Button buttonPanelPracownicy;
        private System.Windows.Forms.Button buttonPanelZatrudnienie;
        private System.Windows.Forms.Button buttonZatrWykonaj;
        private System.Windows.Forms.Button buttonPanelUrlopy;
        private System.Windows.Forms.Panel panelUrlopy;
        private System.Windows.Forms.Button buttonUrlopZapisz;
        private System.Windows.Forms.Button buttonPracownikDodaj;
        private System.Windows.Forms.Button buttonPracownikAkt;
        private System.Windows.Forms.Button buttonPrawconikUsun;
        private System.Windows.Forms.Button buttonPracownikWykonaj;
        private System.Windows.Forms.Label labelDataUrodzenia;
        private System.Windows.Forms.Label labelPESEL;
        private System.Windows.Forms.Label labelPlec;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.TextBox tBnPESEL;
        private System.Windows.Forms.TextBox tBNazwisko;
        private System.Windows.Forms.TextBox tBImie;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox tBID;
        private System.Windows.Forms.MaskedTextBox mTBDataUrodzenia;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ComboBox cBgender;
        private System.Windows.Forms.DataGridView dataGridViewEmployess;
        private System.Windows.Forms.Label labelSelEmpID;
        private System.Windows.Forms.Button buttonDeletePeroid;
        private System.Windows.Forms.Button buttonUpdatePeroid;
        private System.Windows.Forms.Button buttonAddPeroid;
        private System.Windows.Forms.TextBox tBoxSelectedEmployee;
        private System.Windows.Forms.ComboBox cBoxEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDpracownika;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn plec;
        private System.Windows.Forms.DataGridViewTextBoxColumn numer_pesel;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_urodzenia;
        private System.Windows.Forms.ComboBox cBoxStazPracy;
        private System.Windows.Forms.Label labelStanowisko;
        private System.Windows.Forms.Label labelWCP;
        private System.Windows.Forms.Label labelNaleznyUrlop;
        private System.Windows.Forms.Label labelZatrudnionyDo;
        private System.Windows.Forms.Label labelZatrudnionyOd;
        private System.Windows.Forms.Label labelStazPracy;
        private System.Windows.Forms.ComboBox cBoxStanowisko;
        private System.Windows.Forms.ComboBox cBoxWCP;
        private System.Windows.Forms.TextBox tBnaleznyUrlop;
        private System.Windows.Forms.DateTimePicker dTPzatrudnionyDo;
        private System.Windows.Forms.DateTimePicker dTPzatrudnionyOd;
        private System.Windows.Forms.Button buttonExecutePeroid;
        private System.Windows.Forms.DataGridView dataGridPeroidOfEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDzatrudnienia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZatrudnionyOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZatrudnionyDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn naleznyUrlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn stazPracy;
        private System.Windows.Forms.DataGridViewTextBoxColumn etat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stanowisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisST;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpracownikahidden;
        private System.Windows.Forms.DataGridViewTextBoxColumn etathidden;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDStanowisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDwymiar;
    }
}

