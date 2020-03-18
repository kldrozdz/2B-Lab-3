using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2BLab3
{
    public class Zajecia
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        [Column("Nazwa przedmiotu")]
        public string Nazwa { get; set; }

        public DateTime GodzinaRozpoczecia { get; set; }
    }
}
