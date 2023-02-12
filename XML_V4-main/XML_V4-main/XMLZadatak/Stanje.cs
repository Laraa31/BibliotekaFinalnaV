using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLZadatak
{
    internal class Stanje
    {
        int kolicina;
        int isbn;

        public Stanje(int kolicina,int isbn)
        {
            this.Kolicina = kolicina;
            this.ISBN = isbn;
        }

        public int ISBN { get => isbn; set => isbn = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
    }
}
