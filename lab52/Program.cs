using lab52;
class Program
{
    static void Main(string[] args)
    {
        PaperBook paperbook = new PaperBook("1984", "George Orwell", 254, "black", "Arial");
        paperbook.Write();

        eBook ebook = new eBook("1984", "George Orwell", "Lorem ipsum dolor sit amet, consectetur adipiscing elit...", "black", "Arial");
        ebook.Write();

        Graffiti graffiti = new Graffiti("Mural","Chemis","Praga");
        graffiti.Write();

        Page page = new Page("1984", "George Orwell", 1, "It was a bright cold day in April, and the clocks were striking thirteen." +
            "\r\nWinston Smith, his chin nuzzled into his breast in an effort to escape the vile wind, slipped quickly through the glass doors of Victory Mansions, though not quickly enough to prevent a swirl of gritty dust from entering along with him."
            , "black", "Arial");
        page.Write();
    }
}