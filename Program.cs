using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2BLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var NorthwindContext = new ZNorthwindContext();
            foreach (var elem in NorthwindContext.PozycjeZamówienia.Include(x => x.IdproduktuNavigation))
            {
                Console.WriteLine($"{elem.Idzamówienia} {elem.Idproduktu}" +
                    $" {elem.IdproduktuNavigation.NazwaProduktu} {elem.IdproduktuNavigation.CenaJednostkowa}" +
                    $" {elem.Ilość}");
            }

        }
    }
}
