using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursov_proekt
{
    internal class Pla6tane
    {
        public double Cenapiene { get; set; }
        public string Pla6tanena4in { get; set; }

        public double TotalPrice(int count) => Cenapiene * count;
    }
}
