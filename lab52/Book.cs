using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace lab52
{
    public abstract class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Color {  get; set; }
        public string Font {  get; set; }
        public string Text;
        public int CountLetters()
        {
            int count = 0;
            foreach (char c in Text)
            {
                if (char.IsLetter(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
