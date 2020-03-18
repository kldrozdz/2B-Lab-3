using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2BLab3
{
    public partial class PozycjeZamowienia
    {
        public int Idzamówienia { get; set; }
        public int Idproduktu { get; set; }
        public decimal CenaJednostkowa { get; set; }
        public short Ilość { get; set; }
        public float Rabat { get; set; }

        public virtual Produkty IdproduktuNavigation { get; set; }
        public virtual Zamowienia IdzamówieniaNavigation { get; set; }
    }
}
