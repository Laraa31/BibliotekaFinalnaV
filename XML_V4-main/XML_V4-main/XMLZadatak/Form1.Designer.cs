namespace XMLZadatak
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.upisKorisnika = new System.Windows.Forms.Button();
            this.upisKnjiga = new System.Windows.Forms.Button();
            this.pretraga = new System.Windows.Forms.Button();
            this.vracanjePosudba = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // upisKorisnika
            // 
            this.upisKorisnika.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.upisKorisnika.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.upisKorisnika.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.upisKorisnika.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.upisKorisnika.Location = new System.Drawing.Point(59, 248);
            this.upisKorisnika.Name = "upisKorisnika";
            this.upisKorisnika.Size = new System.Drawing.Size(208, 106);
            this.upisKorisnika.TabIndex = 0;
            this.upisKorisnika.Text = "Upis korisnika";
            this.upisKorisnika.UseVisualStyleBackColor = false;
            this.upisKorisnika.Click += new System.EventHandler(this.upisKorisnika_Click);
            // 
            // upisKnjiga
            // 
            this.upisKnjiga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.upisKnjiga.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.upisKnjiga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.upisKnjiga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.upisKnjiga.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.upisKnjiga.Location = new System.Drawing.Point(273, 248);
            this.upisKnjiga.Name = "upisKnjiga";
            this.upisKnjiga.Size = new System.Drawing.Size(208, 106);
            this.upisKnjiga.TabIndex = 1;
            this.upisKnjiga.Text = "Upis knjiga";
            this.upisKnjiga.UseVisualStyleBackColor = false;
            this.upisKnjiga.Click += new System.EventHandler(this.upisKnjiga_Click);
            // 
            // pretraga
            // 
            this.pretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pretraga.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pretraga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pretraga.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pretraga.Location = new System.Drawing.Point(59, 360);
            this.pretraga.Name = "pretraga";
            this.pretraga.Size = new System.Drawing.Size(208, 106);
            this.pretraga.TabIndex = 2;
            this.pretraga.Text = "Pretraga";
            this.pretraga.UseVisualStyleBackColor = false;
            this.pretraga.Click += new System.EventHandler(this.pretraga_Click);
            // 
            // vracanjePosudba
            // 
            this.vracanjePosudba.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vracanjePosudba.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.vracanjePosudba.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vracanjePosudba.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vracanjePosudba.Location = new System.Drawing.Point(273, 360);
            this.vracanjePosudba.Name = "vracanjePosudba";
            this.vracanjePosudba.Size = new System.Drawing.Size(208, 106);
            this.vracanjePosudba.TabIndex = 3;
            this.vracanjePosudba.Text = "Vraćanje / Posudba";
            this.vracanjePosudba.UseVisualStyleBackColor = false;
            this.vracanjePosudba.Click += new System.EventHandler(this.vracanjePosudba_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::XMLZadatak.Properties.Resources.biblioteka_high_resolution_logo_color_on_transparent_background;
            this.pictureBox1.Location = new System.Drawing.Point(160, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(540, 526);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.vracanjePosudba);
            this.Controls.Add(this.pretraga);
            this.Controls.Add(this.upisKnjiga);
            this.Controls.Add(this.upisKorisnika);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Biblioteka";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button upisKorisnika;
        private System.Windows.Forms.Button upisKnjiga;
        private System.Windows.Forms.Button pretraga;
        private System.Windows.Forms.Button vracanjePosudba;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

