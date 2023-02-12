using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Xml.Linq;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLZadatak
{
    public partial class UpisKorisnika : Form
    {
        static List<Korisnik> KorisniciList = new List<Korisnik>();
        static string path1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string datoteka = "Korisnici.xml";
        static string path = Path.Combine(path1, datoteka);
        public UpisKorisnika()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            Korisnik KorisnikUpis = new Korisnik( txtbImeKor.Text, txtbPrezimeKor.Text, Convert.ToInt32(txtbOIBKor.Text));
            KorisniciList.Add(KorisnikUpis);
            DialogResult dialogResult = MessageBox.Show("Zelite li upisati jos korisnika?", "Upis", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                try
                {
                    var Korisnici = XDocument.Load(path);
                    foreach (Korisnik korisnik in KorisniciList)
                    {
                        var Korisnik = new XElement("Korisnik", new XElement("Ime", korisnik.Ime), new XElement("Prezime", korisnik.Prezime), new XElement("OIB", korisnik.OIB));
                        Korisnici.Root.Add(Korisnik);
                    }
                    Korisnici.Save(path);
                }
                catch (Exception)
                {
                    var Korisnici = new XDocument();
                    //Korisnici.Add(new XElement("Korisnici"));
                    foreach (Korisnik korisnik in KorisniciList)
                    {
                        var Korisnik = new XElement("Korisnik",
                        new XElement("OIB", korisnik.OIB),
                        new XElement("Ime", korisnik.Ime),
                        new XElement("Prezime", korisnik.Prezime));
                        Korisnici.Root.Add(Korisnik);
                    }
                    Korisnici.Save(path);
                }
                KorisniciList.Clear();
                this.Close();
            }
            txtbImeKor.Text = "";
            txtbPrezimeKor.Text = "";
            txtbOIBKor.Text = "";
        
        }

    }
}
