﻿using System;

namespace RightSize
{
    class Program
    {
        static void Main(string[] args)
        {
            
            foreach (string s in args)
            {
                if (s.Length > 6)
                {
                    break;
                }

                else if (s.Length > 3)
                {
                    Console.WriteLine(s);
                }      
            }   
        }
    }
}
