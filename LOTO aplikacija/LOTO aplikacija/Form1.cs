using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOTO_aplikacija
{
    public partial class FrmLoto : Form
    {
        public FrmLoto()
        {
            InitializeComponent();
        }

        private void btnUplati_Click(object sender, EventArgs e)
        {
            List<string> vrijednosti = new List<string>();
            vrijednosti.Add(txtUplaceniBroj1.Text);
            vrijednosti.Add(txtUplaceniBroj2.Text);
            vrijednosti.Add(txtUplaceniBroj3.Text);
            vrijednosti.Add(txtUplaceniBroj4.Text);
            vrijednosti.Add(txtUplaceniBroj5.Text);
            vrijednosti.Add(txtUplaceniBroj6.Text);
            vrijednosti.Add(txtUplaceniBroj7.Text);
            bool ispravnaKombinacija = Loto.UnesiUplaceneBrojeve(vrijednosti);
            if (ispravnaKombinacija == true)
            {
                btnOdigraj.Enabled = true;
            }
            else
            {
                btnOdigraj.Enabled = false;
                MessageBox.Show("Kombinacija uplaćenih brojeva nije ispravna!");
            }
        }

        private void btnOdigraj_Click(object sender, EventArgs e)
        {
            Loto.GenerirajDobitnuKombinaciju();
            txtDobitniBroj1.Text = Loto.DobitniBrojevi[0].ToString();
            txtDobitniBroj2.Text = Loto.DobitniBrojevi[1].ToString();
            txtDobitniBroj3.Text = Loto.DobitniBrojevi[2].ToString();
            txtDobitniBroj4.Text = Loto.DobitniBrojevi[3].ToString();
            txtDobitniBroj5.Text = Loto.DobitniBrojevi[4].ToString();
            txtDobitniBroj6.Text = Loto.DobitniBrojevi[5].ToString();
            txtDobitniBroj7.Text = Loto.DobitniBrojevi[6].ToString();
            int brojPogodaka = Loto.IzracunajBrojPogodaka();
            lblBrojPogodaka.Text = brojPogodaka.ToString();
        }
    }
}
