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
    public partial class uiOdaberiTrenera : Form
    {

        private string Naredba = "";

        public uiOdaberiTrenera(string naredba)
        {
            InitializeComponent();
            Naredba = naredba;
        }

        private void korisnikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.korisnikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._19001_DBDataSet);

        }

        private void uiOdaberiTrenera_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_19001_DBDataSet.Korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.FillByTrener(this._19001_DBDataSet.Korisnik);

        }

        private void brnOdaberiTrenera_Click(object sender, EventArgs e)
        {
            string id = korisnikDataGridView.SelectedCells[0].Value.ToString();

            if (Naredba == "trening")
            {
                Application.OpenForms.OfType<uiDodajAzurirajTrening>().Single().PostaviVrijednostOdabranogTrenera(id);
            }

            this.Close();
        }
    }
}
