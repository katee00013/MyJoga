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
    public partial class uiKorisnici : Form
    {
        public uiKorisnici()
        {
            InitializeComponent();
        }

        private void SpremiPromjene()
        {
            this.Validate();
            this.korisnikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._19001_DBDataSet);

        }

        private void uiKorisnici_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            // TODO: This line of code loads data into the '_19001_DBDataSet.Uloge' table. You can move, or remove it, as needed.
            this.ulogeTableAdapter.Fill(this._19001_DBDataSet.Uloge);
            // TODO: This line of code loads data into the '_19001_DBDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this._19001_DBDataSet.Korisnik);
        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            int korisnik = int.Parse(korisnikDataGridView.SelectedCells[0].Value.ToString());
            uiDodajAzurirajKorisnika uiDodajKorisnika = new uiDodajAzurirajKorisnika(korisnik, "dodaj");
            uiDodajKorisnika.ShowDialog();
        }

        private void btnAzurirajKorisnika_Click(object sender, EventArgs e)
        {
            if (korisnikDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite korisnika kojeg želite ažurirati!");
            }
            else
            {
                int korisnik = int.Parse(korisnikDataGridView.SelectedCells[0].Value.ToString());
                uiDodajAzurirajKorisnika uiDodajKorisnika = new uiDodajAzurirajKorisnika(korisnik, "azuriraj");
                uiDodajKorisnika.ShowDialog();
            }
        }

        private void btnObrisiKorisnika_Click(object sender, EventArgs e)
        {
            if (korisnikDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Odaberite korisnika kojeg želite obrisati!");
            }
            else if (MessageBox.Show("Jeste li sigurni da želite obrisati odabranog korisnika?", "Obrisati korisnika", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                korisnikDataGridView.Rows.RemoveAt(korisnikDataGridView.CurrentRow.Index);
            }
            SpremiPromjene();
        }

    }
}

