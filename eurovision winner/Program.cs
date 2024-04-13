using System;
using System.Net;

namespace eurovision_winner
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string svar;
            
            Console.WriteLine("Please write who will win Eurovision 2024: ");
            
            svar = Console.ReadLine().ToUpper();
            if (svar == "EUROPAPA")
            {
                Console.WriteLine("YES! 12 POINTS TO THE NETHERLANDS");
            }
            else
            {
                Console.WriteLine("You are wrong, I have now planted malware on your computer hahaha.");
            }

            Console.ReadKey();
        }
    }
}