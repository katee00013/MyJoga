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
    public partial class uiTermin : Form
    {
        public uiTermin()
        {
            InitializeComponent();
        }

        private void spremiPromjene()
        {
            this.Validate();
            this.terminBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._19001_DBDataSet);

        }

        private void uiTermin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_19001_DBDataSet.Termin' table. You can move, or remove it, as needed.
            this.terminTableAdapter.Fill(this._19001_DBDataSet.Termin);

        }

        private void btnDodajTrening_Click(object sender, EventArgs e)
        {

        }

        private void btnAzurirajTrening_Click(object sender, EventArgs e)
        {

        }

        private void btnObrisiTrening_Click(object sender, EventArgs e)
        {

        }
    }
}
