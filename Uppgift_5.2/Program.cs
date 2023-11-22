using System;
namespace Uppgift_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] talArray = new int[3];
            talArray[0] = 25;
            talArray[1] = 3;

            Console.WriteLine("Skriv in ett heltal");
            while (true) {
                try
                {
                    talArray[2] = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Det är inte ett giltigt svar. Försök igen.");
                }
            }

            Console.WriteLine("\nTalen i arrayen är: ");
            foreach (int tal in talArray)
            {
                Console.Write(tal + " ");
            }

            Console.WriteLine("\nTryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}