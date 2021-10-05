using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm kuvab kasutaja eesnime esimest tähte
            //programm kuvab kasutaja eesnime viimast tähte

            Console.WriteLine("Sisesta oma eesnimi:");
            string firstname = Console.ReadLine();

            Console.WriteLine(firstname [0]);

            int firstnameLenght = firstname.Length;
            Console.WriteLine($"teie nimi on {firstnameLenght} sümbolit pikk");

            //viimase tähe indeks = firstnameLenght -1
            Console.WriteLine(firstname[firstnameLenght - 1]);

        }
    }
}
