using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLZadatak
{
    internal class Knjiga
    {
        string naziv;
        string autor;
        int isbn;

        public Knjiga(string naziv, string autor, int isbn)
        {
            this.Naziv = naziv;
            this.Autor = autor;
            this.ISBN = isbn;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public string Autor { get => autor; set => autor = value; }
        public int ISBN { get => isbn; set => isbn = value; }
    }
}
