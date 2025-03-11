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
    public partial class Vols : Form
    {
        public Vols()
        {
            InitializeComponent();
        }

        // Logo
        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        // Títol vols anada
        private void labelVolsAnada_Click(object sender, EventArgs e)
        {

        }

        // Taula vols anada 
        private void dataGridViewVolsAnada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Títol vols tornada
        private void labelVolsTornada_Click(object sender, EventArgs e)
        {

        }

        // Taula vols tornada
        private void dataGridViewVolsTornada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Button per guardar les dates i veure el formulari Hotels.cs
        private void buttonVeureHotels_Click(object sender, EventArgs e)
        {
            Form formulari = new Hotels();
            formulari.Show();
        }

        // Button per poder anar al formulari Dates.cs
        private void buttonModifyDates_Click(object sender, EventArgs e)
        {
            Form formulari = new Dates();
            formulari.Show();
        }

        // Imatge x exit
        private void pictureBoxExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
