using HomeWork10.Models;
using System;

namespace HomeWork10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Rectangular");
            Console.WriteLine("0. Quit");

            string choice = Console.ReadLine();
            bool check = true;
            switch (choice)
            {
                case "1":
                    Square square = new Square(7);
                    Console.WriteLine(square.CalcArea());
                    break;

                case "2":
                    Rectangular rectangular = new Rectangular(6, 8);
                    Console.WriteLine(rectangular.CalcArea()); 
                    break;

                case "0":
                    check = false;
                    break;


            }

        }
    }
}
