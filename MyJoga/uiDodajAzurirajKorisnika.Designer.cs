namespace MyJoga
{
    partial class uiDodajAzurirajKorisnika
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tip_korisnikaLabel1;
            System.Windows.Forms.Label iD_korisnikLabel;
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label prezimeLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label lozinkaLabel;
            System.Windows.Forms.Label placena_clanarinaLabel;
            System.Windows.Forms.Label korisnicko_imeLabel;
            this.btnDodajAzurirajKorisnika = new System.Windows.Forms.Button();
            this.cmbUnosTipKorisnika = new System.Windows.Forms.ComboBox();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._19001_DBDataSet = new MyJoga._19001_DBDataSet();
            this.ulogeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikTableAdapter = new MyJoga._19001_DBDataSetTableAdapters.KorisnikTableAdapter();
            this.tableAdapterManager = new MyJoga._19001_DBDataSetTableAdapters.TableAdapterManager();
            this.ulogeTableAdapter = new MyJoga._19001_DBDataSetTableAdapters.UlogeTableAdapter();
            this.uiKorisnicki_id = new System.Windows.Forms.TextBox();
            this.uiIme = new System.Windows.Forms.TextBox();
            this.uiPrezime = new System.Windows.Forms.TextBox();
            this.uiEmail = new System.Windows.Forms.TextBox();
            this.uiLozinka = new System.Windows.Forms.TextBox();
            this.uiPlacena_clanarina = new System.Windows.Forms.CheckBox();
            this.uiKorisnicko_ime = new System.Windows.Forms.TextBox();
            tip_korisnikaLabel1 = new System.Windows.Forms.Label();
            iD_korisnikLabel = new System.Windows.Forms.Label();
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            lozinkaLabel = new System.Windows.Forms.Label();
            placena_clanarinaLabel = new System.Windows.Forms.Label();
            korisnicko_imeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._19001_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tip_korisnikaLabel1
            // 
            tip_korisnikaLabel1.AutoSize = true;
            tip_korisnikaLabel1.Location = new System.Drawing.Point(20, 174);
            tip_korisnikaLabel1.Name = "tip_korisnikaLabel1";
            tip_korisnikaLabel1.Size = new System.Drawing.Size(92, 17);
            tip_korisnikaLabel1.TabIndex = 18;
            tip_korisnikaLabel1.Text = "Tip korisnika:";
            // 
            // iD_korisnikLabel
            // 
            iD_korisnikLabel.AutoSize = true;
            iD_korisnikLabel.Location = new System.Drawing.Point(35, 34);
            iD_korisnikLabel.Name = "iD_korisnikLabel";
            iD_korisnikLabel.Size = new System.Drawing.Size(77, 17);
            iD_korisnikLabel.TabIndex = 19;
            iD_korisnikLabel.Text = "ID korisnik:";
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(78, 62);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(34, 17);
            imeLabel.TabIndex = 20;
            imeLabel.Text = "Ime:";
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Location = new System.Drawing.Point(49, 90);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(63, 17);
            prezimeLabel.TabIndex = 21;
            prezimeLabel.Text = "Prezime:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(66, 118);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 22;
            emailLabel.Text = "Email:";
            // 
            // lozinkaLabel
            // 
            lozinkaLabel.AutoSize = true;
            lozinkaLabel.Location = new System.Drawing.Point(51, 146);
            lozinkaLabel.Name = "lozinkaLabel";
            lozinkaLabel.Size = new System.Drawing.Size(61, 17);
            lozinkaLabel.TabIndex = 23;
            lozinkaLabel.Text = "Lozinka:";
            // 
            // placena_clanarinaLabel
            // 
            placena_clanarinaLabel.AutoSize = true;
            placena_clanarinaLabel.Location = new System.Drawing.Point(-13, 206);
            placena_clanarinaLabel.Name = "placena_clanarinaLabel";
            placena_clanarinaLabel.Size = new System.Drawing.Size(125, 17);
            placena_clanarinaLabel.TabIndex = 24;
            placena_clanarinaLabel.Text = "Placena clanarina:";
            // 
            // korisnicko_imeLabel
            // 
            korisnicko_imeLabel.AutoSize = true;
            korisnicko_imeLabel.Location = new System.Drawing.Point(13, 234);
            korisnicko_imeLabel.Name = "korisnicko_imeLabel";
            korisnicko_imeLabel.Size = new System.Drawing.Size(103, 17);
            korisnicko_imeLabel.TabIndex = 25;
            korisnicko_imeLabel.Text = "Korisnicko ime:";
            // 
            // btnDodajAzurirajKorisnika
            // 
            this.btnDodajAzurirajKorisnika.Location = new System.Drawing.Point(417, 387);
            this.btnDodajAzurirajKorisnika.Name = "btnDodajAzurirajKorisnika";
            this.btnDodajAzurirajKorisnika.Size = new System.Drawing.Size(75, 23);
            this.btnDodajAzurirajKorisnika.TabIndex = 17;
            this.btnDodajAzurirajKorisnika.Text = "Dodaj";
            this.btnDodajAzurirajKorisnika.UseVisualStyleBackColor = true;
            this.btnDodajAzurirajKorisnika.Click += new System.EventHandler(this.btnDodajAzurirajKorisnika_Click);
            // 
            // cmbUnosTipKorisnika
            // 
            this.cmbUnosTipKorisnika.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.korisnikBindingSource, "Tip_korisnika", true));
            this.cmbUnosTipKorisnika.DataSource = this.ulogeBindingSource;
            this.cmbUnosTipKorisnika.DisplayMember = "Uloga";
            this.cmbUnosTipKorisnika.FormattingEnabled = true;
            this.cmbUnosTipKorisnika.Location = new System.Drawing.Point(118, 171);
            this.cmbUnosTipKorisnika.Name = "cmbUnosTipKorisnika";
            this.cmbUnosTipKorisnika.Size = new System.Drawing.Size(100, 24);
            this.cmbUnosTipKorisnika.TabIndex = 19;
            this.cmbUnosTipKorisnika.ValueMember = "ID_uloga";
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataMember = "Korisnik";
            this.korisnikBindingSource.DataSource = this._19001_DBDataSet;
            // 
            // _19001_DBDataSet
            // 
            this._19001_DBDataSet.DataSetName = "_19001_DBDataSet";
            this._19001_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ulogeBindingSource
            // 
            this.ulogeBindingSource.DataMember = "Uloge";
            this.ulogeBindingSource.DataSource = this._19001_DBDataSet;
            // 
            // korisnikTableAdapter
            // 
            this.korisnikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KorisnikTableAdapter = this.korisnikTableAdapter;
            this.tableAdapterManager.PolaznostTableAdapter = null;
            this.tableAdapterManager.TerminTableAdapter = null;
            this.tableAdapterManager.TreningTableAdapter = null;
            this.tableAdapterManager.UlogeTableAdapter = this.ulogeTableAdapter;
            this.tableAdapterManager.UpdateOrder = MyJoga._19001_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ulogeTableAdapter
            // 
            this.ulogeTableAdapter.ClearBeforeFill = true;
            // 
            // uiKorisnicki_id
            // 
            this.uiKorisnicki_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "ID_korisnik", true));
            this.uiKorisnicki_id.Enabled = false;
            this.uiKorisnicki_id.Location = new System.Drawing.Point(118, 31);
            this.uiKorisnicki_id.Name = "uiKorisnicki_id";
            this.uiKorisnicki_id.Size = new System.Drawing.Size(100, 22);
            this.uiKorisnicki_id.TabIndex = 20;
            // 
            // uiIme
            // 
            this.uiIme.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "Ime", true));
            this.uiIme.Location = new System.Drawing.Point(118, 59);
            this.uiIme.Name = "uiIme";
            this.uiIme.Size = new System.Drawing.Size(100, 22);
            this.uiIme.TabIndex = 21;
            // 
            // uiPrezime
            // 
            this.uiPrezime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "Prezime", true));
            this.uiPrezime.Location = new System.Drawing.Point(118, 87);
            this.uiPrezime.Name = "uiPrezime";
            this.uiPrezime.Size = new System.Drawing.Size(100, 22);
            this.uiPrezime.TabIndex = 22;
            // 
            // uiEmail
            // 
            this.uiEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "Email", true));
            this.uiEmail.Location = new System.Drawing.Point(118, 115);
            this.uiEmail.Name = "uiEmail";
            this.uiEmail.Size = new System.Drawing.Size(100, 22);
            this.uiEmail.TabIndex = 23;
            // 
            // uiLozinka
            // 
            this.uiLozinka.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "Lozinka", true));
            this.uiLozinka.Location = new System.Drawing.Point(118, 143);
            this.uiLozinka.Name = "uiLozinka";
            this.uiLozinka.Size = new System.Drawing.Size(100, 22);
            this.uiLozinka.TabIndex = 24;
            // 
            // uiPlacena_clanarina
            // 
            this.uiPlacena_clanarina.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.korisnikBindingSource, "Placena_clanarina", true));
            this.uiPlacena_clanarina.Location = new System.Drawing.Point(118, 201);
            this.uiPlacena_clanarina.Name = "uiPlacena_clanarina";
            this.uiPlacena_clanarina.Size = new System.Drawing.Size(104, 24);
            this.uiPlacena_clanarina.TabIndex = 25;
            this.uiPlacena_clanarina.Text = "checkBox1";
            this.uiPlacena_clanarina.UseVisualStyleBackColor = true;
            // 
            // uiKorisnicko_ime
            // 
            this.uiKorisnicko_ime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.korisnikBindingSource, "Korisnicko_ime", true));
            this.uiKorisnicko_ime.Location = new System.Drawing.Point(122, 231);
            this.uiKorisnicko_ime.Name = "uiKorisnicko_ime";
            this.uiKorisnicko_ime.Size = new System.Drawing.Size(100, 22);
            this.uiKorisnicko_ime.TabIndex = 26;
            // 
            // uiDodajKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(korisnicko_imeLabel);
            this.Controls.Add(this.uiKorisnicko_ime);
            this.Controls.Add(placena_clanarinaLabel);
            this.Controls.Add(this.uiPlacena_clanarina);
            this.Controls.Add(lozinkaLabel);
            this.Controls.Add(this.uiLozinka);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.uiEmail);
            this.Controls.Add(prezimeLabel);
            this.Controls.Add(this.uiPrezime);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.uiIme);
            this.Controls.Add(iD_korisnikLabel);
            this.Controls.Add(this.uiKorisnicki_id);
            this.Controls.Add(tip_korisnikaLabel1);
            this.Controls.Add(this.cmbUnosTipKorisnika);
            this.Controls.Add(this.btnDodajAzurirajKorisnika);
            this.Name = "uiDodajKorisnika";
            this.Text = "uiDodajKorisnika";
            this.Load += new System.EventHandler(this.uiDodajKorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._19001_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDodajAzurirajKorisnika;
        private System.Windows.Forms.ComboBox cmbUnosTipKorisnika;
        private _19001_DBDataSet _19001_DBDataSet;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private _19001_DBDataSetTableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private _19001_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _19001_DBDataSetTableAdapters.UlogeTableAdapter ulogeTableAdapter;
        private System.Windows.Forms.BindingSource ulogeBindingSource;
        private System.Windows.Forms.TextBox uiKorisnicki_id;
        private System.Windows.Forms.TextBox uiIme;
        private System.Windows.Forms.TextBox uiPrezime;
        private System.Windows.Forms.TextBox uiEmail;
        private System.Windows.Forms.TextBox uiLozinka;
        private System.Windows.Forms.CheckBox uiPlacena_clanarina;
        private System.Windows.Forms.TextBox uiKorisnicko_ime;
    }
}