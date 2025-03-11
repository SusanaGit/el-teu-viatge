namespace El_teu_viatge
{
    partial class Hotels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hotels));
            pictureBoxExit = new PictureBox();
            lblHotelsTrobats = new Label();
            dataGridViewHotels = new DataGridView();
            Nom = new DataGridViewTextBoxColumn();
            DescripcioHotel = new DataGridViewTextBoxColumn();
            PreuNit = new DataGridViewTextBoxColumn();
            PreuMitjaPensio = new DataGridViewTextBoxColumn();
            PreuPensioCompleta = new DataGridViewTextBoxColumn();
            Puntuacio = new DataGridViewTextBoxColumn();
            buttonModifyVols = new Button();
            buttonVeureReserva = new Button();
            labelPreuTotalHotel = new Label();
            dataGridViewPreuTotalHotel = new DataGridView();
            HotelTriat = new DataGridViewTextBoxColumn();
            PreuDiaHotel = new DataGridViewTextBoxColumn();
            QuantitatDiesHotel = new DataGridViewTextBoxColumn();
            PreuTotalHotelTriat = new DataGridViewTextBoxColumn();
            pictureBoxLogo = new PictureBox();
            checkBoxNomesNit = new CheckBox();
            checkBoxMitjaPensio = new CheckBox();
            checkBoxPensioCompleta = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHotels).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPreuTotalHotel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxExit
            // 
            pictureBoxExit.BackColor = Color.Transparent;
            pictureBoxExit.Image = (Image)resources.GetObject("pictureBoxExit.Image");
            pictureBoxExit.Location = new Point(760, 4);
            pictureBoxExit.Name = "pictureBoxExit";
            pictureBoxExit.Size = new Size(26, 24);
            pictureBoxExit.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExit.TabIndex = 25;
            pictureBoxExit.TabStop = false;
            pictureBoxExit.Click += pictureBoxExit_Click;
            // 
            // lblHotelsTrobats
            // 
            lblHotelsTrobats.AutoSize = true;
            lblHotelsTrobats.BackColor = Color.Transparent;
            lblHotelsTrobats.Font = new Font("Gabriola", 18F);
            lblHotelsTrobats.Image = (Image)resources.GetObject("lblHotelsTrobats.Image");
            lblHotelsTrobats.Location = new Point(274, 71);
            lblHotelsTrobats.Name = "lblHotelsTrobats";
            lblHotelsTrobats.Size = new Size(236, 45);
            lblHotelsTrobats.TabIndex = 40;
            lblHotelsTrobats.Text = "                   HOTELS                   ";
            lblHotelsTrobats.Click += lblHotelsTrobats_Click;
            // 
            // dataGridViewHotels
            // 
            dataGridViewHotels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHotels.Columns.AddRange(new DataGridViewColumn[] { Nom, DescripcioHotel, PreuNit, PreuMitjaPensio, PreuPensioCompleta, Puntuacio });
            dataGridViewHotels.Location = new Point(23, 121);
            dataGridViewHotels.Name = "dataGridViewHotels";
            dataGridViewHotels.Size = new Size(743, 131);
            dataGridViewHotels.TabIndex = 41;
            dataGridViewHotels.CellContentClick += dataGridViewHotels_CellContentClick;
            // 
            // Nom
            // 
            Nom.HeaderText = "Nom";
            Nom.Name = "Nom";
            // 
            // DescripcioHotel
            // 
            DescripcioHotel.HeaderText = "Descripció ";
            DescripcioHotel.Name = "DescripcioHotel";
            DescripcioHotel.Width = 200;
            // 
            // PreuNit
            // 
            PreuNit.HeaderText = "Preu Nit";
            PreuNit.Name = "PreuNit";
            // 
            // PreuMitjaPensio
            // 
            PreuMitjaPensio.HeaderText = "Mitja Pensió";
            PreuMitjaPensio.Name = "PreuMitjaPensio";
            // 
            // PreuPensioCompleta
            // 
            PreuPensioCompleta.HeaderText = "Pensió Completa";
            PreuPensioCompleta.Name = "PreuPensioCompleta";
            // 
            // Puntuacio
            // 
            Puntuacio.HeaderText = "Puntuació";
            Puntuacio.Name = "Puntuacio";
            // 
            // buttonModifyVols
            // 
            buttonModifyVols.BackColor = Color.CadetBlue;
            buttonModifyVols.Font = new Font("Gabriola", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonModifyVols.ForeColor = SystemColors.ControlLightLight;
            buttonModifyVols.Location = new Point(117, 509);
            buttonModifyVols.Name = "buttonModifyVols";
            buttonModifyVols.Size = new Size(220, 45);
            buttonModifyVols.TabIndex = 43;
            buttonModifyVols.Tag = "";
            buttonModifyVols.Text = "☜ VOLS";
            buttonModifyVols.UseVisualStyleBackColor = false;
            buttonModifyVols.Click += buttonModifyVols_Click;
            // 
            // buttonVeureReserva
            // 
            buttonVeureReserva.AccessibleName = "";
            buttonVeureReserva.BackColor = Color.CadetBlue;
            buttonVeureReserva.Font = new Font("Gabriola", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVeureReserva.ForeColor = SystemColors.ControlLightLight;
            buttonVeureReserva.Location = new Point(453, 509);
            buttonVeureReserva.Name = "buttonVeureReserva";
            buttonVeureReserva.Size = new Size(220, 45);
            buttonVeureReserva.TabIndex = 42;
            buttonVeureReserva.Text = "VEURE RESERVA ☞";
            buttonVeureReserva.UseVisualStyleBackColor = false;
            buttonVeureReserva.Click += buttonVeureReserva_Click;
            // 
            // labelPreuTotalHotel
            // 
            labelPreuTotalHotel.AutoSize = true;
            labelPreuTotalHotel.BackColor = Color.Transparent;
            labelPreuTotalHotel.Font = new Font("Gabriola", 18F);
            labelPreuTotalHotel.Image = (Image)resources.GetObject("labelPreuTotalHotel.Image");
            labelPreuTotalHotel.Location = new Point(274, 364);
            labelPreuTotalHotel.Name = "labelPreuTotalHotel";
            labelPreuTotalHotel.Size = new Size(232, 45);
            labelPreuTotalHotel.TabIndex = 44;
            labelPreuTotalHotel.Text = "       PREU TOTAL HOTEL      ";
            labelPreuTotalHotel.Click += labelPreuTotalHotel_Click;
            // 
            // dataGridViewPreuTotalHotel
            // 
            dataGridViewPreuTotalHotel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPreuTotalHotel.Columns.AddRange(new DataGridViewColumn[] { HotelTriat, PreuDiaHotel, QuantitatDiesHotel, PreuTotalHotelTriat });
            dataGridViewPreuTotalHotel.Location = new Point(132, 414);
            dataGridViewPreuTotalHotel.Name = "dataGridViewPreuTotalHotel";
            dataGridViewPreuTotalHotel.Size = new Size(523, 64);
            dataGridViewPreuTotalHotel.TabIndex = 46;
            dataGridViewPreuTotalHotel.CellContentClick += dataGridViewPreuTotalHotel_CellContentClick;
            // 
            // HotelTriat
            // 
            HotelTriat.HeaderText = "Hotel Triat";
            HotelTriat.Name = "HotelTriat";
            HotelTriat.Width = 120;
            // 
            // PreuDiaHotel
            // 
            PreuDiaHotel.HeaderText = "Preu Dia";
            PreuDiaHotel.Name = "PreuDiaHotel";
            PreuDiaHotel.Width = 120;
            // 
            // QuantitatDiesHotel
            // 
            QuantitatDiesHotel.HeaderText = "Quantitat Dies";
            QuantitatDiesHotel.Name = "QuantitatDiesHotel";
            QuantitatDiesHotel.Width = 120;
            // 
            // PreuTotalHotelTriat
            // 
            PreuTotalHotelTriat.HeaderText = "Preu Total";
            PreuTotalHotelTriat.Name = "PreuTotalHotelTriat";
            PreuTotalHotelTriat.Width = 120;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(338, 2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(116, 56);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 49;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Click += pictureBoxLogo_Click;
            // 
            // checkBoxNomesNit
            // 
            checkBoxNomesNit.Appearance = Appearance.Button;
            checkBoxNomesNit.AutoSize = true;
            checkBoxNomesNit.BackColor = Color.Bisque;
            checkBoxNomesNit.Font = new Font("Gabriola", 16F);
            checkBoxNomesNit.Location = new Point(213, 286);
            checkBoxNomesNit.Name = "checkBoxNomesNit";
            checkBoxNomesNit.Size = new Size(99, 50);
            checkBoxNomesNit.TabIndex = 52;
            checkBoxNomesNit.Text = "Només Nit";
            checkBoxNomesNit.UseVisualStyleBackColor = false;
            checkBoxNomesNit.CheckedChanged += checkBoxNomesNit_CheckedChanged;
            // 
            // checkBoxMitjaPensio
            // 
            checkBoxMitjaPensio.Appearance = Appearance.Button;
            checkBoxMitjaPensio.AutoSize = true;
            checkBoxMitjaPensio.BackColor = Color.Bisque;
            checkBoxMitjaPensio.Font = new Font("Gabriola", 16F);
            checkBoxMitjaPensio.Location = new Point(341, 286);
            checkBoxMitjaPensio.Name = "checkBoxMitjaPensio";
            checkBoxMitjaPensio.Size = new Size(108, 50);
            checkBoxMitjaPensio.TabIndex = 53;
            checkBoxMitjaPensio.Text = "Mitja Pensió";
            checkBoxMitjaPensio.UseVisualStyleBackColor = false;
            checkBoxMitjaPensio.CheckedChanged += checkBoxMitjaPensio_CheckedChanged;
            // 
            // checkBoxPensioCompleta
            // 
            checkBoxPensioCompleta.Appearance = Appearance.Button;
            checkBoxPensioCompleta.AutoSize = true;
            checkBoxPensioCompleta.BackColor = Color.Bisque;
            checkBoxPensioCompleta.Font = new Font("Gabriola", 16F);
            checkBoxPensioCompleta.Location = new Point(479, 286);
            checkBoxPensioCompleta.Name = "checkBoxPensioCompleta";
            checkBoxPensioCompleta.Size = new Size(139, 50);
            checkBoxPensioCompleta.TabIndex = 54;
            checkBoxPensioCompleta.Text = "Pensió Completa";
            checkBoxPensioCompleta.UseVisualStyleBackColor = false;
            checkBoxPensioCompleta.CheckedChanged += checkBoxPensioCompleta_CheckedChanged;
            // 
            // Hotels
            // 
            AutoScaleDimensions = new SizeF(7F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(790, 560);
            Controls.Add(checkBoxPensioCompleta);
            Controls.Add(checkBoxMitjaPensio);
            Controls.Add(checkBoxNomesNit);
            Controls.Add(pictureBoxLogo);
            Controls.Add(dataGridViewPreuTotalHotel);
            Controls.Add(labelPreuTotalHotel);
            Controls.Add(buttonModifyVols);
            Controls.Add(buttonVeureReserva);
            Controls.Add(dataGridViewHotels);
            Controls.Add(lblHotelsTrobats);
            Controls.Add(pictureBoxExit);
            DoubleBuffered = true;
            Font = new Font("Gabriola", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 6, 3, 6);
            Name = "Hotels";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotels";
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHotels).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPreuTotalHotel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxExit;
        private Label lblHotelsTrobats;
        private DataGridView dataGridViewHotels;
        private Button buttonModifyVols;
        private Button buttonVeureReserva;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn DescripcioHotel;
        private DataGridViewTextBoxColumn PreuNit;
        private DataGridViewTextBoxColumn PreuMitjaPensio;
        private DataGridViewTextBoxColumn PreuPensioCompleta;
        private DataGridViewTextBoxColumn Puntuacio;
        private Label labelPreuTotalHotel;
        private DataGridView dataGridViewPreuTotalHotel;
        private DataGridViewTextBoxColumn HotelTriat;
        private DataGridViewTextBoxColumn PreuDiaHotel;
        private DataGridViewTextBoxColumn QuantitatDiesHotel;
        private DataGridViewTextBoxColumn PreuTotalHotelTriat;
        private PictureBox pictureBoxLogo;
        private CheckBox checkBoxNomesNit;
        private CheckBox checkBoxMitjaPensio;
        private CheckBox checkBoxPensioCompleta;
    }
}