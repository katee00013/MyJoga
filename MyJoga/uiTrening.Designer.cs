namespace MyJoga
{
    partial class uiTrening
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
            this.treningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treningTableAdapter = new MyJoga._19001_DBDataSetTableAdapters.TreningTableAdapter();
            this.tableAdapterManager = new MyJoga._19001_DBDataSetTableAdapters.TableAdapterManager();
            this.treningDataGridView = new System.Windows.Forms.DataGridView();
            this.btnObrisiTrening = new System.Windows.Forms.Button();
            this.btnAzurirajTrening = new System.Windows.Forms.Button();
            this.btnDodajTrening = new System.Windows.Forms.Button();
            this.korisnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.korisnikTableAdapter = new MyJoga._19001_DBDataSetTableAdapters.KorisnikTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._19001_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _19001_DBDataSet
            // 
            this._19001_DBDataSet.DataSetName = "_19001_DBDataSet";
            this._19001_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // treningBindingSource
            // 
            this.treningBindingSource.DataMember = "Trening";
            this.treningBindingSource.DataSource = this._19001_DBDataSet;
            // 
            // treningTableAdapter
            // 
            this.treningTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KorisnikTableAdapter = this.korisnikTableAdapter;
            this.tableAdapterManager.PolaznostTableAdapter = null;
            this.tableAdapterManager.TerminTableAdapter = null;
            this.tableAdapterManager.TreningTableAdapter = this.treningTableAdapter;
            this.tableAdapterManager.UlogeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MyJoga._19001_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // treningDataGridView
            // 
            this.treningDataGridView.AllowUserToAddRows = false;
            this.treningDataGridView.AllowUserToDeleteRows = false;
            this.treningDataGridView.AutoGenerateColumns = false;
            this.treningDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.treningDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.treningDataGridView.DataSource = this.treningBindingSource;
            this.treningDataGridView.Location = new System.Drawing.Point(12, 12);
            this.treningDataGridView.MultiSelect = false;
            this.treningDataGridView.Name = "treningDataGridView";
            this.treningDataGridView.ReadOnly = true;
            this.treningDataGridView.RowTemplate.Height = 24;
            this.treningDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.treningDataGridView.Size = new System.Drawing.Size(776, 220);
            this.treningDataGridView.TabIndex = 1;
            // 
            // btnObrisiTrening
            // 
            this.btnObrisiTrening.Location = new System.Drawing.Point(524, 285);
            this.btnObrisiTrening.Name = "btnObrisiTrening";
            this.btnObrisiTrening.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiTrening.TabIndex = 7;
            this.btnObrisiTrening.Text = "Obriši";
            this.btnObrisiTrening.UseVisualStyleBackColor = true;
            this.btnObrisiTrening.Click += new System.EventHandler(this.btnObrisiTrening_Click);
            // 
            // btnAzurirajTrening
            // 
            this.btnAzurirajTrening.Location = new System.Drawing.Point(411, 285);
            this.btnAzurirajTrening.Name = "btnAzurirajTrening";
            this.btnAzurirajTrening.Size = new System.Drawing.Size(75, 23);
            this.btnAzurirajTrening.TabIndex = 6;
            this.btnAzurirajTrening.Text = "Ažuriraj";
            this.btnAzurirajTrening.UseVisualStyleBackColor = true;
            this.btnAzurirajTrening.Click += new System.EventHandler(this.btnAzurirajTrening_Click);
            // 
            // btnDodajTrening
            // 
            this.btnDodajTrening.Location = new System.Drawing.Point(296, 286);
            this.btnDodajTrening.Name = "btnDodajTrening";
            this.btnDodajTrening.Size = new System.Drawing.Size(75, 23);
            this.btnDodajTrening.TabIndex = 5;
            this.btnDodajTrening.Text = "Dodaj";
            this.btnDodajTrening.UseVisualStyleBackColor = true;
            this.btnDodajTrening.Click += new System.EventHandler(this.btnDodajTrening_Click);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_trening";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_trening";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Vrsta_treninga";
            this.dataGridViewTextBoxColumn2.HeaderText = " Vrsta treninga";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Trener";
            this.dataGridViewTextBoxColumn3.DataSource = this.korisnikBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Korisnicko_ime";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.HeaderText = "Trener";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "ID_korisnik";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Opis";
            this.dataGridViewTextBoxColumn4.HeaderText = "Opis";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // uiTrening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObrisiTrening);
            this.Controls.Add(this.btnAzurirajTrening);
            this.Controls.Add(this.btnDodajTrening);
            this.Controls.Add(this.treningDataGridView);
            this.Name = "uiTrening";
            this.Text = "uiTrening";
            this.Load += new System.EventHandler(this.uiTrening_Load);
            ((System.ComponentModel.ISupportInitialize)(this._19001_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.korisnikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private _19001_DBDataSet _19001_DBDataSet;
        private System.Windows.Forms.BindingSource treningBindingSource;
        private _19001_DBDataSetTableAdapters.TreningTableAdapter treningTableAdapter;
        private _19001_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView treningDataGridView;
        private System.Windows.Forms.Button btnObrisiTrening;
        private System.Windows.Forms.Button btnAzurirajTrening;
        private System.Windows.Forms.Button btnDodajTrening;
        private _19001_DBDataSetTableAdapters.KorisnikTableAdapter korisnikTableAdapter;
        private System.Windows.Forms.BindingSource korisnikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}