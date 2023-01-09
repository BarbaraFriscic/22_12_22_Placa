using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_12_22_Placa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            gbxZaposleniRadnik.Visible = false;        
        }

        private void btnZaposli_Click(object sender, EventArgs e)
        {
            try
            {
                Zaposlenik novi = new Zaposlenik(txtIme.Text, Convert.ToInt32(txtPlacaPoSatu.Text), Convert.ToInt32(txtSatiRada.Text));
                txtIme2.Text = novi.Ime;
                txtPlacaPoSatu2.Text = Convert.ToString(novi.PlacaPoSatu);
                txtSatiRada2.Text = Convert.ToString(novi.BrojRadnihSati);
                txtUkupnaPlaca.Text = Convert.ToString(novi.UkupnaPlaca);
                txtIme2.Enabled = false; txtPlacaPoSatu2.Enabled = false; txtSatiRada2.Enabled = false;
                gbxZaposleniRadnik.Visible = true;
                gbxNoviRadnik.Visible = false;
            }
            catch (ArgumentException x)
            {
                MessageBox.Show(x.Message);
            }
            catch(FormatException x)
            {
                MessageBox.Show(x.Message);
            }   
        }

        private void btnOtpusti_Click(object sender, EventArgs e)
        {
            txtIme.Clear(); txtIme2.Clear();
            txtPlacaPoSatu.Clear(); txtPlacaPoSatu2.Clear();
            txtSatiRada.Clear(); txtSatiRada2.Clear();
            txtUkupnaPlaca.Clear();
            gbxZaposleniRadnik.Visible = false;
            gbxNoviRadnik.Visible = true;
        }
        
        void PlacaPromijeni(int a)
        {
            Zaposlenik temp = new Zaposlenik(txtIme.Text, Convert.ToInt32(txtPlacaPoSatu2.Text), Convert.ToInt32(txtSatiRada2.Text));
            if(a == 1)
            {
                try
                {
                    temp.PlacaPoSatu--;
                    txtPlacaPoSatu2.Text = temp.PlacaPoSatu.ToString();
                }
                catch (ArgumentException x)
                {
                    MessageBox.Show(x.Message);
                }
            }         
            else if(a == 2)
            {
                try
                {
                    temp.PlacaPoSatu++;
                    txtPlacaPoSatu2.Text = temp.PlacaPoSatu.ToString();
                }
                catch (ArgumentException x)
                {
                    MessageBox.Show(x.Message);
                }
            }  
            else if(a == 3)
            {
                try
                {
                    temp.BrojRadnihSati++;
                    txtSatiRada2.Text = temp.BrojRadnihSati.ToString();
                }
                catch (ArgumentException x)
                {
                    MessageBox.Show(x.Message);
                }              
            }            
            else if(a == 4)
            {
                try
                {
                    temp.BrojRadnihSati--;
                    txtSatiRada2.Text = temp.BrojRadnihSati.ToString();
                }
                catch (ArgumentException x)
                {
                    MessageBox.Show(x.Message);
                }
                
            }
            txtUkupnaPlaca.Text = temp.UkupnaPlaca.ToString();
        }
        private void btnPlacapoSatuOduzmi_Click(object sender, EventArgs e)
        {
            PlacaPromijeni(1);
        }

        private void btnPlacapoSatuDodaj_Click(object sender, EventArgs e)
        {
            PlacaPromijeni(2);
        }

        private void btnRadnihSatiOduzmi_Click(object sender, EventArgs e)
        {
            PlacaPromijeni(4);
        }

        private void btnRadnihSatiDodaj_Click(object sender, EventArgs e)
        {
            PlacaPromijeni(3);
        }


    }
}
