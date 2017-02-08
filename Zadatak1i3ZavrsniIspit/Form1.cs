using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using $safeprojectname$.Properties;

namespace $safeprojectname$
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowDataInListBox();
        }

        private void ShowDataInListBox()
        {
            try
            {
                KravadooEntities1 entity = new KravadooEntities1();
                List<Krava> listaKrava = entity.Krava.ToList();

                foreach (Krava k in listaKrava)
                {
                    lbKrave.Items.Add(k);
                }
            }
            catch (Exception e)
            {
                lblIspis.Text = e.Message;
            }
        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {
            Form2 dva = new Form2();
            dva.Show();
            dva.DohvatiKravu((Krava)lbKrave.SelectedItem);
        }

        private void lbKrave_SelectedIndexChanged(object sender, EventArgs e)
        {
            Krava k = (Krava) lbKrave.SelectedItem;
            lblIspis.Text = k.Pasmina.Naziv;
        }
    }
}
