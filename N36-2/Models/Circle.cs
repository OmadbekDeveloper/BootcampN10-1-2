using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N36_HT2.Models
{
    public struct Circle
    {
        public float Radius { get; set; }
        public Point Point { get; set; }

        public Circle(float radius, Point point)
        {
            Radius = radius;
            Point = point;

        }
    }
}
