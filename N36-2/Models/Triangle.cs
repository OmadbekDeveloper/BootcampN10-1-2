using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N36_HT2.Models
{
    public struct Triangle
    {
        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }

        public Triangle(float a, float b, float c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
    }
}
