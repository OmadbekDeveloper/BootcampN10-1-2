using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N36_HT2.Models
{
    public struct Color
    {
        public string Red { get; set; }
        public string Blue { get; set; }
        public string Green { get; set; }

        public Color(string red, string green, string blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
    }
}
