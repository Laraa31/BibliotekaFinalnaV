using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLZadatak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void upisKorisnika_Click(object sender, EventArgs e)
        {
            UpisKorisnika upisKorisnika = new UpisKorisnika();
            DialogResult rez=upisKorisnika.ShowDialog();
        }

        private void upisKnjiga_Click(object sender, EventArgs e)
        {
            UpisKnjiga upisKnjiga = new UpisKnjiga();
            DialogResult dialogResult = upisKnjiga.ShowDialog();
        }

        private void pretraga_Click(object sender, EventArgs e)
        {
            Pretraga pretraga = new Pretraga();
            DialogResult dialogResult= pretraga.ShowDialog();
        }

        private void vracanjePosudba_Click(object sender, EventArgs e)
        {
            Pretraga pretraga = new Pretraga();
            DialogResult dialogResult = pretraga.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
