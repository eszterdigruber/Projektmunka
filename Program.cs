namespace Projektmunka
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {

            int JatekosPont = 0;
            int Botpont = 0;
            var Igaze = true;
            while (Igaze == true)
            {
                Console.Write("Add meg mit mutatnál kő, papír, olló, gyík, spock közül: ");
                string Bekert = Console.ReadLine();
                var Lehetosegek = new List<string> { "Kő", "Papír", "Olló", "Gyík", "Spock" };
                var Veletlen = random.Next(Lehetosegek.Count);
                string a = Lehetosegek[Veletlen];
                Console.WriteLine($"A gép mutatja: {a}");

                if (Bekert == a || a == Bekert)
                {
                    Console.WriteLine($"\nDönetlen");
                }

                else if (Bekert == "Olló" & (a == "Papír" || a == "Gyík"))
                {
                    Console.WriteLine($"Nyertél! +1 pontot kapsz");
                    JatekosPont++;
                    Console.WriteLine($"Pontszámod: {JatekosPont}, \nBot pontszáma: {Botpont}");
                }
                else if (Bekert == "Papír" & (a == "Kő" || a == "Spock"))
                {
                    Console.WriteLine($"Nyertél! +1 pontot kapsz");
                    JatekosPont++;
                    Console.WriteLine($"Pontszámod: {JatekosPont}, \nBot pontszáma: {Botpont}");
                }
                else if (Bekert == "Kő" & (a == "Olló" || a == "Gyík"))
                {
                    Console.WriteLine($"Nyertél! +1 pontot kapsz");
                    JatekosPont++;
                    Console.WriteLine($"Pontszámod: {JatekosPont}, \nBot pontszáma: {Botpont}");
                }
                else if (Bekert == "Gyík" & (a == "Papír" || a == "Spock"))
                {
                    Console.WriteLine($"Nyertél! +1 pontot kapsz");
                    JatekosPont++;
                    Console.WriteLine($"Pontszámod: {JatekosPont}, \nBot pontszáma: {Botpont}");
                }
                else if (Bekert == "Spock" & (a == "Olló" || a == "Kő"))
                {
                    Console.WriteLine($"Nyertél! +1 pontot kapsz");
                    JatekosPont++;
                    Console.WriteLine($"Pontszámod: {JatekosPont}, \nBot pontszáma: {Botpont}");
                }
                else
                {
                    Console.WriteLine($"Vesztettél! +1 pontot kap a bot");
                    Botpont++;
                    Console.WriteLine($"Pontszámod: {JatekosPont}, \nBot pontszáma: {Botpont}");
                }

                if (Botpont - JatekosPont > 2 || JatekosPont - Botpont > 2)
                {
                    Igaze = false;
                }

            }
            Console.WriteLine($"A te pontszámod: {JatekosPont}, {Botpont}");

        }
    }
}