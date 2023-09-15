using System;
namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "vilken är din favorit bok?";
            Console.WriteLine(x);
            string bok = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(bok);
            Console.ReadLine();
        }
    }
}