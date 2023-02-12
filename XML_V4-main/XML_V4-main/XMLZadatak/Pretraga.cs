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
    public partial class Pretraga : Form
    {
        static List<PosVrac> PosList = new List<PosVrac>();
        static List<PosVrac> VracList = new List<PosVrac>();

        static string path1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static string datoteka1 = "Posudeno.xml";
        static string datoteka2 = "Vraceno.xml";
        static string pathPos = Path.Combine(path1, datoteka1);
        static string pathVrac = Path.Combine(path1, datoteka2);
        public Pretraga()
        {
            InitializeComponent();

        }

        private void btnPretraziKnj_Click(object sender, EventArgs e)
        {

            rtbIspis.Clear();
            string path1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string datoteka1 = "Knjige.xml";
            string datoteka2 = "Stanje.xml";
            string pathKnjige = Path.Combine(path1, datoteka1);
            string pathStanje = Path.Combine(path1, datoteka2);




            if (txtNazivKnj.Text != "")
            {
                XDocument doc = XDocument.Load(pathKnjige);
                XElement root=doc.Root;

                var rez= root.Elements("Knjiga").FirstOrDefault(m=>m.Element("Naziv").Value==txtNazivKnj.Text);
                rtbIspis.AppendText(rez.ToString());
            }
            else if(txtAutor.Text != "")
            {
                XDocument doc = XDocument.Load(pathKnjige);
                XElement root = doc.Root;

                var rez = root.Elements("Knjiga").FirstOrDefault(m => m.Element("Autor").Value == txtAutor.Text);
                rtbIspis.AppendText(rez.ToString());

            }
            else if(txtKolicina.Text != "")
            {
                XDocument doc = XDocument.Load(pathStanje);
                XElement root = doc.Root;

                var rez = root.Elements("Stanje").FirstOrDefault(m => m.Element("Kolicina").Value == txtKolicina.Text);
                rtbIspis.AppendText(rez.ToString());

            }
            else if(txtISBN.Text != "")
            {
                XDocument doc = XDocument.Load(pathKnjige);
                XElement root = doc.Root;

                var rez = root.Elements("Knjiga").FirstOrDefault(m => m.Element("ISBN").Value == txtISBN.Text);
                rtbIspis.AppendText(rez.ToString());

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Ništa niste upisali! Upišite parametar po kojem želite pretražiti knjigu.", "Pretraga", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            }

            txtNazivKnj.Clear();
            txtKolicina.Clear();
            txtAutor.Clear();
            txtISBN.Clear();

        }

        private void btnPretraziKor_Click(object sender, EventArgs e)
        {
            rtbIspis.Clear();
            string path1 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string datoteka1 = "Korisnici.xml";
            string pathKorisnici = Path.Combine(path1, datoteka1);


            if (txtImeKor.Text != "")
            {
                XDocument doc = XDocument.Load(pathKorisnici);
                XElement root = doc.Root;

                var rez = root.Elements("Korisnik").FirstOrDefault(m => m.Element("Ime").Value == txtImeKor.Text);
                rtbIspis.AppendText(rez.ToString());
            }
            else if(txtPrezime.Text != ""){ 
                XDocument doc = XDocument.Load(pathKorisnici);
                XElement root = doc.Root;

                var rez = root.Elements("Korisnik").FirstOrDefault(m => m.Element("Prezime").Value == txtPrezime.Text);
                rtbIspis.AppendText(rez.ToString());
            }
            else if(txtOIB.Text != "")
            {
                XDocument doc = XDocument.Load(pathKorisnici);
                XElement root = doc.Root;

                var rez = root.Elements("Korisnik").FirstOrDefault(m => m.Element("OIB").Value == txtOIB.Text);
                rtbIspis.AppendText(rez.ToString());
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Ništa niste upisali! Upišite parametar po kojem želite pretražiti korisnika.", "Pretraga", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            txtImeKor.Clear();
            txtPrezime.Clear();
            txtOIB.Clear();
        }

        



        private void btnPsoudi_Click(object sender, EventArgs e)
        {
            PosVrac posUpis = new PosVrac(Convert.ToInt32(txtOIBKorPos.Text), Convert.ToInt32(txtISBNknjPos.Text), dtpPosudivanje.Value);
            PosList.Add(posUpis);
          
                try
                {
                    var pos2 = XDocument.Load(pathPos);
                    foreach (PosVrac pos in PosList)
                    {
                        var pos1 = new XElement("Posudeno", new XElement("OIB", pos.Oib), new XElement("ISBN", pos.Isbn), new XElement("Datum posudivanja", pos.Datum));
                        pos2.Root.Add(pos1);
                    }
                    pos2.Save(pathPos);

                }
                catch (Exception)
                {
                    var pos2 = new XDocument();
                    //pos2.Add(new XElement("Posudeno"));
                    foreach (PosVrac pos in PosList )
                    {
                        var pos3 = new XElement("Posudeno",
                        new XElement("OIB", pos.Oib),
                        new XElement("ISBN", pos.Isbn),
                        new XElement("Datum vracanja", pos.Datum));
                        pos2.Root.Add(pos3);
                    }
                    pos2.Save(pathPos);


                }
                PosList.Clear();

            txtOIBKorPos.Text = "";
            txtISBNknjPos.Text = "";
            

        }

        private void btnVrati_Click(object sender, EventArgs e)
        {
            PosVrac vracUpis = new PosVrac(Convert.ToInt32(txtOIBKorVra.Text), Convert.ToInt32(txtISBNKnjVra.Text), dtpVracanje.Value);
            VracList.Add(vracUpis);

            try
            {
                var vrac2 = XDocument.Load(pathPos);
                foreach (PosVrac vrac in VracList)
                {
                    var vrac1 = new XElement("Vraceno", new XElement("OIB", vrac.Oib), new XElement("ISBN", vrac.Isbn), new XElement("Datum vracanja", vrac.Datum));
                    vrac2.Root.Add(vrac1);
                }
                vrac2.Save(pathVrac);

            }
            catch (Exception)
            {
                var vrac2 = new XDocument();
                //pos2.Add(new XElement("Posudeno"));
                foreach (PosVrac vrac in VracList)
                {
                    var vrac3 = new XElement("Posudeno",
                    new XElement("OIB", vrac.Oib),
                    new XElement("ISBN", vrac.Isbn),
                    new XElement("Datum vracanja", vrac.Datum));
                    vrac2.Root.Add(vrac3);
                }
                vrac2.Save(pathVrac);

            }
            VracList.Clear();

            txtOIBKorVra.Text = "";
            txtISBNKnjVra.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtImeKor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtOIB_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
