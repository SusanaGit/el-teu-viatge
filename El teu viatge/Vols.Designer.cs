namespace El_teu_viatge
{
    partial class Vols
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vols));
            buttonVeureHotels = new Button();
            buttonModifyDates = new Button();
            labelVolsAnada = new Label();
            labelVolsTornada = new Label();
            dataGridViewVolsAnada = new DataGridView();
            AeroportAnadaSortida = new DataGridViewTextBoxColumn();
            DiaAnadaSortida = new DataGridViewTextBoxColumn();
            HoraAnadaSortida = new DataGridViewTextBoxColumn();
            AeroportAnadaArribada = new DataGridViewTextBoxColumn();
            DiaAnadaArribada = new DataGridViewTextBoxColumn();
            HoraAnadaArribada = new DataGridViewTextBoxColumn();
            PreuAnada = new DataGridViewTextBoxColumn();
            dataGridViewVolsTornada = new DataGridView();
            AeroportTornadaSortida = new DataGridViewTextBoxColumn();
            diaTornadaSortida = new DataGridViewTextBoxColumn();
            horaTornadaSortida = new DataGridViewTextBoxColumn();
            aeroportTornadaArribada = new DataGridViewTextBoxColumn();
            diaTornadaArribada = new DataGridViewTextBoxColumn();
            horaTornadaArribada = new DataGridViewTextBoxColumn();
            preuTornada = new DataGridViewTextBoxColumn();
            pictureBoxExit = new PictureBox();
            pictureBoxLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVolsAnada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVolsTornada).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // buttonVeureHotels
            // 
            buttonVeureHotels.AccessibleName = "";
            buttonVeureHotels.BackColor = Color.CadetBlue;
            buttonVeureHotels.Font = new Font("Gabriola", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVeureHotels.ForeColor = SystemColors.ControlLightLight;
            buttonVeureHotels.Location = new Point(452, 509);
            buttonVeureHotels.Margin = new Padding(4, 6, 4, 6);
            buttonVeureHotels.Name = "buttonVeureHotels";
            buttonVeureHotels.Size = new Size(221, 45);
            buttonVeureHotels.TabIndex = 25;
            buttonVeureHotels.Text = "VEURE HOTELS ☞";
            buttonVeureHotels.UseVisualStyleBackColor = false;
            buttonVeureHotels.Click += buttonVeureHotels_Click;
            // 
            // buttonModifyDates
            // 
            buttonModifyDates.BackColor = Color.CadetBlue;
            buttonModifyDates.Font = new Font("Gabriola", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonModifyDates.ForeColor = SystemColors.ControlLightLight;
            buttonModifyDates.Location = new Point(116, 509);
            buttonModifyDates.Margin = new Padding(4, 6, 4, 6);
            buttonModifyDates.Name = "buttonModifyDates";
            buttonModifyDates.Size = new Size(221, 45);
            buttonModifyDates.TabIndex = 35;
            buttonModifyDates.Tag = "";
            buttonModifyDates.Text = "☜ MODIFICAR DATES";
            buttonModifyDates.UseVisualStyleBackColor = false;
            buttonModifyDates.Click += buttonModifyDates_Click;
            // 
            // labelVolsAnada
            // 
            labelVolsAnada.AutoSize = true;
            labelVolsAnada.BackColor = Color.Transparent;
            labelVolsAnada.Font = new Font("Gabriola", 18F);
            labelVolsAnada.Image = (Image)resources.GetObject("labelVolsAnada.Image");
            labelVolsAnada.Location = new Point(275, 72);
            labelVolsAnada.Margin = new Padding(4, 0, 4, 0);
            labelVolsAnada.Name = "labelVolsAnada";
            labelVolsAnada.Size = new Size(236, 45);
            labelVolsAnada.TabIndex = 40;
            labelVolsAnada.Text = "              VOLS ANADA             ";
            labelVolsAnada.Click += labelVolsAnada_Click;
            // 
            // labelVolsTornada
            // 
            labelVolsTornada.AutoSize = true;
            labelVolsTornada.BackColor = Color.Transparent;
            labelVolsTornada.Font = new Font("Gabriola", 18F);
            labelVolsTornada.Image = (Image)resources.GetObject("labelVolsTornada.Image");
            labelVolsTornada.Location = new Point(275, 285);
            labelVolsTornada.Margin = new Padding(4, 0, 4, 0);
            labelVolsTornada.Name = "labelVolsTornada";
            labelVolsTornada.Size = new Size(237, 45);
            labelVolsTornada.TabIndex = 41;
            labelVolsTornada.Text = "          VOLS TORNADA            ";
            labelVolsTornada.Click += labelVolsTornada_Click;
            // 
            // dataGridViewVolsAnada
            // 
            dataGridViewVolsAnada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVolsAnada.Columns.AddRange(new DataGridViewColumn[] { AeroportAnadaSortida, DiaAnadaSortida, HoraAnadaSortida, AeroportAnadaArribada, DiaAnadaArribada, HoraAnadaArribada, PreuAnada });
            dataGridViewVolsAnada.Location = new Point(33, 122);
            dataGridViewVolsAnada.Margin = new Padding(4, 6, 4, 6);
            dataGridViewVolsAnada.Name = "dataGridViewVolsAnada";
            dataGridViewVolsAnada.Size = new Size(723, 147);
            dataGridViewVolsAnada.TabIndex = 45;
            dataGridViewVolsAnada.CellContentClick += dataGridViewVolsAnada_CellContentClick;
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
            // dataGridViewVolsTornada
            // 
            dataGridViewVolsTornada.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVolsTornada.Columns.AddRange(new DataGridViewColumn[] { AeroportTornadaSortida, diaTornadaSortida, horaTornadaSortida, aeroportTornadaArribada, diaTornadaArribada, horaTornadaArribada, preuTornada });
            dataGridViewVolsTornada.Location = new Point(33, 336);
            dataGridViewVolsTornada.Margin = new Padding(4, 6, 4, 6);
            dataGridViewVolsTornada.Name = "dataGridViewVolsTornada";
            dataGridViewVolsTornada.Size = new Size(723, 147);
            dataGridViewVolsTornada.TabIndex = 46;
            dataGridViewVolsTornada.CellContentClick += dataGridViewVolsTornada_CellContentClick;
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
            // pictureBoxExit
            // 
            pictureBoxExit.BackColor = Color.Transparent;
            pictureBoxExit.Image = (Image)resources.GetObject("pictureBoxExit.Image");
            pictureBoxExit.Location = new Point(762, 4);
            pictureBoxExit.Margin = new Padding(4, 3, 4, 3);
            pictureBoxExit.Name = "pictureBoxExit";
            pictureBoxExit.Size = new Size(24, 23);
            pictureBoxExit.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExit.TabIndex = 47;
            pictureBoxExit.TabStop = false;
            pictureBoxExit.Click += pictureBoxExit_Click_1;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(338, 2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(116, 56);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 48;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Click += pictureBoxLogo_Click;
            // 
            // Vols
            // 
            AutoScaleDimensions = new SizeF(7F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(790, 560);
            Controls.Add(pictureBoxLogo);
            Controls.Add(pictureBoxExit);
            Controls.Add(dataGridViewVolsTornada);
            Controls.Add(dataGridViewVolsAnada);
            Controls.Add(labelVolsTornada);
            Controls.Add(labelVolsAnada);
            Controls.Add(buttonModifyDates);
            Controls.Add(buttonVeureHotels);
            DoubleBuffered = true;
            Font = new Font("Gabriola", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 6, 4, 6);
            Name = "Vols";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vols";
            ((System.ComponentModel.ISupportInitialize)dataGridViewVolsAnada).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVolsTornada).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonVeureHotels;
        private Button buttonModifyDates;
        private Label labelVolsAnada;
        private Label labelVolsTornada;
        private DataGridView dataGridViewVolsAnada;
        private DataGridView dataGridViewVolsTornada;
        private PictureBox pictureBoxExit;
        private DataGridViewTextBoxColumn AeroportAnadaSortida;
        private DataGridViewTextBoxColumn DiaAnadaSortida;
        private DataGridViewTextBoxColumn HoraAnadaSortida;
        private DataGridViewTextBoxColumn AeroportAnadaArribada;
        private DataGridViewTextBoxColumn DiaAnadaArribada;
        private DataGridViewTextBoxColumn HoraAnadaArribada;
        private DataGridViewTextBoxColumn PreuAnada;
        private DataGridViewTextBoxColumn AeroportTornadaSortida;
        private DataGridViewTextBoxColumn diaTornadaSortida;
        private DataGridViewTextBoxColumn horaTornadaSortida;
        private DataGridViewTextBoxColumn aeroportTornadaArribada;
        private DataGridViewTextBoxColumn diaTornadaArribada;
        private DataGridViewTextBoxColumn horaTornadaArribada;
        private DataGridViewTextBoxColumn preuTornada;
        private PictureBox pictureBoxLogo;
    }
}