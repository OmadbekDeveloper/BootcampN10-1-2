using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N36_HT2.Models
{
    public class Book
    {
        public static (string Title, string Author, int Year) CreateBook(string title, string author, int year)
        {
            return (title, author, year);
        }
    }
}
