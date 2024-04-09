using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace lab52
{
    public class eBook : Book
    {

        public eBook(string title, string author, string text, string color, string font)
        {
            Title = title;
            Author = author;
            Text = text;
            Color = color;
            Font = font;
        }
        public void Write()
        {
            Console.WriteLine($"Count of symbols in the text: {CountLetters()}\nColor of text: {Color}\nFont: {Font}");
        }
    }
}

