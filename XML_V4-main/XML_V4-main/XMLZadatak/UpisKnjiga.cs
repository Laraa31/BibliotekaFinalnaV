using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace XMLZadatak
{
    public partial class UpisKnjiga : Form
    {
        static List<Knjiga> KnjigeList = new List<Knjiga>();
        static List<Stanje> StanjeList = new List<Stanje>();

        static string path1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string datoteka1 = "Knjige.xml";
        static string datoteka2 = "Stanje.xml";
        static string pathKnjige = Path.Combine(path1, datoteka1);
        static string pathStanje = Path.Combine(path1, datoteka2);

        public UpisKnjiga()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            Knjiga KnjigaUpis = new Knjiga(txtbNazivKnj.Text, txtbAutorKnj.Text, Convert.ToInt32(txtbISBNKnj.Text));
            Stanje stanjeUpis = new Stanje(Convert.ToInt32(txtbKolicinaKnj.Text), Convert.ToInt32(txtbISBNKnj.Text));
            KnjigeList.Add(KnjigaUpis);
            StanjeList.Add(stanjeUpis);

            DialogResult dialogResult = MessageBox.Show("Zelite li upisati jos knjiga?", "Upis", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                try
                {
                    var Knjige = XDocument.Load(pathKnjige);
                    foreach (Knjiga knjiga in KnjigeList)
                    {
                        var Knjiga = new XElement("Knjiga", new XElement("Naziv", knjiga.Naziv), new XElement("Autor", knjiga.Autor), new XElement("ISBN", knjiga.ISBN));
                        Knjige.Root.Add(Knjiga);
                    }
                    Knjige.Save(pathKnjige);

                    var Stanja = XDocument.Load(pathStanje);
                    foreach (Stanje stanje in StanjeList)
                    {
                        var stanje1 = new XElement("Stanje", new XElement("Kolicina", stanje.Kolicina), new XElement("ISBNKnjige", stanje.ISBN));
                        Stanja.Root.Add(stanje1);
                    }
                    Stanja.Save(pathStanje);
                }
                catch (Exception)
                {
                    var Knjige = new XDocument();
                    //Knjige.Add(new XElement("Knjige"));
                    foreach (Knjiga knjiga in KnjigeList)
                    {
                        var Knjiga = new XElement("Knjiga",
                        new XElement("Naziv", knjiga.Naziv),
                        new XElement("Autor", knjiga.Autor),
                        new XElement("ISBN", knjiga.ISBN));
                        Knjige.Root.Add(Knjiga);
                    }
                    Knjige.Save(pathKnjige);

                    var Stanje1 = new XDocument();
                    Stanje1.Add(new XElement("Stanje"));
                    foreach (Stanje stanje in StanjeList)
                    {
                        var Stanje2 = new XElement("Stanje",
                        new XElement("ISBNKnjiga", stanje.ISBN),
                        new XElement("Kolicina", stanje.Kolicina));
                        Stanje1.Root.Add(Stanje2);
                    }
                    Stanje1.Save(pathStanje);

                }
                KnjigeList.Clear();
                StanjeList.Clear();
                this.Close();
            }
            txtbNazivKnj.Text = "";
            txtbAutorKnj.Text = "";
            txtbKolicinaKnj.Text = "";
            txtbISBNKnj.Text = "";
        }
    }
}
