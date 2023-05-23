using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace First2._10
{
    public class Book
    {
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public int YearOfPublication { get; set; }

        public Book(string BookTitle, string Author, int YearOfPublication)
        {
            this.BookTitle = BookTitle;
            this.Author = Author;
            this.YearOfPublication = YearOfPublication;
        }
    }
}
