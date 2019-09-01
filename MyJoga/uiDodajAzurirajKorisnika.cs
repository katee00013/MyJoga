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
    public partial class uiDodajAzurirajKorisnika : Form
    {

        private int Korisnik = 0;
        private string Naredba = "";

        public uiDodajAzurirajKorisnika(int idKorisnik, string naredba)
        {
            InitializeComponent();

            Korisnik = idKorisnik;
            Naredba = naredba;

            if (naredba == "dodaj")
            {
                this.Text = "Dodaj korisnika";
                this.btnDodajAzurirajKorisnika.Text = "Dodaj";
            }
            if (naredba == "azuriraj")
            {
                this.Text = "Ažuriraj korisnika";
                this.btnDodajAzurirajKorisnika.Text = "Ažuriraj";
            }
        }

        private void spremiPromjene()
        {
            this.Validate();
            this.korisnikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._19001_DBDataSet);

        }

        private void uiDodajKorisnika_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_19001_DBDataSet.Uloge' table. You can move, or remove it, as needed.
            this.ulogeTableAdapter.Fill(this._19001_DBDataSet.Uloge);

            if (Naredba == "azuriraj")
            {
                // TODO: This line of code loads data into the '_19001_DBDataSet.Korisnik' table. You can move, or remove it, as needed.
                this.korisnikTableAdapter.FillById(this._19001_DBDataSet.Korisnik, Korisnik);
            }

        }

        private void btnDodajAzurirajKorisnika_Click(object sender, EventArgs e)
        {
            if (Naredba == "azuriraj")
            {
                spremiPromjene();
                this.Close();
                Application.OpenForms.OfType<uiKorisnici>().Single().popuniPodacima();
            }

            if (Naredba == "dodaj")
            {
                string korisnickoIme, lozinka, ime, prezime, email;
                int tipKorisnika;
                bool placenaClanarina = false;

                korisnickoIme = uiKorisnicko_ime.Text;
                lozinka = uiLozinka.Text;
                ime = uiIme.Text;
                prezime = uiPrezime.Text;
                email = uiEmail.Text;
                tipKorisnika = int.Parse(cmbUnosTipKorisnika.SelectedValue.ToString());
                placenaClanarina = uiPlacena_clanarina.Checked;
                try
                {
                    korisnikTableAdapter.InsertNoviKorisnik(ime, prezime, email, lozinka, tipKorisnika, placenaClanarina, korisnickoIme);
                    MessageBox.Show("Korisnik je uspješno dodan");
                    ocistiText();
                }
                catch (Exception)
                {
                    MessageBox.Show("Greška kod dodavanja korisnika");
                }

                spremiPromjene();
                this.Close();
                Application.OpenForms.OfType<uiKorisnici>().Single().popuniPodacima();
            }
        }

        private void ocistiText()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
    }
}
