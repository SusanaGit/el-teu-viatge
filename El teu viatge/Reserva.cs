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
    public partial class Reserva : Form
    {
        public Reserva()
        {
            InitializeComponent();
        }

        // Logo
        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        // Label títol vol anada triat
        private void labelReservaVolAnada_Click(object sender, EventArgs e)
        {

        }

        // DataGridView per mostrar les dades del vol d'anada triat
        private void dataGridViewReservaVolAnada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Label títol vol tornada triat
        private void labelReservaVolTornada_Click(object sender, EventArgs e)
        {

        }

        // DataGridView per mostrar les dades del vol de tornada triat
        private void dataGridViewReservaVolTornada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Label títol hotel triat
        private void labelReservaHotel_Click(object sender, EventArgs e)
        {

        }

        // DataGridView per mostrar les dades de l'hotel triat
        private void dataGridViewReservaHotel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Button per tornar al formulari Hotels.cs
        private void buttonTornarHotels_Click(object sender, EventArgs e)
        {
            Form formulari = new Hotels();
            formulari.Show();
        }

        // Button per anar al formulari Confirmacio.cs
        private void buttonFinalitzarReserva_Click(object sender, EventArgs e)
        {
            Form formulari = new Confirmacio();
            formulari.Show();
        }

        // PictureBox per tancar el formulari Reserva.cs
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
