using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2BLab3
{
    public partial class Spedytorzy
    {
        public Spedytorzy()
        {
            Zamowienia = new HashSet<Zamowienia>();
        }

        public int Idspedytora { get; set; }
        public string NazwaFirmy { get; set; }
        public string Telefon { get; set; }

        public virtual ICollection<Zamowienia> Zamowienia { get; set; }
    }

}
