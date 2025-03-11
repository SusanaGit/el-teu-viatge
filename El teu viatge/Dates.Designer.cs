namespace El_teu_viatge
{
    partial class Dates
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dates));
            pictureBoxExit = new PictureBox();
            buttonModifyDades = new Button();
            buttonVeureVols = new Button();
            lblDataTornada = new Label();
            lblDataAnada = new Label();
            monthCalendarDataAnada = new MonthCalendar();
            monthCalendarDataTornada = new MonthCalendar();
            comboBoxTriaAeroportDesti = new ComboBox();
            lblTriaAeroportDesti = new Label();
            comboBoxOnVolsAnar = new ComboBox();
            lblTitolOnVolsAnar = new Label();
            pictureBoxBarraSeparadora = new PictureBox();
            pictureBoxLogo = new PictureBox();
            pictureBoxGifDataAnada = new PictureBox();
            pictureBoxGifDataTornada = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarraSeparadora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGifDataAnada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGifDataTornada).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxExit
            // 
            pictureBoxExit.Image = (Image)resources.GetObject("pictureBoxExit.Image");
            pictureBoxExit.Location = new Point(759, 4);
            pictureBoxExit.Name = "pictureBoxExit";
            pictureBoxExit.Size = new Size(26, 24);
            pictureBoxExit.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExit.TabIndex = 24;
            pictureBoxExit.TabStop = false;
            pictureBoxExit.Click += pictureBoxExit_Click;
            // 
            // buttonModifyDades
            // 
            buttonModifyDades.BackColor = Color.CadetBlue;
            buttonModifyDades.Font = new Font("Gabriola", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonModifyDades.ForeColor = SystemColors.ControlLightLight;
            buttonModifyDades.Location = new Point(117, 509);
            buttonModifyDades.Name = "buttonModifyDades";
            buttonModifyDades.Size = new Size(220, 45);
            buttonModifyDades.TabIndex = 37;
            buttonModifyDades.Tag = "";
            buttonModifyDades.Text = "☜ MODIFICAR DADES";
            buttonModifyDades.UseVisualStyleBackColor = false;
            buttonModifyDades.Click += buttonModifyDades_Click;
            // 
            // buttonVeureVols
            // 
            buttonVeureVols.AccessibleName = "";
            buttonVeureVols.BackColor = Color.CadetBlue;
            buttonVeureVols.Font = new Font("Gabriola", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVeureVols.ForeColor = SystemColors.ControlLightLight;
            buttonVeureVols.Location = new Point(453, 508);
            buttonVeureVols.Name = "buttonVeureVols";
            buttonVeureVols.Size = new Size(220, 45);
            buttonVeureVols.TabIndex = 36;
            buttonVeureVols.Text = "VEURE VOLS ☞";
            buttonVeureVols.UseVisualStyleBackColor = false;
            buttonVeureVols.Click += buttonVeureVols_Click;
            // 
            // lblDataTornada
            // 
            lblDataTornada.AutoSize = true;
            lblDataTornada.BackColor = Color.Transparent;
            lblDataTornada.Font = new Font("Gabriola", 18F);
            lblDataTornada.Image = (Image)resources.GetObject("lblDataTornada.Image");
            lblDataTornada.Location = new Point(428, 251);
            lblDataTornada.Name = "lblDataTornada";
            lblDataTornada.Size = new Size(242, 45);
            lblDataTornada.TabIndex = 39;
            lblDataTornada.Text = "         DATA DE TORNADA       ";
            lblDataTornada.Click += lblDataTornada_Click;
            // 
            // lblDataAnada
            // 
            lblDataAnada.AutoSize = true;
            lblDataAnada.BackColor = Color.Transparent;
            lblDataAnada.Font = new Font("Gabriola", 18F);
            lblDataAnada.Image = (Image)resources.GetObject("lblDataAnada.Image");
            lblDataAnada.Location = new Point(117, 251);
            lblDataAnada.Name = "lblDataAnada";
            lblDataAnada.Size = new Size(241, 45);
            lblDataAnada.TabIndex = 38;
            lblDataAnada.Text = "            DATA D'ANADA            ";
            lblDataAnada.Click += lblDataAnada_Click;
            // 
            // monthCalendarDataAnada
            // 
            monthCalendarDataAnada.Location = new Point(123, 303);
            monthCalendarDataAnada.Name = "monthCalendarDataAnada";
            monthCalendarDataAnada.TabIndex = 40;
            monthCalendarDataAnada.DateChanged += monthCalendarDataAnada_DateChanged;
            monthCalendarDataAnada.MouseLeave += monthCalendarDataAnada_MouseLeave;
            monthCalendarDataAnada.MouseMove += monthCalendarDataAnada_MouseMove;
            // 
            // monthCalendarDataTornada
            // 
            monthCalendarDataTornada.Location = new Point(436, 303);
            monthCalendarDataTornada.Name = "monthCalendarDataTornada";
            monthCalendarDataTornada.TabIndex = 41;
            monthCalendarDataTornada.DateChanged += monthCalendarDataTornada_DateChanged;
            monthCalendarDataTornada.MouseLeave += monthCalendarDataTornada_MouseLeave;
            monthCalendarDataTornada.MouseMove += monthCalendarDataTornada_MouseMove;
            // 
            // comboBoxTriaAeroportDesti
            // 
            comboBoxTriaAeroportDesti.FormattingEnabled = true;
            comboBoxTriaAeroportDesti.Items.AddRange(new object[] { "Madrid (MAD)", "Barcelona (BCN)", "Palma de Mallorca (PMI)", "Màlaga (AGP)", "Alacant (ALC)", "Gran Canària (LPA)", "Tenerife Sud (TFS)", "Sevilla (SVQ)", "València (VLC)", "Bilbao (BIO)", "París (CDG) - Charles de Gaulle", "Londres (LHR) - Heathrow", "Frankfurt (FRA)", "Amsterdam (AMS)", "Roma (FCO) - Fiumicino", "Berlín (BER) - Brandenburg", "Lisboa (LIS)", "Viena (VIE)", "Zurich (ZRH)", "Oslo (OSL)" });
            comboBoxTriaAeroportDesti.Location = new Point(434, 122);
            comboBoxTriaAeroportDesti.Name = "comboBoxTriaAeroportDesti";
            comboBoxTriaAeroportDesti.Size = new Size(241, 37);
            comboBoxTriaAeroportDesti.TabIndex = 46;
            comboBoxTriaAeroportDesti.SelectedIndexChanged += comboBoxTriaAeroportDesti_SelectedIndexChanged;
            // 
            // lblTriaAeroportDesti
            // 
            lblTriaAeroportDesti.AutoSize = true;
            lblTriaAeroportDesti.BackColor = Color.Transparent;
            lblTriaAeroportDesti.Font = new Font("Gabriola", 18F);
            lblTriaAeroportDesti.Image = (Image)resources.GetObject("lblTriaAeroportDesti.Image");
            lblTriaAeroportDesti.Location = new Point(432, 71);
            lblTriaAeroportDesti.Name = "lblTriaAeroportDesti";
            lblTriaAeroportDesti.Size = new Size(241, 45);
            lblTriaAeroportDesti.TabIndex = 45;
            lblTriaAeroportDesti.Text = "       AEROPORT DE DESTÍ       ";
            lblTriaAeroportDesti.Click += lblTriaAeroportDesti_Click;
            // 
            // comboBoxOnVolsAnar
            // 
            comboBoxOnVolsAnar.FormattingEnabled = true;
            comboBoxOnVolsAnar.Items.AddRange(new object[] { "Barcelona (Espanya)", "Madrid (Espanya)", "París (França)", "Londres (Regne Unit)", "Berlín (Alemanya)", "Roma (Itàlia)", "Viena (Àustria)", "Praga (República Txeca)", "Lisboa (Portugal)", "Amsterdam (Països Baixos)", "Brussel·les (Bèlgica)", "Budapest (Hongria)", "Estocolm (Suècia)", "Oslo (Noruega)", "Copenhaguen (Dinamarca)", "Atenes (Grècia)", "Varsòvia (Polònia)", "Dublín (Irlanda)", "Sant Petersburg (Rússia)", "Edimburg (Escòcia)", "Zúrich (Suïssa)", "Helsinki (Finlàndia)", "València (Espanya)", "Sevilla (Espanya)", "Munic (Alemanya)", "Milà (Itàlia)", "Florencia (Itàlia)", "Venècia (Itàlia)", "Nàpols (Itàlia)", "Krakòvia (Polònia)" });
            comboBoxOnVolsAnar.Location = new Point(117, 122);
            comboBoxOnVolsAnar.Name = "comboBoxOnVolsAnar";
            comboBoxOnVolsAnar.Size = new Size(241, 37);
            comboBoxOnVolsAnar.TabIndex = 44;
            comboBoxOnVolsAnar.SelectedIndexChanged += comboBoxOnVolsAnar_SelectedIndexChanged;
            // 
            // lblTitolOnVolsAnar
            // 
            lblTitolOnVolsAnar.AutoSize = true;
            lblTitolOnVolsAnar.BackColor = Color.Transparent;
            lblTitolOnVolsAnar.Font = new Font("Gabriola", 18F);
            lblTitolOnVolsAnar.Image = (Image)resources.GetObject("lblTitolOnVolsAnar.Image");
            lblTitolOnVolsAnar.Location = new Point(117, 71);
            lblTitolOnVolsAnar.Name = "lblTitolOnVolsAnar";
            lblTitolOnVolsAnar.Size = new Size(241, 45);
            lblTitolOnVolsAnar.TabIndex = 43;
            lblTitolOnVolsAnar.Text = "           ON VOLS ANAR ?          ";
            lblTitolOnVolsAnar.Click += lblTitolOnVolsAnar_Click;
            // 
            // pictureBoxBarraSeparadora
            // 
            pictureBoxBarraSeparadora.BackColor = Color.Transparent;
            pictureBoxBarraSeparadora.Image = (Image)resources.GetObject("pictureBoxBarraSeparadora.Image");
            pictureBoxBarraSeparadora.Location = new Point(81, 180);
            pictureBoxBarraSeparadora.Name = "pictureBoxBarraSeparadora";
            pictureBoxBarraSeparadora.Size = new Size(632, 54);
            pictureBoxBarraSeparadora.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBarraSeparadora.TabIndex = 47;
            pictureBoxBarraSeparadora.TabStop = false;
            pictureBoxBarraSeparadora.Click += pictureBoxBarraSeparadora_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(338, 3);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(116, 56);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 50;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Click += pictureBoxLogo_Click;
            // 
            // pictureBoxGifDataAnada
            // 
            pictureBoxGifDataAnada.BackColor = Color.Transparent;
            pictureBoxGifDataAnada.Image = (Image)resources.GetObject("pictureBoxGifDataAnada.Image");
            pictureBoxGifDataAnada.Location = new Point(19, 353);
            pictureBoxGifDataAnada.Name = "pictureBoxGifDataAnada";
            pictureBoxGifDataAnada.Size = new Size(103, 93);
            pictureBoxGifDataAnada.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGifDataAnada.TabIndex = 51;
            pictureBoxGifDataAnada.TabStop = false;
            pictureBoxGifDataAnada.Visible = false;
            pictureBoxGifDataAnada.Click += pictureBoxGifDataAnada_Click;
            // 
            // pictureBoxGifDataTornada
            // 
            pictureBoxGifDataTornada.BackColor = Color.Transparent;
            pictureBoxGifDataTornada.Image = (Image)resources.GetObject("pictureBoxGifDataTornada.Image");
            pictureBoxGifDataTornada.Location = new Point(664, 353);
            pictureBoxGifDataTornada.Name = "pictureBoxGifDataTornada";
            pictureBoxGifDataTornada.Size = new Size(103, 93);
            pictureBoxGifDataTornada.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGifDataTornada.TabIndex = 52;
            pictureBoxGifDataTornada.TabStop = false;
            pictureBoxGifDataTornada.Visible = false;
            pictureBoxGifDataTornada.Click += pictureBoxGifDataTornada_Click;
            // 
            // Dates
            // 
            AutoScaleDimensions = new SizeF(7F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(790, 560);
            Controls.Add(pictureBoxGifDataTornada);
            Controls.Add(pictureBoxGifDataAnada);
            Controls.Add(pictureBoxLogo);
            Controls.Add(pictureBoxBarraSeparadora);
            Controls.Add(comboBoxTriaAeroportDesti);
            Controls.Add(lblTriaAeroportDesti);
            Controls.Add(comboBoxOnVolsAnar);
            Controls.Add(lblTitolOnVolsAnar);
            Controls.Add(monthCalendarDataTornada);
            Controls.Add(monthCalendarDataAnada);
            Controls.Add(lblDataTornada);
            Controls.Add(lblDataAnada);
            Controls.Add(buttonModifyDades);
            Controls.Add(buttonVeureVols);
            Controls.Add(pictureBoxExit);
            DoubleBuffered = true;
            Font = new Font("Gabriola", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 5, 3, 5);
            Name = "Dates";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dates";
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBarraSeparadora).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGifDataAnada).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGifDataTornada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxExit;
        private Button buttonModifyDades;
        private Button buttonVeureVols;
        private Label lblDataTornada;
        private Label lblDataAnada;
        private MonthCalendar monthCalendarDataAnada;
        private MonthCalendar monthCalendarDataTornada;
        private ComboBox comboBoxTriaAeroportDesti;
        private Label lblTriaAeroportDesti;
        private ComboBox comboBoxOnVolsAnar;
        private Label lblTitolOnVolsAnar;
        private PictureBox pictureBoxBarraSeparadora;
        private PictureBox pictureBoxLogo;
        private PictureBox pictureBoxGifDataAnada;
        private PictureBox pictureBoxGifDataTornada;
    }
}