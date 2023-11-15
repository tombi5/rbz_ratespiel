namespace rbz_ratespiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string eingabe;
            int geraten;
            int geheim;
            int versuche = 0;
            Random zufall = new Random();
            geheim = zufall.Next(1, 11);
            do
            {
                Console.Write("Geben Sie eine Zahl zwischen 1 und 10 ein: ");
                eingabe = Console.ReadLine();
                geraten = Convert.ToInt32(eingabe);
                if (geraten < geheim)
                {
                    Console.WriteLine("Die gesuchte Zahl ist größer.");
                }
                else if (geraten > geheim)
                {
                    Console.WriteLine("Die gesuchte Zahl ist kleiner.");
                }
                versuche++;
            } while (geraten != geheim && versuche < 3);
            if (geraten == geheim)
            {
                Console.WriteLine("Herzlichen Glückwunsch! Sie haben gewonnen.");
            }
            else
            {
                Console.WriteLine("Leider haben Sie verloren. Die gesuchte Zahl war {0}.", geheim);
            }
            Console.ReadKey();
        }
    }
}