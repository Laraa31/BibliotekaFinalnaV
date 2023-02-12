namespace XMLZadatak
{
    partial class UpisKnjiga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpisKnjiga));
            this.btnUnos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbISBNKnj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbKolicinaKnj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbAutorKnj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbNazivKnj = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUnos.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnUnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnos.Font = new System.Drawing.Font("Rockwell", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnos.Location = new System.Drawing.Point(99, 285);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 12;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = false;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.SlateBlue;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtbISBNKnj);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtbKolicinaKnj);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtbAutorKnj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbNazivKnj);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(27, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 257);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Upiši knjigu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "ISBN";
            // 
            // txtbISBNKnj
            // 
            this.txtbISBNKnj.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtbISBNKnj.ForeColor = System.Drawing.Color.GhostWhite;
            this.txtbISBNKnj.Location = new System.Drawing.Point(26, 204);
            this.txtbISBNKnj.Name = "txtbISBNKnj";
            this.txtbISBNKnj.Size = new System.Drawing.Size(172, 25);
            this.txtbISBNKnj.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Količina";
            // 
            // txtbKolicinaKnj
            // 
            this.txtbKolicinaKnj.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtbKolicinaKnj.ForeColor = System.Drawing.Color.GhostWhite;
            this.txtbKolicinaKnj.Location = new System.Drawing.Point(26, 154);
            this.txtbKolicinaKnj.Name = "txtbKolicinaKnj";
            this.txtbKolicinaKnj.Size = new System.Drawing.Size(172, 25);
            this.txtbKolicinaKnj.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Autor";
            // 
            // txtbAutorKnj
            // 
            this.txtbAutorKnj.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtbAutorKnj.ForeColor = System.Drawing.Color.GhostWhite;
            this.txtbAutorKnj.Location = new System.Drawing.Point(26, 104);
            this.txtbAutorKnj.Name = "txtbAutorKnj";
            this.txtbAutorKnj.Size = new System.Drawing.Size(172, 25);
            this.txtbAutorKnj.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Naziv";
            // 
            // txtbNazivKnj
            // 
            this.txtbNazivKnj.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txtbNazivKnj.ForeColor = System.Drawing.Color.GhostWhite;
            this.txtbNazivKnj.Location = new System.Drawing.Point(26, 54);
            this.txtbNazivKnj.Name = "txtbNazivKnj";
            this.txtbNazivKnj.Size = new System.Drawing.Size(172, 25);
            this.txtbNazivKnj.TabIndex = 12;
            // 
            // UpisKnjiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(279, 330);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUnos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpisKnjiga";
            this.Text = "Biblioteka";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbISBNKnj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbKolicinaKnj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbAutorKnj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbNazivKnj;
    }
}