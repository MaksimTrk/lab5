using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace lab52
{
    public class Page : PaperBook 
    {
        public int PageNumber { get; set; }
        public Page(string title, string author, int number, string text, string color, string font): base(title, author, 0, color, font) 
        {
            PageNumber = number;
            Text = text;
        }
        public void Write()
        {
            Console.WriteLine($"Number of letters on {PageNumber} page of {Title}: {CountLetters()}\nColor of text: {Color}\nFont: {Font}");
        }
    }
}