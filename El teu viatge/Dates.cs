using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_teu_viatge
{
    public partial class Dates : Form
    {
        public Dates()
        {
            InitializeComponent();

        }

        // Logo
        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        // On vols anar
        private void lblTitolOnVolsAnar_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxOnVolsAnar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Aeroport destí
        private void lblTriaAeroportDesti_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTriaAeroportDesti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Barra separadora
        private void pictureBoxBarraSeparadora_Click(object sender, EventArgs e)
        {

        }

        // Títol data d'anada 
        private void lblDataAnada_Click(object sender, EventArgs e)
        {

        }

        // Calendari data d'anada
        private void monthCalendarDataAnada_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        // Títol data de tornada
        private void lblDataTornada_Click(object sender, EventArgs e)
        {

        }

        // Calendari data de tornada
        private void monthCalendarDataTornada_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        // Button per retornar al formulari DadesPersonals.cs
        private void buttonModifyDades_Click(object sender, EventArgs e)
        {
            Form formulari = new DadesPersonals();
            formulari.Show();
        }

        // Button per guardar les dates i anar al formulari Vols.cs
        private void buttonVeureVols_Click(object sender, EventArgs e)
        {
            Form formulari = new Vols();
            formulari.Show();
        }

        // Imatge x exit
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Gif ratolí data anada
        private void pictureBoxGifDataAnada_Click(object sender, EventArgs e)
        {

        }

        // Gif ratolí data tornada
        private void pictureBoxGifDataTornada_Click(object sender, EventArgs e)
        {

        }

        // EVENTS

        // quan allunyo el cursor del calendari anada la imatge pictureBoxGifDataAnada desapareix
        private void monthCalendarDataAnada_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxGifDataAnada.Visible = false;
        }

        // quan apropo el cursor al calendari anada la imatge pictureBoxGifDataAnada apareix
        private void monthCalendarDataAnada_MouseMove(object sender, MouseEventArgs e)
        {
            this.pictureBoxGifDataAnada.Visible = true;
        }

        // quan allunyo el cursor del calendari tornada la imatge pictureBoxGifDataTornada desapareix
        private void monthCalendarDataTornada_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxGifDataTornada.Visible = false;
        }

        // quan apropo el cursor al calendari tornada la imatge pictureBoxGifDataTornada apareix
        private void monthCalendarDataTornada_MouseMove(object sender, MouseEventArgs e)
        {
            this.pictureBoxGifDataTornada.Visible = true;
        }
    }
}
