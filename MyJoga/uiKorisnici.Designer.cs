namespace MyJoga
{
    partial class uiKorisnici
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
            this._19001_DBDataSet = new MyJoga._19001_DBDataSet();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikTableAdapter = new MyJoga._19001_DBDataSetTableAdapters.KorisnikTableAdapter();
            this.tableAdapterManager = new MyJoga._19001_DBDataSetTableAdapters.TableAdapterManager();
            this.ulogeTableAdapter = new MyJoga._19001_DBDataSetTableAdapters.UlogeTableAdapter();
            this.korisnikDataGridView = new System.Windows.Forms.DataGridView();
            this.ulogeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodajKorisnika = new System.Windows.Forms.Button();
            this.btnAzurirajKorisnika = new System.Windows.Forms.Button();
            this.btnObrisiKorisnika = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._19001_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _19001_DBDataSet
            // 
            this._19001_DBDataSet.DataSetName = "_19001_DBDataSet";
            this._19001_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // korisnikBindingSource
            // 
            this.korisnikBindingSource.DataMember = "Korisnik";
            this.korisnikBindingSource.DataSource = this._19001_DBDataSet;
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
            // korisnikDataGridView
            // 
            this.korisnikDataGridView.AllowUserToAddRows = false;
            this.korisnikDataGridView.AllowUserToDeleteRows = false;
            this.korisnikDataGridView.AutoGenerateColumns = false;
            this.korisnikDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.korisnikDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1});
            this.korisnikDataGridView.DataSource = this.korisnikBindingSource;
            this.korisnikDataGridView.Location = new System.Drawing.Point(6, 32);
            this.korisnikDataGridView.MultiSelect = false;
            this.korisnikDataGridView.Name = "korisnikDataGridView";
            this.korisnikDataGridView.ReadOnly = true;
            this.korisnikDataGridView.RowTemplate.Height = 24;
            this.korisnikDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.korisnikDataGridView.Size = new System.Drawing.Size(1077, 220);
            this.korisnikDataGridView.TabIndex = 1;
            // 
            // ulogeBindingSource
            // 
            this.ulogeBindingSource.DataMember = "Uloge";
            this.ulogeBindingSource.DataSource = this._19001_DBDataSet;
            // 
            // btnDodajKorisnika
            // 
            this.btnDodajKorisnika.Location = new System.Drawing.Point(398, 305);
            this.btnDodajKorisnika.Name = "btnDodajKorisnika";
            this.btnDodajKorisnika.Size = new System.Drawing.Size(75, 23);
            this.btnDodajKorisnika.TabIndex = 2;
            this.btnDodajKorisnika.Text = "Dodaj";
            this.btnDodajKorisnika.UseVisualStyleBackColor = true;
            this.btnDodajKorisnika.Click += new System.EventHandler(this.btnDodajKorisnika_Click);
            // 
            // btnAzurirajKorisnika
            // 
            this.btnAzurirajKorisnika.Location = new System.Drawing.Point(513, 304);
            this.btnAzurirajKorisnika.Name = "btnAzurirajKorisnika";
            this.btnAzurirajKorisnika.Size = new System.Drawing.Size(75, 23);
            this.btnAzurirajKorisnika.TabIndex = 3;
            this.btnAzurirajKorisnika.Text = "Ažuriraj";
            this.btnAzurirajKorisnika.UseVisualStyleBackColor = true;
            this.btnAzurirajKorisnika.Click += new System.EventHandler(this.btnAzurirajKorisnika_Click);
            // 
            // btnObrisiKorisnika
            // 
            this.btnObrisiKorisnika.Location = new System.Drawing.Point(626, 304);
            this.btnObrisiKorisnika.Name = "btnObrisiKorisnika";
            this.btnObrisiKorisnika.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiKorisnika.TabIndex = 4;
            this.btnObrisiKorisnika.Text = "Obriši";
            this.btnObrisiKorisnika.UseVisualStyleBackColor = true;
            this.btnObrisiKorisnika.Click += new System.EventHandler(this.btnObrisiKorisnika_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_korisnik";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_korisnik";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ime";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prezime";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prezime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Korisnicko_ime";
            this.dataGridViewTextBoxColumn7.HeaderText = "Korisničko ime";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Lozinka";
            this.dataGridViewTextBoxColumn5.HeaderText = "Lozinka";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Tip_korisnika";
            this.dataGridViewTextBoxColumn6.DataSource = this.ulogeBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "Uloga";
            this.dataGridViewTextBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn6.HeaderText = "Tip korisnika";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "ID_uloga";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Placena_clanarina";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Plaćena članarina";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // uiKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 532);
            this.Controls.Add(this.btnObrisiKorisnika);
            this.Controls.Add(this.btnAzurirajKorisnika);
            this.Controls.Add(this.btnDodajKorisnika);
            this.Controls.Add(this.korisnikDataGridView);
            this.Name = "uiKorisnici";
            this.Text = "uiKorisnici";
            this.Load += new System.EventHandler(this.uiKorisnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this._19001_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulogeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private _19001_DBDataSet _19001_DBDataSet;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private _19001_DBDataSetTableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private _19001_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView korisnikDataGridView;
        private System.Windows.Forms.Button btnDodajKorisnika;
        private System.Windows.Forms.Button btnAzurirajKorisnika;
        private System.Windows.Forms.Button btnObrisiKorisnika;
        private _19001_DBDataSetTableAdapters.UlogeTableAdapter ulogeTableAdapter;
        private System.Windows.Forms.BindingSource ulogeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}