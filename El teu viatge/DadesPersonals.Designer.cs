namespace El_teu_viatge
{
    partial class DadesPersonals
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DadesPersonals));
            pictureBoxLogoDadesPersonals = new PictureBox();
            lblTitolDadesPersonals = new Label();
            lblNomViatger = new Label();
            lblCognomsViatger = new Label();
            lblNIF = new Label();
            lblMail = new Label();
            lblAeroportOrigen = new Label();
            lblTelefon = new Label();
            textBoxNomViatger = new TextBox();
            textBoxCognomsViatger = new TextBox();
            textBoxNIF = new TextBox();
            textBoxMail = new TextBox();
            textBoxTelefon = new TextBox();
            comboBoxAeroportOrigen = new ComboBox();
            buttonSeleccionarDates = new Button();
            pictureBoxExit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoDadesPersonals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogoDadesPersonals
            // 
            pictureBoxLogoDadesPersonals.BackColor = Color.Transparent;
            pictureBoxLogoDadesPersonals.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogoDadesPersonals.Image = (Image)resources.GetObject("pictureBoxLogoDadesPersonals.Image");
            pictureBoxLogoDadesPersonals.Location = new Point(22, 17);
            pictureBoxLogoDadesPersonals.Name = "pictureBoxLogoDadesPersonals";
            pictureBoxLogoDadesPersonals.Size = new Size(226, 203);
            pictureBoxLogoDadesPersonals.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogoDadesPersonals.TabIndex = 0;
            pictureBoxLogoDadesPersonals.TabStop = false;
            pictureBoxLogoDadesPersonals.Click += pictureBoxLogoDadesPersonals_Click;
            // 
            // lblTitolDadesPersonals
            // 
            lblTitolDadesPersonals.AutoSize = true;
            lblTitolDadesPersonals.BackColor = Color.Transparent;
            lblTitolDadesPersonals.Font = new Font("Gabriola", 18F);
            lblTitolDadesPersonals.Image = (Image)resources.GetObject("lblTitolDadesPersonals.Image");
            lblTitolDadesPersonals.Location = new Point(390, 66);
            lblTitolDadesPersonals.Name = "lblTitolDadesPersonals";
            lblTitolDadesPersonals.Size = new Size(239, 45);
            lblTitolDadesPersonals.TabIndex = 2;
            lblTitolDadesPersonals.Text = "        DADES PERSONALS        ";
            lblTitolDadesPersonals.Click += lblTitolDadesPersonals_Click;
            // 
            // lblNomViatger
            // 
            lblNomViatger.AutoSize = true;
            lblNomViatger.BackColor = Color.Transparent;
            lblNomViatger.Font = new Font("Gabriola", 16F);
            lblNomViatger.Location = new Point(254, 128);
            lblNomViatger.Name = "lblNomViatger";
            lblNomViatger.Size = new Size(150, 40);
            lblNomViatger.TabIndex = 4;
            lblNomViatger.Text = "✐ Nom viatger/a :";
            lblNomViatger.Click += lblNomViatger_Click;
            // 
            // lblCognomsViatger
            // 
            lblCognomsViatger.AutoSize = true;
            lblCognomsViatger.BackColor = Color.Transparent;
            lblCognomsViatger.Font = new Font("Gabriola", 16F);
            lblCognomsViatger.Location = new Point(254, 180);
            lblCognomsViatger.Name = "lblCognomsViatger";
            lblCognomsViatger.Size = new Size(180, 40);
            lblCognomsViatger.TabIndex = 5;
            lblCognomsViatger.Text = "✐ Cognoms viatger/a :";
            lblCognomsViatger.Click += lblCognomsViatger_Click;
            // 
            // lblNIF
            // 
            lblNIF.AutoSize = true;
            lblNIF.BackColor = Color.Transparent;
            lblNIF.Font = new Font("Gabriola", 16F);
            lblNIF.Location = new Point(22, 268);
            lblNIF.Name = "lblNIF";
            lblNIF.Size = new Size(79, 40);
            lblNIF.TabIndex = 6;
            lblNIF.Text = "✐ NIF :";
            lblNIF.Click += lblNIF_Click;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.BackColor = Color.Transparent;
            lblMail.Font = new Font("Gabriola", 16F);
            lblMail.Location = new Point(24, 319);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(83, 40);
            lblMail.TabIndex = 7;
            lblMail.Text = "✐ Mail :";
            lblMail.Click += lblMail_Click;
            // 
            // lblAeroportOrigen
            // 
            lblAeroportOrigen.AutoSize = true;
            lblAeroportOrigen.BackColor = Color.Transparent;
            lblAeroportOrigen.Font = new Font("Gabriola", 18F);
            lblAeroportOrigen.Location = new Point(24, 415);
            lblAeroportOrigen.Name = "lblAeroportOrigen";
            lblAeroportOrigen.Size = new Size(177, 45);
            lblAeroportOrigen.TabIndex = 10;
            lblAeroportOrigen.Text = "✐ Aeroport orígen :";
            lblAeroportOrigen.Click += lblAeroportOrigen_Click;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.BackColor = Color.Transparent;
            lblTelefon.Font = new Font("Gabriola", 16F);
            lblTelefon.Location = new Point(24, 369);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(100, 40);
            lblTelefon.TabIndex = 8;
            lblTelefon.Text = "✐ Telèfon :";
            lblTelefon.Click += lblTelefon_Click;
            // 
            // textBoxNomViatger
            // 
            textBoxNomViatger.Location = new Point(410, 131);
            textBoxNomViatger.Name = "textBoxNomViatger";
            textBoxNomViatger.Size = new Size(352, 35);
            textBoxNomViatger.TabIndex = 11;
            textBoxNomViatger.TextChanged += textBoxNomViatger_TextChanged;
            // 
            // textBoxCognomsViatger
            // 
            textBoxCognomsViatger.Location = new Point(440, 183);
            textBoxCognomsViatger.Name = "textBoxCognomsViatger";
            textBoxCognomsViatger.Size = new Size(322, 35);
            textBoxCognomsViatger.TabIndex = 12;
            textBoxCognomsViatger.TextChanged += textBoxCognomsViatger_TextChanged;
            // 
            // textBoxNIF
            // 
            textBoxNIF.Location = new Point(106, 271);
            textBoxNIF.Name = "textBoxNIF";
            textBoxNIF.Size = new Size(400, 35);
            textBoxNIF.TabIndex = 13;
            textBoxNIF.TextChanged += textBoxNIF_TextChanged;
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(113, 321);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(393, 35);
            textBoxMail.TabIndex = 14;
            textBoxMail.TextChanged += textBoxMail_TextChanged;
            // 
            // textBoxTelefon
            // 
            textBoxTelefon.Location = new Point(128, 372);
            textBoxTelefon.Name = "textBoxTelefon";
            textBoxTelefon.Size = new Size(378, 35);
            textBoxTelefon.TabIndex = 15;
            textBoxTelefon.TextChanged += textBoxTelefon_TextChanged;
            // 
            // comboBoxAeroportOrigen
            // 
            comboBoxAeroportOrigen.FormattingEnabled = true;
            comboBoxAeroportOrigen.Items.AddRange(new object[] { "Madrid (MAD)", "Barcelona (BCN)", "Palma de Mallorca (PMI)", "Màlaga (AGP)", "Alacant (ALC)", "Gran Canària (LPA)", "Tenerife Sud (TFS)", "Sevilla (SVQ)", "València (VLC)", "Bilbao (BIO)", "París (CDG) - Charles de Gaulle", "Londres (LHR) - Heathrow", "Frankfurt (FRA)", "Amsterdam (AMS)", "Roma (FCO) - Fiumicino", "Berlín (BER) - Brandenburg", "Lisboa (LIS)", "Viena (VIE)", "Zurich (ZRH)", "Oslo (OSL)" });
            comboBoxAeroportOrigen.Location = new Point(207, 423);
            comboBoxAeroportOrigen.Name = "comboBoxAeroportOrigen";
            comboBoxAeroportOrigen.Size = new Size(299, 37);
            comboBoxAeroportOrigen.TabIndex = 16;
            comboBoxAeroportOrigen.SelectedIndexChanged += comboBoxAeroportOrigen_SelectedIndexChanged;
            // 
            // buttonSeleccionarDates
            // 
            buttonSeleccionarDates.BackColor = Color.CadetBlue;
            buttonSeleccionarDates.Font = new Font("Gabriola", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSeleccionarDates.ForeColor = SystemColors.ControlLightLight;
            buttonSeleccionarDates.Location = new Point(285, 509);
            buttonSeleccionarDates.Name = "buttonSeleccionarDates";
            buttonSeleccionarDates.Size = new Size(221, 45);
            buttonSeleccionarDates.TabIndex = 22;
            buttonSeleccionarDates.Text = "SELECCIONAR DATES ☞";
            buttonSeleccionarDates.UseVisualStyleBackColor = false;
            buttonSeleccionarDates.Click += buttonSeleccionarDates_Click;
            buttonSeleccionarDates.MouseEnter += buttonSeleccionarDates_MouseEnter;
            buttonSeleccionarDates.MouseLeave += buttonSeleccionarDates_MouseLeave;
            // 
            // pictureBoxExit
            // 
            pictureBoxExit.Image = (Image)resources.GetObject("pictureBoxExit.Image");
            pictureBoxExit.Location = new Point(761, 5);
            pictureBoxExit.Name = "pictureBoxExit";
            pictureBoxExit.Size = new Size(26, 24);
            pictureBoxExit.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExit.TabIndex = 23;
            pictureBoxExit.TabStop = false;
            pictureBoxExit.Click += pictureBoxExit_Click;
            // 
            // DadesPersonals
            // 
            AutoScaleDimensions = new SizeF(7F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(791, 561);
            Controls.Add(pictureBoxExit);
            Controls.Add(buttonSeleccionarDates);
            Controls.Add(comboBoxAeroportOrigen);
            Controls.Add(textBoxTelefon);
            Controls.Add(textBoxMail);
            Controls.Add(textBoxNIF);
            Controls.Add(textBoxCognomsViatger);
            Controls.Add(textBoxNomViatger);
            Controls.Add(lblAeroportOrigen);
            Controls.Add(lblTelefon);
            Controls.Add(lblMail);
            Controls.Add(lblNIF);
            Controls.Add(lblCognomsViatger);
            Controls.Add(lblNomViatger);
            Controls.Add(lblTitolDadesPersonals);
            Controls.Add(pictureBoxLogoDadesPersonals);
            DoubleBuffered = true;
            Font = new Font("Gabriola", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 6, 3, 6);
            Name = "DadesPersonals";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dades Personals";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoDadesPersonals).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogoDadesPersonals;
        private Label lblTitolDadesPersonals;
        private Label lblNomViatger;
        private Label lblCognomsViatger;
        private Label lblNIF;
        private Label lblMail;
        private Label lblAeroportOrigen;
        private Label lblTelefon;
        private TextBox textBoxNomViatger;
        private TextBox textBoxCognomsViatger;
        private TextBox textBoxNIF;
        private TextBox textBoxMail;
        private TextBox textBoxTelefon;
        private ComboBox comboBoxAeroportOrigen;
        private Button buttonSeleccionarDates;
        private PictureBox pictureBoxExit;
    }
}
