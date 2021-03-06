// <copyright file="ProblemSolver.cs" company="PKCodes">
// Copyright (c) PKCodes. All rights reserved.
// </copyright>

namespace ExerciseProblems
{
    using System;
    using System.Globalization;

    /// <summary>
    /// This is the problem solver class.
    /// </summary>
    public class ProblemSolver
    {
        /// <summary>
        /// This method will calculate the absolute difference.
        /// </summary>
        public static void AbsoluteDifference()
        {
            Console.WriteLine("Please provide a value for n: ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int result = Solver.FindDifference(n);
            Console.WriteLine(result);
        }
    }
}
