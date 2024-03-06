using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user for a string
            Console.Write("String: ");
            string s = Console.ReadLine();


            //ask the user for a character
            Console.Write("Caráter: ");
            string character = Console.ReadLine();
            char c = char.Parse(character);


        }
    }
}
