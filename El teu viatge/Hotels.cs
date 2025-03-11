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
    public partial class Hotels : Form
    {
        public Hotels()
        {
            InitializeComponent();
        }

        // Logo
        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        // Títol hotels
        private void lblHotelsTrobats_Click(object sender, EventArgs e)
        {

        }

        // Graella que mostra els hotels disponibles
        private void dataGridViewHotels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Títol preu total hotel triat
        private void labelPreuTotalHotel_Click(object sender, EventArgs e)
        {

        }

        // Graella preu total hotel
        private void dataGridViewPreuTotalHotel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // CheckBox només nit
        private void checkBoxNomesNit_CheckedChanged(object sender, EventArgs e)
        {

        }

        // CheckBox mitja pensió
        private void checkBoxMitjaPensio_CheckedChanged(object sender, EventArgs e)
        {

        }

        // CheckBox pensió completa
        private void checkBoxPensioCompleta_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Button tornar al formulari Vols.cs
        private void buttonModifyVols_Click(object sender, EventArgs e)
        {
            Form formulari = new Vols();
            formulari.Show();
        }

        // Button anar al formulari Reserva.cs
        private void buttonVeureReserva_Click(object sender, EventArgs e)
        {
            Form formulari = new Reserva();
            formulari.Show();
        }

        // Imatge x exit
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
