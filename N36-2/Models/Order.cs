using N36_HT2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N36_HT2.Models
{
    public record Order(int OrderId, Customer Custommer, IEnumerable<Product> Items);
}
