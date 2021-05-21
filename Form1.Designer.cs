
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
            this.panelZatrudnienie = new System.Windows.Forms.Panel();
            this.cBoxEmployee = new System.Windows.Forms.ComboBox();
            this.tBoxSelectedEmployee = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelSelEmpID = new System.Windows.Forms.Label();
            this.buttonZatrWykonaj = new System.Windows.Forms.Button();
            this.panelUrlopy = new System.Windows.Forms.Panel();
            this.buttonUrlopZapisz = new System.Windows.Forms.Button();
            this.buttonPanelPracownicy = new System.Windows.Forms.Button();
            this.buttonPanelZatrudnienie = new System.Windows.Forms.Button();
            this.buttonPanelUrlopy = new System.Windows.Forms.Button();
            this.IDpracownika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numer_pesel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_urodzenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelPracownicy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployess)).BeginInit();
            this.panelZatrudnienie.SuspendLayout();
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
            // panelZatrudnienie
            // 
            this.panelZatrudnienie.Controls.Add(this.cBoxEmployee);
            this.panelZatrudnienie.Controls.Add(this.tBoxSelectedEmployee);
            this.panelZatrudnienie.Controls.Add(this.button4);
            this.panelZatrudnienie.Controls.Add(this.button3);
            this.panelZatrudnienie.Controls.Add(this.button2);
            this.panelZatrudnienie.Controls.Add(this.button1);
            this.panelZatrudnienie.Controls.Add(this.labelSelEmpID);
            this.panelZatrudnienie.Controls.Add(this.buttonZatrWykonaj);
            this.panelZatrudnienie.Location = new System.Drawing.Point(87, 611);
            this.panelZatrudnienie.Name = "panelZatrudnienie";
            this.panelZatrudnienie.Size = new System.Drawing.Size(1170, 595);
            this.panelZatrudnienie.TabIndex = 3;
            // 
            // cBoxEmployee
            // 
            this.cBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxEmployee.FormattingEnabled = true;
            this.cBoxEmployee.Location = new System.Drawing.Point(196, 36);
            this.cBoxEmployee.Name = "cBoxEmployee";
            this.cBoxEmployee.Size = new System.Drawing.Size(773, 27);
            this.cBoxEmployee.TabIndex = 10;
            this.cBoxEmployee.SelectedIndexChanged += new System.EventHandler(this.cBoxEmployee_SelectedIndexChanged);
            // 
            // tBoxSelectedEmployee
            // 
            this.tBoxSelectedEmployee.Enabled = false;
            this.tBoxSelectedEmployee.Location = new System.Drawing.Point(132, 81);
            this.tBoxSelectedEmployee.Name = "tBoxSelectedEmployee";
            this.tBoxSelectedEmployee.Size = new System.Drawing.Size(115, 26);
            this.tBoxSelectedEmployee.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 26);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 26);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 26);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelSelEmpID
            // 
            this.labelSelEmpID.AutoSize = true;
            this.labelSelEmpID.Location = new System.Drawing.Point(132, 17);
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tBoxSelectedEmployee;
        private System.Windows.Forms.ComboBox cBoxEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDpracownika;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn plec;
        private System.Windows.Forms.DataGridViewTextBoxColumn numer_pesel;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_urodzenia;
    }
}

