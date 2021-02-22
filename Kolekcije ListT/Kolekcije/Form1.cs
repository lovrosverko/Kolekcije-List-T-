using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kolekcije
{

    public partial class Form1 : Form
    {
        /// <summary>
        /// instanciranje liste u koju ćemo spremati
        /// objekte klase Brkovi
        /// </summary>
        List<Brkovi> lista = new List<Brkovi>();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// metoda koja se izvršava klikom na gumb "Unesi"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnos_Click(object sender, EventArgs e)
        {
            
            try
            {
                /*
                 * instanciranje objekta 'brk' iz klase 'Brkovi
                 * pomoću prilagođenog konstruktora
                 */
                Brkovi brk = new Brkovi(txtPodatak1.Text, txtPodatak2.Text,
                    Convert.ToInt32(txtPodatak3.Text),
                    Convert.ToString(cmbPodatak4.Text));
                /*
                 * dodavanje objekta u listu
                 */
                lista.Add(brk);
                
                /*
                 * brisanje podataka u formi 
                 * nakon upisa podataka
                 */
                txtPodatak1.Clear();
                txtPodatak2.Clear();
                txtPodatak3.Clear();
            }
            catch (Exception greska)
            {
                /*
                 * ispis poruke prilikom pogrešnog unosa
                 */
                MessageBox.Show("Pogrešan unos!\r\n"+greska.Message, 
                    "Greška", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            
        }
        /// <summary>
        /// metoda koja se izvršava klikom na gumb "Ispiši"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIspis_Click(object sender, EventArgs e)
        {
            // Ispis zaglavlja
            rtxtIspis.Text = "Podatak 1" + "\tPodatak 2"
                + "\tPodatak 3" + "\tPodatak 4"+"\tDodatak\r\n";
            
            /*
             * foreach petlja koja 
             * za svaki objekt 'brk' klase 'Brkovi' iz liste
             * dodaje u richTextBox ispis iz metode ToString()
             * objekta 'brk'
             * (metoda je definirana u klasi 'Brkovi')
             */
            foreach (Brkovi brk in lista)
            {
                rtxtIspis.AppendText(brk.ToString());
            }
        }
        /// <summary>
        /// metoda koja se izvršava klikom na gumb "Obradi"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRazvrstaj_Click(object sender, EventArgs e)
        {
            /*
             * foreach petlja koja 
             * za svaki objekt 'brk' klase 'Brkovi' iz liste
             * provjerava pomoću getter metode da li je 
             * varijabla pod4 jednaka "M" te sukladno rezultatu
             * postavlja varijablu dodatak pomoću setter metode
             */
            foreach (Brkovi brk in lista)
            {
                if (brk.Pod4 == "M")
                {
                    brk.Dodatak = "Ima brkove.";
                }
                else
                { 
                    brk.Dodatak = "Nema brkove";
                }
            }
        }
    }
}
