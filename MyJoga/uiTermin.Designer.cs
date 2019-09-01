namespace MyJoga
{
    partial class uiTermin
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
            this.terminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.terminTableAdapter = new MyJoga._19001_DBDataSetTableAdapters.TerminTableAdapter();
            this.tableAdapterManager = new MyJoga._19001_DBDataSetTableAdapters.TableAdapterManager();
            this.terminDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnObrisiTrening = new System.Windows.Forms.Button();
            this.btnAzurirajTrening = new System.Windows.Forms.Button();
            this.btnDodajTrening = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._19001_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _19001_DBDataSet
            // 
            this._19001_DBDataSet.DataSetName = "_19001_DBDataSet";
            this._19001_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // terminBindingSource
            // 
            this.terminBindingSource.DataMember = "Termin";
            this.terminBindingSource.DataSource = this._19001_DBDataSet;
            // 
            // terminTableAdapter
            // 
            this.terminTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.PolaznostTableAdapter = null;
            this.tableAdapterManager.TerminTableAdapter = this.terminTableAdapter;
            this.tableAdapterManager.TreningTableAdapter = null;
            this.tableAdapterManager.UlogeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MyJoga._19001_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // terminDataGridView
            // 
            this.terminDataGridView.AllowUserToAddRows = false;
            this.terminDataGridView.AllowUserToDeleteRows = false;
            this.terminDataGridView.AutoGenerateColumns = false;
            this.terminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.terminDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.terminDataGridView.DataSource = this.terminBindingSource;
            this.terminDataGridView.Location = new System.Drawing.Point(12, 12);
            this.terminDataGridView.MultiSelect = false;
            this.terminDataGridView.Name = "terminDataGridView";
            this.terminDataGridView.ReadOnly = true;
            this.terminDataGridView.RowTemplate.Height = 24;
            this.terminDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.terminDataGridView.Size = new System.Drawing.Size(660, 220);
            this.terminDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_termin";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_termin";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Datum";
            this.dataGridViewTextBoxColumn2.HeaderText = "Datum";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Trajanje";
            this.dataGridViewTextBoxColumn3.HeaderText = "Trajanje";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Broj_polaznika";
            this.dataGridViewTextBoxColumn4.HeaderText = "Broj_polaznika";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Trening";
            this.dataGridViewTextBoxColumn5.HeaderText = "Trening";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Maximalni_broj_polaznika";
            this.dataGridViewTextBoxColumn6.HeaderText = "Maximalni_broj_polaznika";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // btnObrisiTrening
            // 
            this.btnObrisiTrening.Location = new System.Drawing.Point(490, 296);
            this.btnObrisiTrening.Name = "btnObrisiTrening";
            this.btnObrisiTrening.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiTrening.TabIndex = 10;
            this.btnObrisiTrening.Text = "Obriši";
            this.btnObrisiTrening.UseVisualStyleBackColor = true;
            this.btnObrisiTrening.Click += new System.EventHandler(this.btnObrisiTrening_Click);
            // 
            // btnAzurirajTrening
            // 
            this.btnAzurirajTrening.Location = new System.Drawing.Point(377, 296);
            this.btnAzurirajTrening.Name = "btnAzurirajTrening";
            this.btnAzurirajTrening.Size = new System.Drawing.Size(75, 23);
            this.btnAzurirajTrening.TabIndex = 9;
            this.btnAzurirajTrening.Text = "Ažuriraj";
            this.btnAzurirajTrening.UseVisualStyleBackColor = true;
            this.btnAzurirajTrening.Click += new System.EventHandler(this.btnAzurirajTrening_Click);
            // 
            // btnDodajTrening
            // 
            this.btnDodajTrening.Location = new System.Drawing.Point(262, 297);
            this.btnDodajTrening.Name = "btnDodajTrening";
            this.btnDodajTrening.Size = new System.Drawing.Size(75, 23);
            this.btnDodajTrening.TabIndex = 8;
            this.btnDodajTrening.Text = "Dodaj";
            this.btnDodajTrening.UseVisualStyleBackColor = true;
            this.btnDodajTrening.Click += new System.EventHandler(this.btnDodajTrening_Click);
            // 
            // uiTermin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObrisiTrening);
            this.Controls.Add(this.btnAzurirajTrening);
            this.Controls.Add(this.btnDodajTrening);
            this.Controls.Add(this.terminDataGridView);
            this.Name = "uiTermin";
            this.Text = "uiTermin";
            this.Load += new System.EventHandler(this.uiTermin_Load);
            ((System.ComponentModel.ISupportInitialize)(this._19001_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private _19001_DBDataSet _19001_DBDataSet;
        private System.Windows.Forms.BindingSource terminBindingSource;
        private _19001_DBDataSetTableAdapters.TerminTableAdapter terminTableAdapter;
        private _19001_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView terminDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnObrisiTrening;
        private System.Windows.Forms.Button btnAzurirajTrening;
        private System.Windows.Forms.Button btnDodajTrening;
    }
}