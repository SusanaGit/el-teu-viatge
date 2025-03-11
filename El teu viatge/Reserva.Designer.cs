namespace El_teu_viatge
{
    partial class Reserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reserva));
            pictureBoxLogo = new PictureBox();
            dataGridViewReservaVolAnada = new DataGridView();
            AeroportAnadaSortida = new DataGridViewTextBoxColumn();
            DiaAnadaSortida = new DataGridViewTextBoxColumn();
            HoraAnadaSortida = new DataGridViewTextBoxColumn();
            AeroportAnadaArribada = new DataGridViewTextBoxColumn();
            DiaAnadaArribada = new DataGridViewTextBoxColumn();
            HoraAnadaArribada = new DataGridViewTextBoxColumn();
            PreuAnada = new DataGridViewTextBoxColumn();
            labelReservaVolAnada = new Label();
            dataGridViewReservaVolTornada = new DataGridView();
            AeroportTornadaSortida = new DataGridViewTextBoxColumn();
            diaTornadaSortida = new DataGridViewTextBoxColumn();
            horaTornadaSortida = new DataGridViewTextBoxColumn();
            aeroportTornadaArribada = new DataGridViewTextBoxColumn();
            diaTornadaArribada = new DataGridViewTextBoxColumn();
            horaTornadaArribada = new DataGridViewTextBoxColumn();
            preuTornada = new DataGridViewTextBoxColumn();
            labelReservaVolTornada = new Label();
            dataGridViewReservaHotel = new DataGridView();
            HotelTriat = new DataGridViewTextBoxColumn();
            PreuDiaHotel = new DataGridViewTextBoxColumn();
            QuantitatDiesHotel = new DataGridViewTextBoxColumn();
            PreuTotalHotelTriat = new DataGridViewTextBoxColumn();
            labelReservaHotel = new Label();
            pictureBoxExit = new PictureBox();
            buttonTornarHotels = new Button();
            buttonFinalitzarReserva = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservaVolAnada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservaVolTornada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservaHotel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(337, 2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(116, 56);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 49;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Click += pictureBoxLogo_Click;
            // 
            // dataGridViewReservaVolAnada
            // 
            dataGridViewReservaVolAnada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservaVolAnada.Columns.AddRange(new DataGridViewColumn[] { AeroportAnadaSortida, DiaAnadaSortida, HoraAnadaSortida, AeroportAnadaArribada, DiaAnadaArribada, HoraAnadaArribada, PreuAnada });
            dataGridViewReservaVolAnada.Location = new Point(32, 121);
            dataGridViewReservaVolAnada.Margin = new Padding(4, 6, 4, 6);
            dataGridViewReservaVolAnada.Name = "dataGridViewReservaVolAnada";
            dataGridViewReservaVolAnada.Size = new Size(723, 92);
            dataGridViewReservaVolAnada.TabIndex = 50;
            dataGridViewReservaVolAnada.CellContentClick += dataGridViewReservaVolAnada_CellContentClick;
            // 
            // AeroportAnadaSortida
            // 
            AeroportAnadaSortida.HeaderText = "Aeroport Sortida";
            AeroportAnadaSortida.Name = "AeroportAnadaSortida";
            AeroportAnadaSortida.Width = 140;
            // 
            // DiaAnadaSortida
            // 
            DiaAnadaSortida.HeaderText = "Dia Sortida";
            DiaAnadaSortida.Name = "DiaAnadaSortida";
            DiaAnadaSortida.Width = 80;
            // 
            // HoraAnadaSortida
            // 
            HoraAnadaSortida.HeaderText = "Hora Sortida";
            HoraAnadaSortida.Name = "HoraAnadaSortida";
            HoraAnadaSortida.Width = 80;
            // 
            // AeroportAnadaArribada
            // 
            AeroportAnadaArribada.HeaderText = "Aeroport Arribada";
            AeroportAnadaArribada.Name = "AeroportAnadaArribada";
            AeroportAnadaArribada.Width = 140;
            // 
            // DiaAnadaArribada
            // 
            DiaAnadaArribada.HeaderText = "Dia Arribada";
            DiaAnadaArribada.Name = "DiaAnadaArribada";
            DiaAnadaArribada.Width = 80;
            // 
            // HoraAnadaArribada
            // 
            HoraAnadaArribada.HeaderText = "Hora Arribada";
            HoraAnadaArribada.Name = "HoraAnadaArribada";
            HoraAnadaArribada.Width = 80;
            // 
            // PreuAnada
            // 
            PreuAnada.HeaderText = "Preu";
            PreuAnada.Name = "PreuAnada";
            PreuAnada.Width = 80;
            // 
            // labelReservaVolAnada
            // 
            labelReservaVolAnada.AutoSize = true;
            labelReservaVolAnada.BackColor = Color.Transparent;
            labelReservaVolAnada.Font = new Font("Gabriola", 18F);
            labelReservaVolAnada.Image = (Image)resources.GetObject("labelReservaVolAnada.Image");
            labelReservaVolAnada.Location = new Point(274, 71);
            labelReservaVolAnada.Margin = new Padding(4, 0, 4, 0);
            labelReservaVolAnada.Name = "labelReservaVolAnada";
            labelReservaVolAnada.Size = new Size(236, 45);
            labelReservaVolAnada.TabIndex = 51;
            labelReservaVolAnada.Text = "               VOL ANADA              ";
            labelReservaVolAnada.Click += labelReservaVolAnada_Click;
            // 
            // dataGridViewReservaVolTornada
            // 
            dataGridViewReservaVolTornada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservaVolTornada.Columns.AddRange(new DataGridViewColumn[] { AeroportTornadaSortida, diaTornadaSortida, horaTornadaSortida, aeroportTornadaArribada, diaTornadaArribada, horaTornadaArribada, preuTornada });
            dataGridViewReservaVolTornada.Location = new Point(34, 278);
            dataGridViewReservaVolTornada.Margin = new Padding(4, 6, 4, 6);
            dataGridViewReservaVolTornada.Name = "dataGridViewReservaVolTornada";
            dataGridViewReservaVolTornada.Size = new Size(723, 91);
            dataGridViewReservaVolTornada.TabIndex = 53;
            dataGridViewReservaVolTornada.CellContentClick += dataGridViewReservaVolTornada_CellContentClick;
            // 
            // AeroportTornadaSortida
            // 
            AeroportTornadaSortida.HeaderText = "Aeroport Sortida";
            AeroportTornadaSortida.Name = "AeroportTornadaSortida";
            AeroportTornadaSortida.Width = 140;
            // 
            // diaTornadaSortida
            // 
            diaTornadaSortida.HeaderText = "Dia Sortida";
            diaTornadaSortida.Name = "diaTornadaSortida";
            diaTornadaSortida.Width = 80;
            // 
            // horaTornadaSortida
            // 
            horaTornadaSortida.HeaderText = "Hora Sortida";
            horaTornadaSortida.Name = "horaTornadaSortida";
            horaTornadaSortida.Width = 80;
            // 
            // aeroportTornadaArribada
            // 
            aeroportTornadaArribada.HeaderText = "Aeroport Arribada";
            aeroportTornadaArribada.Name = "aeroportTornadaArribada";
            aeroportTornadaArribada.Width = 140;
            // 
            // diaTornadaArribada
            // 
            diaTornadaArribada.HeaderText = "Dia Arribada";
            diaTornadaArribada.Name = "diaTornadaArribada";
            diaTornadaArribada.Width = 80;
            // 
            // horaTornadaArribada
            // 
            horaTornadaArribada.HeaderText = "Hora Arribada";
            horaTornadaArribada.Name = "horaTornadaArribada";
            horaTornadaArribada.Width = 80;
            // 
            // preuTornada
            // 
            preuTornada.HeaderText = "Preu";
            preuTornada.Name = "preuTornada";
            preuTornada.Width = 80;
            // 
            // labelReservaVolTornada
            // 
            labelReservaVolTornada.AutoSize = true;
            labelReservaVolTornada.BackColor = Color.Transparent;
            labelReservaVolTornada.Font = new Font("Gabriola", 18F);
            labelReservaVolTornada.Image = (Image)resources.GetObject("labelReservaVolTornada.Image");
            labelReservaVolTornada.Location = new Point(276, 227);
            labelReservaVolTornada.Margin = new Padding(4, 0, 4, 0);
            labelReservaVolTornada.Name = "labelReservaVolTornada";
            labelReservaVolTornada.Size = new Size(233, 45);
            labelReservaVolTornada.TabIndex = 52;
            labelReservaVolTornada.Text = "           VOL TORNADA            ";
            labelReservaVolTornada.Click += labelReservaVolTornada_Click;
            // 
            // dataGridViewReservaHotel
            // 
            dataGridViewReservaHotel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservaHotel.Columns.AddRange(new DataGridViewColumn[] { HotelTriat, PreuDiaHotel, QuantitatDiesHotel, PreuTotalHotelTriat });
            dataGridViewReservaHotel.Location = new Point(133, 433);
            dataGridViewReservaHotel.Name = "dataGridViewReservaHotel";
            dataGridViewReservaHotel.Size = new Size(523, 64);
            dataGridViewReservaHotel.TabIndex = 55;
            dataGridViewReservaHotel.CellContentClick += dataGridViewReservaHotel_CellContentClick;
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
            // labelReservaHotel
            // 
            labelReservaHotel.AutoSize = true;
            labelReservaHotel.BackColor = Color.Transparent;
            labelReservaHotel.Font = new Font("Gabriola", 18F);
            labelReservaHotel.Image = (Image)resources.GetObject("labelReservaHotel.Image");
            labelReservaHotel.Location = new Point(275, 383);
            labelReservaHotel.Name = "labelReservaHotel";
            labelReservaHotel.Size = new Size(232, 45);
            labelReservaHotel.TabIndex = 54;
            labelReservaHotel.Text = "                    HOTEL                   ";
            labelReservaHotel.Click += labelReservaHotel_Click;
            // 
            // pictureBoxExit
            // 
            pictureBoxExit.BackColor = Color.Transparent;
            pictureBoxExit.Image = (Image)resources.GetObject("pictureBoxExit.Image");
            pictureBoxExit.Location = new Point(762, 4);
            pictureBoxExit.Margin = new Padding(4, 3, 4, 3);
            pictureBoxExit.Name = "pictureBoxExit";
            pictureBoxExit.Size = new Size(24, 23);
            pictureBoxExit.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExit.TabIndex = 56;
            pictureBoxExit.TabStop = false;
            pictureBoxExit.Click += pictureBoxExit_Click;
            // 
            // buttonTornarHotels
            // 
            buttonTornarHotels.BackColor = Color.CadetBlue;
            buttonTornarHotels.Font = new Font("Gabriola", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTornarHotels.ForeColor = SystemColors.ControlLightLight;
            buttonTornarHotels.Location = new Point(117, 509);
            buttonTornarHotels.Margin = new Padding(4, 6, 4, 6);
            buttonTornarHotels.Name = "buttonTornarHotels";
            buttonTornarHotels.Size = new Size(221, 45);
            buttonTornarHotels.TabIndex = 58;
            buttonTornarHotels.Tag = "";
            buttonTornarHotels.Text = "☜ HOTELS";
            buttonTornarHotels.UseVisualStyleBackColor = false;
            buttonTornarHotels.Click += buttonTornarHotels_Click;
            // 
            // buttonFinalitzarReserva
            // 
            buttonFinalitzarReserva.AccessibleName = "";
            buttonFinalitzarReserva.BackColor = Color.CadetBlue;
            buttonFinalitzarReserva.Font = new Font("Gabriola", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFinalitzarReserva.ForeColor = SystemColors.ControlLightLight;
            buttonFinalitzarReserva.Location = new Point(453, 509);
            buttonFinalitzarReserva.Margin = new Padding(4, 6, 4, 6);
            buttonFinalitzarReserva.Name = "buttonFinalitzarReserva";
            buttonFinalitzarReserva.Size = new Size(221, 45);
            buttonFinalitzarReserva.TabIndex = 57;
            buttonFinalitzarReserva.Text = "FINALITZAR RESERVA ☞";
            buttonFinalitzarReserva.UseVisualStyleBackColor = false;
            buttonFinalitzarReserva.Click += buttonFinalitzarReserva_Click;
            // 
            // Reserva
            // 
            AutoScaleDimensions = new SizeF(7F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(790, 560);
            Controls.Add(buttonTornarHotels);
            Controls.Add(buttonFinalitzarReserva);
            Controls.Add(pictureBoxExit);
            Controls.Add(dataGridViewReservaHotel);
            Controls.Add(labelReservaHotel);
            Controls.Add(dataGridViewReservaVolTornada);
            Controls.Add(labelReservaVolTornada);
            Controls.Add(labelReservaVolAnada);
            Controls.Add(dataGridViewReservaVolAnada);
            Controls.Add(pictureBoxLogo);
            DoubleBuffered = true;
            Font = new Font("Gabriola", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 6, 3, 6);
            Name = "Reserva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reserva";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservaVolAnada).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservaVolTornada).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservaHotel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private DataGridView dataGridViewReservaVolAnada;
        private DataGridViewTextBoxColumn AeroportAnadaSortida;
        private DataGridViewTextBoxColumn DiaAnadaSortida;
        private DataGridViewTextBoxColumn HoraAnadaSortida;
        private DataGridViewTextBoxColumn AeroportAnadaArribada;
        private DataGridViewTextBoxColumn DiaAnadaArribada;
        private DataGridViewTextBoxColumn HoraAnadaArribada;
        private DataGridViewTextBoxColumn PreuAnada;
        private Label labelReservaVolAnada;
        private DataGridView dataGridViewReservaVolTornada;
        private DataGridViewTextBoxColumn AeroportTornadaSortida;
        private DataGridViewTextBoxColumn diaTornadaSortida;
        private DataGridViewTextBoxColumn horaTornadaSortida;
        private DataGridViewTextBoxColumn aeroportTornadaArribada;
        private DataGridViewTextBoxColumn diaTornadaArribada;
        private DataGridViewTextBoxColumn horaTornadaArribada;
        private DataGridViewTextBoxColumn preuTornada;
        private Label labelReservaVolTornada;
        private DataGridView dataGridViewReservaHotel;
        private DataGridViewTextBoxColumn HotelTriat;
        private DataGridViewTextBoxColumn PreuDiaHotel;
        private DataGridViewTextBoxColumn QuantitatDiesHotel;
        private DataGridViewTextBoxColumn PreuTotalHotelTriat;
        private Label labelReservaHotel;
        private PictureBox pictureBoxExit;
        private Button buttonTornarHotels;
        private Button buttonFinalitzarReserva;
    }
}