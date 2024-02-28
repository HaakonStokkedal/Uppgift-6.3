namespace Uppgift_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till detta menyprogram!!!");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Välj ett alternativ:");
            Console.WriteLine("1. Addera tre tal");
            Console.WriteLine("2. Största talet av två tal");
            Console.WriteLine("3. Avsluta programmet");
            string svar = Console.ReadLine();

            switch (svar)
            {
                case "1":
                    Console.WriteLine("Skriv in ett heltal:");
                    int tal1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv in ett till heltal:");
                    int tal2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv in ett sista heltal:");
                    int tal3 = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Summan av de tre talen är {Summa(tal1, tal2, tal3)}");
                    break;
                case "2":
                    Console.WriteLine("Skriv in ett tal:");
                    int talEtt = int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv in ett till tal:");
                    int talTvå = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{StörstaTal(talEtt, talTvå)} är det största talet");
                    break;
                case "3":
                    Console.WriteLine("Programmet avslutas...");
                    break;
                default:
                    Console.WriteLine("Du valde inget gilltigt alternativ.");
                    break;
            }

            Console.ReadKey();
        }

        static int Summa(int tal1, int tal2, int tal3)
        {
            int summa = tal1 + tal2 + tal3;
            return summa;
        }

        static int StörstaTal(int tal1, int tal2)
        {
            int störstaTal = tal1;

            if (tal1 < tal2)
            {
                störstaTal = tal2;
            }
            return störstaTal;
        }
    }
}