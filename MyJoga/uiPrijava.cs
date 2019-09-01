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
    public partial class uiPrijava : Form
    {
        _19001_DBDataSetTableAdapters.KorisnikTableAdapter korisnikTableAdapter;

        public uiPrijava()
        {
            InitializeComponent();
            korisnikTableAdapter = new _19001_DBDataSetTableAdapters.KorisnikTableAdapter();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            lblIspisGrešaka.Text = "";
            _19001_DBDataSet.KorisnikRow korisnik;

            try
            {
                korisnik = korisnikTableAdapter.GetDataByUsername(txtUnosKorisnickoIme.Text)[0];
            }
            catch (IndexOutOfRangeException)
            {
                lblIspisGrešaka.Text = "Uneseni korisnik ne postoji";
                return;
            }

            if (korisnik.Lozinka.Equals(txtUnosLozinka.Text))
            {
                PodaciPrijave.OtvoriSesiju(korisnik);
                PrikaziGlavnuFormu();

                // Nakon zatvaranja glavne forme
                PodaciPrijave.ZatvoriSesiju();
                txtUnosKorisnickoIme.Focus();
            }
            else
            {
                lblIspisGrešaka.Text = "Pogrešna lozinka";
            }
        }

        private void PrikaziGlavnuFormu()
        {
            this.Hide();
            uiGlavniIzbornik glavnaForma = new uiGlavniIzbornik();
            glavnaForma.ShowDialog();

            txtUnosKorisnickoIme.Text = "";
            txtUnosLozinka.Text = "";
            this.Show();
        }
    }
}
