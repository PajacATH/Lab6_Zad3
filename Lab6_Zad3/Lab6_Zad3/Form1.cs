using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Zad3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double predkosc = 0;
        double prCount = 0;
        double km = 0;
        double paliwo = 60;
        double spalanie = 0;
        DateTime dt;
        
        #region Labels
        private void lblPaliwo_Click(object sender, EventArgs e)
        {

        }

        private void lblKm_Click(object sender, EventArgs e)
        {

        }
        private void lblPredkosc_Click(object sender, EventArgs e)
        {

        }
        private void lblSpalanie_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Buttons
        private void btnGaz_Click(object sender, EventArgs e)
        {
            predkosc += 5;
            lblPredkosc.Text = predkosc.ToString() + "Km/h";
            prCount += predkosc;
        }

        private void btnHamulec_Click(object sender, EventArgs e)
        {
            predkosc -= 5;
            lblPredkosc.Text = predkosc.ToString() + "Km/h";
            prCount -= predkosc;
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            lblKm.Visible = true;
            lblPaliwo.Visible = true;
            lblPredkosc.Visible = true;
            btnGaz.Visible = true;
            btnHamulec.Visible = true;
            btnRun.Visible = false;
            btnStop.Visible = true;
            timer1.Enabled = true;
            tbSpalanie.Visible = false;
            lblSpalanie.Visible = false;
            lblWybierzSpalanie.Visible = false;
            predkosc = 15;
            spalanie = tbSpalanie.Value;
            dt = DateTime.Now;

            lblKm.Text = km.ToString() + "KM";
            lblPredkosc.Text = predkosc.ToString() + "Km/h";
            lblPaliwo.Text = paliwo.ToString() + "L";

        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            btnRun.Visible = true;
            btnGaz.Visible = false;
            btnHamulec.Visible = false;
            btnStop.Visible = false;
            tbSpalanie.Visible = true;
            lblSpalanie.Visible = true;
            lblWybierzSpalanie.Visible = true;
            timer1.Enabled = false;

            TimeSpan ts = DateTime.Now - dt;
            var czas = Math.Round(ts.TotalSeconds, 2);
            //var srPredkosc = Math.Round(prCount / czas, 2);

            lblPredkosc.Text = predkosc.ToString() + "Km/h";
            MessageBox.Show($"Po upływie {czas} sekund samochód przejechał {Math.Round(km, 2)}KM \nSpalając {Math.Round(60 - paliwo, 2)}L paliwa");
            predkosc = 0;
            km = 0;
            prCount = 0;
            paliwo = 60;

        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            km += predkosc / 36000;
            paliwo -= (spalanie/100) * (predkosc/3600);
            var kilometry = Math.Round(km, 2);
            var paliwko = Math.Round(paliwo, 2);
            lblKm.Text = kilometry.ToString() + "KM";
            lblPaliwo.Text = paliwko.ToString() + "L";
        }
        private void tbSpalanie_Scroll(object sender, EventArgs e)
        {
            lblWybierzSpalanie.Text = $"{tbSpalanie.Value}L na 100KM";
        }
    }
}
