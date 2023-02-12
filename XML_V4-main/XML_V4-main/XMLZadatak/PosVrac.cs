using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLZadatak
{
    internal class PosVrac
    {
        int oib;
        int isbn;
        DateTime datum;

        public PosVrac(int oib, int isbn, DateTime datum)
        {
            this.Oib = oib;
            this.Isbn = isbn;
            this.Datum = datum;
        }

        public int Oib { get => oib; set => oib = value; }
        public int Isbn { get => isbn; set => isbn = value; }
        public DateTime Datum { get => datum; set => datum = value; }
    }
}
