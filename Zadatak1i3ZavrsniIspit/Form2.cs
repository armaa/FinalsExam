using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Form2 : Form
    {
        private static int IdKrava = 0;

        enum Pasmina
        {
            Simentalska = 1,
            Holstein = 2,
            [Display (Name = ("Domaća Obična"))]
            DomaćaObična = 3
        };

        public Form2()
        {
            InitializeComponent();
            cbPasmina.DataSource = Enum.GetValues(typeof(Pasmina));
        }

        public void DohvatiKravu(Krava k)
        {
            IdKrava = k.Id;
            txtIme.Text = k.Ime;
            
            switch (k.Pasmina.Id)
            {
                case 1:
                    cbPasmina.Text = Pasmina.Simentalska.ToString();
                    break;
                case 2:
                    cbPasmina.Text = Pasmina.Holstein.ToString();
                    break;
                case 3:
                    cbPasmina.Text = Pasmina.DomaćaObična.ToString();
                    break;
                default:
                    break;
            }

            dateRodjen.Value = k.DatumDolaska;
            txtVetBroj.Text = k.VeterinarskiBroj;
            dateDolazak.Value = k.DatumDolaska;
            numBrojTeladi.Value = k.BrojTeladi;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (KravadooEntities1 entity = new KravadooEntities1())
            {
                Krava result = entity.Krava.Find(IdKrava);

                if (result != null)
                {
                    result.Ime = txtIme.Text;
                    result.PasminaId = (int) cbPasmina.SelectedValue;
                    result.DatumRodjenja = dateRodjen.Value;
                    result.VeterinarskiBroj = txtVetBroj.Text;
                    result.DatumDolaska = dateDolazak.Value;
                    result.BrojTeladi = (int) numBrojTeladi.Value;

                    entity.SaveChanges();
                }

            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
