using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab52
{
    public class Graffiti: Book
    {
        public string City { get; set; }
        public Graffiti(string title, string author, string city)
        {
            Title = title;
            Author = author;
            City = city;
        }
        public void Write()
        {
            Console.WriteLine($"Graffiti style: {Title}, author: {Author}, city where graffiti is located: {City}");
        }
    }
}
