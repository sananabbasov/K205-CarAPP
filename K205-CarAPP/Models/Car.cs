using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K205_CarAPP.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal BenzinTutumu { get; set; } // Bak hecmi
        public decimal Benzin { get; set; } // Bak benzin miqdari
        public decimal Yurus { get; set; }
    }
}
