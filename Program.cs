﻿using System;

namespace dotnet
{
    class Program
    {
        static void Main(string[] args)
        {   
            int age; 
            int height; 

            Console.Write("Please input your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please input height (cm): ");
            height = Convert.ToInt32(Console.ReadLine());

            if (age >= 18 && height >= 160) {
                Console.WriteLine("You can enter!");
            } else {
                Console.WriteLine("You don't meet the requirements.");
            }

           // wait before closing
            Console.ReadKey();
        }
    }
}