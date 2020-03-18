using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2BLab3
{
    public partial class Dostawcy
    {
        public Dostawcy()
        {
            Produkty = new HashSet<Produkty>();
        }

        public int Iddostawcy { get; set; }
        public string NazwaFirmy { get; set; }
        public string Przedstawiciel { get; set; }
        public string StanowiskoPrzedstawiciela { get; set; }
        public string Adres { get; set; }
        public string Miasto { get; set; }
        public string Region { get; set; }
        public string KodPocztowy { get; set; }
        public string Kraj { get; set; }
        public string Telefon { get; set; }
        public string Faks { get; set; }
        public string StronaMacierzysta { get; set; }

        public virtual ICollection<Produkty> Produkty { get; set; }
    }
}
