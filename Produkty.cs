using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2BLab3
{
    public partial class Produkty
    {
        public Produkty()
        {
            PozycjeZamowienia = new HashSet<PozycjeZamowienia>();
        }

        public int Idproduktu { get; set; }
        public string NazwaProduktu { get; set; }
        public int? Iddostawcy { get; set; }
        public int? Idkategorii { get; set; }
        public string IlośćJednostkowa { get; set; }
        public decimal? CenaJednostkowa { get; set; }
        public short? StanMagazynu { get; set; }
        public short? IlośćZamówiona { get; set; }
        public short? StanMinimum { get; set; }
        public bool Wycofany { get; set; }

        public virtual Dostawcy IddostawcyNavigation { get; set; }
        public virtual Kategorie IdkategoriiNavigation { get; set; }
        public virtual ICollection<PozycjeZamowienia> PozycjeZamowienia { get; set; }
    }
}
