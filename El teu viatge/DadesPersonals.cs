namespace El_teu_viatge
{
    public partial class DadesPersonals : Form
    {
        public DadesPersonals()
        {
            InitializeComponent();
        }

        // Logo
        private void pictureBoxLogoDadesPersonals_Click(object sender, EventArgs e)
        {

        }

        // Títol dades personals
        private void lblTitolDadesPersonals_Click(object sender, EventArgs e)
        {

        }

        // Nom viatger
        private void lblNomViatger_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNomViatger_TextChanged(object sender, EventArgs e)
        {

        }

        // Cognoms viatger
        private void lblCognomsViatger_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCognomsViatger_TextChanged(object sender, EventArgs e)
        {

        }

        // NIF
        private void lblNIF_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNIF_TextChanged(object sender, EventArgs e)
        {

        }

        // Mail
        private void lblMail_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {

        }

        // Telèfon
        private void lblTelefon_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        // Aeroport orígen
        private void lblAeroportOrigen_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxAeroportOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Button seleccionar dates
        private void buttonSeleccionarDates_Click(object sender, EventArgs e)
        {
            Form formulari = new Dates();
            formulari.Show();
        }

        // Imatge x exit
        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // EVENTS
        // Event MouseEnter
        private void buttonSeleccionarDates_MouseEnter(object sender, EventArgs e)
        {
            this.buttonSeleccionarDates.Text = "SOM'HI!";
        }

        private void buttonSeleccionarDates_MouseLeave(object sender, EventArgs e)
        {
            this.buttonSeleccionarDates.Text = "SELECCIONAR DATES ☞";
        }
    }
}
