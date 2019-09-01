namespace MyJoga
{
    partial class uiDodajAzurirajTrening
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
            System.Windows.Forms.Label iD_treningLabel;
            System.Windows.Forms.Label vrsta_treningaLabel;
            System.Windows.Forms.Label trenerLabel;
            System.Windows.Forms.Label opisLabel;
            this.btnDodajAzurirajTrening = new System.Windows.Forms.Button();
            this.uiTrening_id = new System.Windows.Forms.TextBox();
            this.uiVrsta_treninga = new System.Windows.Forms.TextBox();
            this.uiTrener = new System.Windows.Forms.TextBox();
            this.uiOpis = new System.Windows.Forms.TextBox();
            this.btnOdaberiTrenera = new System.Windows.Forms.Button();
            this.treningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._19001_DBDataSet = new MyJoga._19001_DBDataSet();
            this.treningTableAdapter = new MyJoga._19001_DBDataSetTableAdapters.TreningTableAdapter();
            this.tableAdapterManager = new MyJoga._19001_DBDataSetTableAdapters.TableAdapterManager();
            iD_treningLabel = new System.Windows.Forms.Label();
            vrsta_treningaLabel = new System.Windows.Forms.Label();
            trenerLabel = new System.Windows.Forms.Label();
            opisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.treningBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._19001_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_treningLabel
            // 
            iD_treningLabel.AutoSize = true;
            iD_treningLabel.Location = new System.Drawing.Point(111, 31);
            iD_treningLabel.Name = "iD_treningLabel";
            iD_treningLabel.Size = new System.Drawing.Size(73, 17);
            iD_treningLabel.TabIndex = 2;
            iD_treningLabel.Text = "ID trening:";
            // 
            // vrsta_treningaLabel
            // 
            vrsta_treningaLabel.AutoSize = true;
            vrsta_treningaLabel.Location = new System.Drawing.Point(83, 59);
            vrsta_treningaLabel.Name = "vrsta_treningaLabel";
            vrsta_treningaLabel.Size = new System.Drawing.Size(101, 17);
            vrsta_treningaLabel.TabIndex = 3;
            vrsta_treningaLabel.Text = "Vrsta treninga:";
            // 
            // trenerLabel
            // 
            trenerLabel.AutoSize = true;
            trenerLabel.Location = new System.Drawing.Point(129, 87);
            trenerLabel.Name = "trenerLabel";
            trenerLabel.Size = new System.Drawing.Size(55, 17);
            trenerLabel.TabIndex = 5;
            trenerLabel.Text = "Trener:";
            // 
            // opisLabel
            // 
            opisLabel.AutoSize = true;
            opisLabel.Location = new System.Drawing.Point(143, 115);
            opisLabel.Name = "opisLabel";
            opisLabel.Size = new System.Drawing.Size(41, 17);
            opisLabel.TabIndex = 7;
            opisLabel.Text = "Opis:";
            // 
            // btnDodajAzurirajTrening
            // 
            this.btnDodajAzurirajTrening.Location = new System.Drawing.Point(282, 251);
            this.btnDodajAzurirajTrening.Name = "btnDodajAzurirajTrening";
            this.btnDodajAzurirajTrening.Size = new System.Drawing.Size(75, 23);
            this.btnDodajAzurirajTrening.TabIndex = 0;
            this.btnDodajAzurirajTrening.Text = "button1";
            this.btnDodajAzurirajTrening.UseVisualStyleBackColor = true;
            this.btnDodajAzurirajTrening.Click += new System.EventHandler(this.btnDodajAzurirajTrening_Click);
            // 
            // uiTrening_id
            // 
            this.uiTrening_id.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treningBindingSource, "ID_trening", true));
            this.uiTrening_id.Enabled = false;
            this.uiTrening_id.Location = new System.Drawing.Point(190, 28);
            this.uiTrening_id.Name = "uiTrening_id";
            this.uiTrening_id.Size = new System.Drawing.Size(100, 22);
            this.uiTrening_id.TabIndex = 3;
            // 
            // uiVrsta_treninga
            // 
            this.uiVrsta_treninga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treningBindingSource, "Vrsta_treninga", true));
            this.uiVrsta_treninga.Location = new System.Drawing.Point(190, 56);
            this.uiVrsta_treninga.Name = "uiVrsta_treninga";
            this.uiVrsta_treninga.Size = new System.Drawing.Size(100, 22);
            this.uiVrsta_treninga.TabIndex = 4;
            // 
            // uiTrener
            // 
            this.uiTrener.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treningBindingSource, "Trener", true));
            this.uiTrener.Enabled = false;
            this.uiTrener.Location = new System.Drawing.Point(190, 84);
            this.uiTrener.Name = "uiTrener";
            this.uiTrener.Size = new System.Drawing.Size(100, 22);
            this.uiTrener.TabIndex = 6;
            // 
            // uiOpis
            // 
            this.uiOpis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treningBindingSource, "Opis", true));
            this.uiOpis.Location = new System.Drawing.Point(190, 112);
            this.uiOpis.Multiline = true;
            this.uiOpis.Name = "uiOpis";
            this.uiOpis.Size = new System.Drawing.Size(100, 102);
            this.uiOpis.TabIndex = 8;
            // 
            // btnOdaberiTrenera
            // 
            this.btnOdaberiTrenera.Location = new System.Drawing.Point(296, 84);
            this.btnOdaberiTrenera.Name = "btnOdaberiTrenera";
            this.btnOdaberiTrenera.Size = new System.Drawing.Size(21, 22);
            this.btnOdaberiTrenera.TabIndex = 9;
            this.btnOdaberiTrenera.Text = "+";
            this.btnOdaberiTrenera.UseVisualStyleBackColor = true;
            this.btnOdaberiTrenera.Click += new System.EventHandler(this.btnOdaberiTrenera_Click);
            // 
            // treningBindingSource
            // 
            this.treningBindingSource.DataMember = "Trening";
            this.treningBindingSource.DataSource = this._19001_DBDataSet;
            // 
            // _19001_DBDataSet
            // 
            this._19001_DBDataSet.DataSetName = "_19001_DBDataSet";
            this._19001_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // treningTableAdapter
            // 
            this.treningTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KorisnikTableAdapter = null;
            this.tableAdapterManager.PolaznostTableAdapter = null;
            this.tableAdapterManager.TerminTableAdapter = null;
            this.tableAdapterManager.TreningTableAdapter = this.treningTableAdapter;
            this.tableAdapterManager.UlogeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MyJoga._19001_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // uiDodajAzurirajTrening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOdaberiTrenera);
            this.Controls.Add(opisLabel);
            this.Controls.Add(this.uiOpis);
            this.Controls.Add(trenerLabel);
            this.Controls.Add(this.uiTrener);
            this.Controls.Add(vrsta_treningaLabel);
            this.Controls.Add(this.uiVrsta_treninga);
            this.Controls.Add(iD_treningLabel);
            this.Controls.Add(this.uiTrening_id);
            this.Controls.Add(this.btnDodajAzurirajTrening);
            this.Name = "uiDodajAzurirajTrening";
            this.Text = "uiDodajAzurirajTrening";
            this.Load += new System.EventHandler(this.uiDodajAzurirajTrening_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treningBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._19001_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajAzurirajTrening;
        private _19001_DBDataSet _19001_DBDataSet;
        private System.Windows.Forms.BindingSource treningBindingSource;
        private _19001_DBDataSetTableAdapters.TreningTableAdapter treningTableAdapter;
        private _19001_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox uiTrening_id;
        private System.Windows.Forms.TextBox uiVrsta_treninga;
        private System.Windows.Forms.TextBox uiTrener;
        private System.Windows.Forms.TextBox uiOpis;
        private System.Windows.Forms.Button btnOdaberiTrenera;
    }
}