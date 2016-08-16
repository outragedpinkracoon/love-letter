using LoveLetter.Domain;

namespace LoveLetter.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var card = new Card();
            System.Console.WriteLine(card.Name());
        }
    }
}
