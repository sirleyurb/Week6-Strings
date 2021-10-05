using System;

namespace StringReveresed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnimi
            //programm kuvab kasutajanime tagurpidi

            Console.WriteLine("sisesta oma eesnimi");
            string userName = Console.ReadLine();

            for (int i = userName.Length - i; i >= 0; i--)
            {
                Console.WriteLine(userName[i]);
            }

        }
    }
}
