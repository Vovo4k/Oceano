﻿using System;

namespace Oceano.Commands
{
    public class calc
    {
        public static void Init()
        {
            int num1 = 0;
            int num2 = 0;
            // Ask the user to type the first number.  
            Console.Write("Type a number, and then press Enter: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            // Ask the user to type the second number.  
            Console.Write("Type another number, and then press Enter: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            // Ask the user to choose an option.  
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add (+)");
            Console.WriteLine("\ts - Subtract (-)");
            Console.WriteLine("\rm - Multiply (*)");
            Console.WriteLine("\td - Divide (/)");
            Console.Write("Your option? ");
            // Use a switch statement to do the math.  
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine("Your result: = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine("Your result: = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine("Your result: = " + num1 * num2);
                    break;
                case "d":
                    Console.WriteLine("Your result: = " + num1 / num2);
                    break;
            }
        }
    }
}
