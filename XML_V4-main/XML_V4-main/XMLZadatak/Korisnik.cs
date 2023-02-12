using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLZadatak
{
    internal class Korisnik
    {
        string ime;
        string prezime;
        int oib;

        public Korisnik(string ime, string prezime, int oib)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.OIB = oib;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public int OIB { get => oib; set => oib = value; }
    }
}
