using System;

namespace polymorphAss1
{
    class Program
    {
        static void Main(string[] args)
        {
            OvernightPackage overnightPackage = new OvernightPackage("calabar", "rivers", 7000M);
            TwoDaysPackage twoDaysPackage = new TwoDaysPackage("adamawa", "ogun", 8000M);

            // Console.WriteLine($"{overnightPackage}");
            // Console.WriteLine($"{twoDaysPackage}");

            Console.WriteLine("\n Packages processed polymorphically...\n");
            Package[] packages = new Package[2] { overnightPackage, twoDaysPackage };

            foreach (Package package in packages)
            {
                Console.WriteLine($"{package}");
            }




        }
    }
}
