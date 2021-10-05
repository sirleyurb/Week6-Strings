using System;

namespace CompareStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm võrdleb sisestatud andmeid omavahel
            //programm kuvab konsoolis, kumb on pikem - eesnimi või perekonnanimi

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("sisesta oma perekonnanimi:");
            string userLastName = Console.ReadLine();

            if (userName.Length > userLastName.Length)
            {
                Console.WriteLine("sisestatud nimi on pikem kui perekonnanimi");
            }
            else if (userName.Length < userLastName.Length)
            {
                Console.WriteLine("sisestatud nimi on lühem kui perekonnanimi");
            }
            else
            {
                Console.WriteLine("sisestatud nimed on sama pikad");
            }
        }
    }
}
