// <copyright file="ProblemSolver.cs" company="PKCodes">
// Copyright (c) PKCodes. All rights reserved.
// </copyright>

namespace ExerciseProblems
{
    using System;
    using System.Globalization;
    using ExerciseProblems.Exceptions;

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

        /// <summary>
        /// This method conducts the array left rotation.
        /// </summary>
        public static void ArrayLeftRotation()
        {
            int i;

            // Inputs being tracked for the size of the array, and number of rotations.
            string[] tokens_in = Console.ReadLine().Split(' ');

            // Size of the array, n.
            int n = Convert.ToInt32(tokens_in[0]);

            // Number of left rotations, k (which represents the value of d).
            int k = Convert.ToInt32(tokens_in[1]);

            // The actual array of integers.
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, int.Parse);
            int[] tempArray = new int[2 * n];

            // Constraints - also implement the new custom
            // exceptions which can emulate "production" ready code
            // and this code can also terminate gracefully.
            if (n >= 100000 || n < 1)
            {
                throw new ArrayInputSizeException($"Cannot perform the left rotations with the array size of {n}");
            }

            if (k > n || n < 1)
            {
                throw new LeftRotationQuantityException($"Cannot perform {k} left rotations on the array length of {n}");
            }

            for (i = 0; i < n; i++)
            {
                if (a[i] > 1000000 || a[i] < 1)
                {
                    Environment.Exit(1);
                }
            }

            var resultArray = Solver.LeftRotateArray(tempArray, a, k, n);
            for (i = 0; i < resultArray.Length; i++)
            {
                Console.Write(resultArray[i] + " ");
            }
        }

        /// <summary>
        /// This method will find the number of even-numbered digits.
        /// </summary>
        public static void NumbersWithEvenNumberDigits()
        {
            Console.WriteLine("Please enter a list of integers separated by a space: ");
            string[] inputStr = Console.ReadLine().Split(' ');
            int[] input = Array.ConvertAll(inputStr, int.Parse);
            Console.WriteLine($"Number of numbers with even-numbered digits: {Solver.FindNumbersWithEvenNumberDigits(input)}");
        }
    }
}