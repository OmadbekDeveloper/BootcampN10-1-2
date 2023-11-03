using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N36_HT2.Models
{
    public struct Rectangle
    {
        public decimal Width { get; set; }
        public decimal Height { get; set; }

        public Rectangle(decimal width, decimal height)
        {
            Width = width;
            Height = height;
        }
    }
}
