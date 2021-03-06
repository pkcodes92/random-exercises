// <copyright file="Program.cs" company="PKCodes">
// Copyright (c) PKCodes. All rights reserved.
// </copyright>

namespace ExerciseProblems
{
    using System;

    /// <summary>
    /// This is the main driver class of this application.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the main entry point of execution.
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Hello and welcome to the Random Exercises app!");
            Console.WriteLine("Please enter a problem that you want solved: ");

            var problemChoice = Console.ReadLine();

            switch (problemChoice)
            {
                case "AbsoluteDifference":
                    break;
                default:
                    Console.WriteLine($"Sorry I don't think I have the logic for {problemChoice}");
                    break;
            }

            Console.WriteLine("The program execution has completed, please press any key to exit...");
            Console.ReadKey();
        }
    }
}