using System;
namespace inlämning_4._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Detta programmet ritar ut en rätvinklig triangel");

            Console.WriteLine("Skriv in hur många * du vill att kateten ska vara, skriv ett valfritt nummer");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
            Console.ReadKey();
        }
    }
}
