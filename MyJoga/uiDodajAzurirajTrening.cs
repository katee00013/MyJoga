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
    public partial class uiDodajAzurirajTrening : Form
    {

        private int Trening = 0;
        private string Naredba = "";

        public uiDodajAzurirajTrening(int idTrening, string naredba)
        {
            InitializeComponent();

            Trening = idTrening;
            Naredba = naredba;

            if (naredba == "dodaj")
            {
                this.Text = "Dodaj trening";
                this.btnDodajAzurirajTrening.Text = "Dodaj";
            }
            if (naredba == "azuriraj")
            {
                this.Text = "Ažuriraj trening";
                this.btnDodajAzurirajTrening.Text = "Ažuriraj";
            }
        }

        private void uiDodajAzurirajTrening_Load(object sender, EventArgs e)
        {
            if (Naredba == "azuriraj")
            {
                // TODO: This line of code loads data into the '_19001_DBDataSet.Trening' table. You can move, or remove it, as needed.
                this.treningTableAdapter.FillById(this._19001_DBDataSet.Trening, Trening);
            }
        }

        private void spremiPromjene()
        {
            this.Validate();
            this.treningBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._19001_DBDataSet);

        }


        private void btnDodajAzurirajTrening_Click(object sender, EventArgs e)
        {
            if (Naredba == "azuriraj")
            {
                spremiPromjene();
                this.Close();
                Application.OpenForms.OfType<uiTrening>().Single().popuniPodacima();
            }

            if (Naredba == "dodaj")
            {
                string vrstaTreninga, opis;
                int trener;

                vrstaTreninga = uiVrsta_treninga.Text;
                opis = uiOpis.Text;               
                trener = int.Parse(uiTrener.Text);
                try
                {
                    treningTableAdapter.InsertNoviTrening(vrstaTreninga,trener, opis);
                    MessageBox.Show("Trening je uspješno dodan");
                    ocistiText();
                }
                catch (Exception)
                {
                    MessageBox.Show("Greška kod dodavanja treninga");
                }

                spremiPromjene();
                this.Close();
                Application.OpenForms.OfType<uiTrening>().Single().popuniPodacima();
            }
        }

        private void btnOdaberiTrenera_Click(object sender, EventArgs e)
        {
            uiOdaberiTrenera uiOdaberiTrenera = new uiOdaberiTrenera("trening");
            uiOdaberiTrenera.ShowDialog();
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

        public void PostaviVrijednostOdabranogTrenera(string idTrener)
        {
            uiTrener.Text = idTrener;
        }
    }
}
