namespace El_teu_viatge
{
    partial class Confirmacio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirmacio));
            pictureBoxLogoConfirmacio = new PictureBox();
            labelTextAgraiment = new Label();
            pictureBoxExit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoConfirmacio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogoConfirmacio
            // 
            pictureBoxLogoConfirmacio.BackColor = Color.Transparent;
            pictureBoxLogoConfirmacio.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogoConfirmacio.Image = (Image)resources.GetObject("pictureBoxLogoConfirmacio.Image");
            pictureBoxLogoConfirmacio.Location = new Point(282, 169);
            pictureBoxLogoConfirmacio.Name = "pictureBoxLogoConfirmacio";
            pictureBoxLogoConfirmacio.Size = new Size(226, 203);
            pictureBoxLogoConfirmacio.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogoConfirmacio.TabIndex = 1;
            pictureBoxLogoConfirmacio.TabStop = false;
            pictureBoxLogoConfirmacio.Click += pictureBoxLogoConfirmacio_Click;
            // 
            // labelTextAgraiment
            // 
            labelTextAgraiment.AutoSize = true;
            labelTextAgraiment.BackColor = Color.Transparent;
            labelTextAgraiment.Font = new Font("Gabriola", 16F);
            labelTextAgraiment.Location = new Point(177, 111);
            labelTextAgraiment.Name = "labelTextAgraiment";
            labelTextAgraiment.Size = new Size(437, 40);
            labelTextAgraiment.TabIndex = 2;
            labelTextAgraiment.Text = "Moltes gràcies. En breu rebràs el resguard de la reserva al mail.";
            // 
            // pictureBoxExit
            // 
            pictureBoxExit.BackColor = Color.Transparent;
            pictureBoxExit.Image = (Image)resources.GetObject("pictureBoxExit.Image");
            pictureBoxExit.Location = new Point(759, 4);
            pictureBoxExit.Name = "pictureBoxExit";
            pictureBoxExit.Size = new Size(26, 24);
            pictureBoxExit.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxExit.TabIndex = 26;
            pictureBoxExit.TabStop = false;
            pictureBoxExit.Click += pictureBoxExit_Click;
            // 
            // Confirmacio
            // 
            AutoScaleDimensions = new SizeF(7F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(790, 560);
            Controls.Add(pictureBoxExit);
            Controls.Add(labelTextAgraiment);
            Controls.Add(pictureBoxLogoConfirmacio);
            DoubleBuffered = true;
            Font = new Font("Gabriola", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 6, 3, 6);
            Name = "Confirmacio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirmacio";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoConfirmacio).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogoConfirmacio;
        private Label labelTextAgraiment;
        private PictureBox pictureBoxExit;
    }
}