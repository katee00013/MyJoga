using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyJoga
{
    public partial class uiTrening : Form
    {
        public uiTrening()
        {
            InitializeComponent();
        }

        private void spremiPromjene()
        {
            this.Validate();
            this.treningBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._19001_DBDataSet);

        }

        private void uiTrening_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            // TODO: This line of code loads data into the '_19001_DBDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this._19001_DBDataSet.Korisnik);
            // TODO: This line of code loads data into the '_19001_DBDataSet.Trening' table. You can move, or remove it, as needed.
            this.treningTableAdapter.Fill(this._19001_DBDataSet.Trening);
        }

        private void btnDodajTrening_Click(object sender, EventArgs e)
        {
            int trening = int.Parse(treningDataGridView.SelectedCells[0].Value.ToString());
            uiDodajAzurirajTrening uiDodajTrening = new uiDodajAzurirajTrening(trening, "dodaj");
            uiDodajTrening.ShowDialog();
        }

        private void btnAzurirajTrening_Click(object sender, EventArgs e)
        {
            if (treningDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite trening kojeg želite ažurirati!");
            }
            else
            {
                int trening = int.Parse(treningDataGridView.SelectedCells[0].Value.ToString());
                uiDodajAzurirajTrening uiAzurirajTrening = new uiDodajAzurirajTrening(trening, "azuriraj");
                uiAzurirajTrening.ShowDialog();
            }
        }

        private void btnObrisiTrening_Click(object sender, EventArgs e)
        {
            if (treningDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite trening kojeg želite obrisati!");
            }
            else if (MessageBox.Show("Jeste li sigurni da želite obrisati odabrani trening?", "Obrisati trening", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                treningDataGridView.Rows.RemoveAt(treningDataGridView.CurrentRow.Index);
            }
            spremiPromjene();
        }
    }
}
