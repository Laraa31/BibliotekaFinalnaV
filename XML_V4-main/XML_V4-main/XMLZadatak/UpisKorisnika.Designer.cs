namespace XMLZadatak
{
    partial class UpisKorisnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpisKorisnika));
            this.btnUnos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbOIBKor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbPrezimeKor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbImeKor = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUnos.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnUnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnos.Font = new System.Drawing.Font("Rockwell", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnos.Location = new System.Drawing.Point(94, 220);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 6;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = false;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.SlateBlue;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbOIBKor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbPrezimeKor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtbImeKor);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(27, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 192);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Upiši korisnika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "OIB";
            // 
            // txtbOIBKor
            // 
            this.txtbOIBKor.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtbOIBKor.Location = new System.Drawing.Point(18, 147);
            this.txtbOIBKor.Name = "txtbOIBKor";
            this.txtbOIBKor.Size = new System.Drawing.Size(172, 25);
            this.txtbOIBKor.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prezime";
            // 
            // txtbPrezimeKor
            // 
            this.txtbPrezimeKor.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtbPrezimeKor.Location = new System.Drawing.Point(18, 97);
            this.txtbPrezimeKor.Name = "txtbPrezimeKor";
            this.txtbPrezimeKor.Size = new System.Drawing.Size(172, 25);
            this.txtbPrezimeKor.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime";
            // 
            // txtbImeKor
            // 
            this.txtbImeKor.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtbImeKor.Location = new System.Drawing.Point(18, 47);
            this.txtbImeKor.Name = "txtbImeKor";
            this.txtbImeKor.Size = new System.Drawing.Size(172, 25);
            this.txtbImeKor.TabIndex = 6;
            // 
            // UpisKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(279, 263);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpisKorisnika";
            this.Text = "Biblioteka";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbOIBKor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbPrezimeKor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbImeKor;
    }
}