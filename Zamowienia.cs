using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2BLab3
{
    public partial class Zamowienia
    {
        public Zamowienia()
        {
            PozycjeZamowienia = new HashSet<PozycjeZamowienia>();
        }

        public int Idzamówienia { get; set; }
        public string Idklienta { get; set; }
        public int? Idpracownika { get; set; }
        public DateTime? DataZamówienia { get; set; }
        public DateTime? DataWymagana { get; set; }
        public DateTime? DataWysyłki { get; set; }
        public int? Idspedytora { get; set; }
        public decimal? Fracht { get; set; }
        public string NazwaOdbiorcy { get; set; }
        public string AdresOdbiorcy { get; set; }
        public string MiastoOdbiorcy { get; set; }
        public string RegionOdbiorcy { get; set; }
        public string KodPocztowyOdbiorcy { get; set; }
        public string KrajOdbiorcy { get; set; }

        public virtual Klienci IdklientaNavigation { get; set; }
        public virtual Pracownicy IdpracownikaNavigation { get; set; }
        public virtual Spedytorzy IdspedytoraNavigation { get; set; }
        public virtual ICollection<PozycjeZamowienia> PozycjeZamowienia { get; set; }
    }
}
