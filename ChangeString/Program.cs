using System;
using System.Reflection.PortableExecutable;

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
            char ch = char.Parse(character);

            string new_s = "";

            foreach (char c in s)
            { 
                if(c == ch)
                {
                    new_s += "X";
                }
                    
                else
                {
                    new_s += c;
                }
            }
            Console.WriteLine(new_s);

        }
    }
}
