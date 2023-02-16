using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCgarden.Model
{
    class Garden
    {
        public Garden(decimal cenaZelenchuci, decimal cenaPlodove, int kgZelenchuci, int kgPlodove)
        {
            this.CenaZelenchuci = cenaZelenchuci;
            this.CenaPlodove = cenaPlodove;
            this.KgZelenchuci = kgZelenchuci;
            this.KgPlodove = kgPlodove;
        }

        public decimal CenaZelenchuci { get; set; }
        public decimal CenaPlodove { get; set; }
        public int KgZelenchuci { get; set; }
        public int KgPlodove { get; set; }
        public decimal KalkuliraneNaSuma()
        {
            return 1.94m * (this.KgPlodove * this.CenaPlodove + this.KgZelenchuci * this.CenaZelenchuci);
        }
    }
}
