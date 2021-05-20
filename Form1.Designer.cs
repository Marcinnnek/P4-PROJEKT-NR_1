
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
            this.panelZatrudnienie = new System.Windows.Forms.Panel();
            this.buttonZatrudnienieZapisz = new System.Windows.Forms.Button();
            this.panelUrlopy = new System.Windows.Forms.Panel();
            this.buttonUrlopZapisz = new System.Windows.Forms.Button();
            this.buttonPanelPracownicy = new System.Windows.Forms.Button();
            this.buttonPanelZatrudnienie = new System.Windows.Forms.Button();
            this.buttonPanelUrlopy = new System.Windows.Forms.Button();
            this.dataGridViewEmployess = new System.Windows.Forms.DataGridView();
            this.panelPracownicy.SuspendLayout();
            this.panelZatrudnienie.SuspendLayout();
            this.panelUrlopy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployess)).BeginInit();
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
            // panelZatrudnienie
            // 
            this.panelZatrudnienie.Controls.Add(this.buttonZatrudnienieZapisz);
            this.panelZatrudnienie.Location = new System.Drawing.Point(397, 633);
            this.panelZatrudnienie.Name = "panelZatrudnienie";
            this.panelZatrudnienie.Size = new System.Drawing.Size(145, 161);
            this.panelZatrudnienie.TabIndex = 3;
            // 
            // buttonZatrudnienieZapisz
            // 
            this.buttonZatrudnienieZapisz.Location = new System.Drawing.Point(0, 2);
            this.buttonZatrudnienieZapisz.Name = "buttonZatrudnienieZapisz";
            this.buttonZatrudnienieZapisz.Size = new System.Drawing.Size(86, 26);
            this.buttonZatrudnienieZapisz.TabIndex = 0;
            this.buttonZatrudnienieZapisz.Text = "Zapisz";
            this.buttonZatrudnienieZapisz.UseVisualStyleBackColor = true;
            // 
            // panelUrlopy
            // 
            this.panelUrlopy.Controls.Add(this.buttonUrlopZapisz);
            this.panelUrlopy.Location = new System.Drawing.Point(75, 613);
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
            // dataGridViewEmployess
            // 
            this.dataGridViewEmployess.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridViewEmployess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployess.Location = new System.Drawing.Point(313, 0);
            this.dataGridViewEmployess.MinimumSize = new System.Drawing.Size(15, 0);
            this.dataGridViewEmployess.Name = "dataGridViewEmployess";
            this.dataGridViewEmployess.RowHeadersWidth = 47;
            this.dataGridViewEmployess.RowTemplate.Height = 28;
            this.dataGridViewEmployess.Size = new System.Drawing.Size(689, 548);
            this.dataGridViewEmployess.TabIndex = 0;
            this.dataGridViewEmployess.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployess_CellContentClick);
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
            this.panelZatrudnienie.ResumeLayout(false);
            this.panelUrlopy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonShowEmployee;
        private System.Windows.Forms.Panel panelPracownicy;
        private System.Windows.Forms.Panel panelZatrudnienie;
        private System.Windows.Forms.Button buttonPanelPracownicy;
        private System.Windows.Forms.Button buttonPanelZatrudnienie;
        private System.Windows.Forms.Button buttonZatrudnienieZapisz;
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
    }
}

