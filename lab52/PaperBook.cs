using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab52
{
    public class PaperBook: Book
    {
        public int NumberOfPages { get; set; }
        public PaperBook(string title, string author, int numberOfPages, string color, string font)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
            Color = color;
            Font = font;
        }
        public void Write()
        {
            Console.WriteLine($"Number of pages in paperback book: {NumberOfPages}\nColor of text: {Color}\nFont: {Font}");
        }
    }
}
