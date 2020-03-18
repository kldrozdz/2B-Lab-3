using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2BLab3
{
    public partial class Kategorie
    {
        public Kategorie()
        {
            Produkty = new HashSet<Produkty>();
        }

        public int Idkategorii { get; set; }
        public string NazwaKategorii { get; set; }
        public string Opis { get; set; }
        public byte[] Rysunek { get; set; }

        public virtual ICollection<Produkty> Produkty { get; set; }
    }
}
