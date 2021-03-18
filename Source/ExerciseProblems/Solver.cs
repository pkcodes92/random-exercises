// <copyright file="Solver.cs" company="PKCodes">
// Copyright (c) PKCodes. All rights reserved.
// </copyright>

namespace ExerciseProblems
{
    /// <summary>
    /// This is the class that will do the heavy-lifting of solving all problems.
    /// </summary>
    public class Solver
    {
        /// <summary>
        /// This method will calculate the absolute difference between the input number, n
        /// and 51. If the value of n is greater than 51, return triple the absolute difference.
        /// </summary>
        /// <param name="n">The input integer, provided from the console.</param>
        /// <returns>The absolute difference which is an integer.</returns>
        public static int FindDifference(int n)
        {
            const int x = 51;

            if (n > x)
            {
                return (n - x) * 3;
            }

            return x - n;
        }

        /// <summary>
        /// This method will return an integer array that is left rotated.
        /// </summary>
        /// <param name="input">The array that is blank, and going to be the output of left rotation.</param>
        /// <param name="a">The array that is coming in as input from the user.</param>
        /// <param name="k">The number of rotations to be conducted.</param>
        /// <param name="n">The size of the input array.</param>
        /// <returns>An integer array that is the result of the left rotations.</returns>
        public static int[] LeftRotateArray(int[] input, int[] a, int k, int n)
        {
            int j, z;

            for (j = 0; j < n; j++)
            {
                z = (j - k) % n;

                if (z != 0)
                {
                    z = (n + z) % n;
                }

                input[z] = a[j];
            }

            return input;
        }

        /// <summary>
        /// This method will find the number of elements in the array where the number itself
        /// has an even number of digits.
        /// </summary>
        /// <param name="input">The input array.</param>
        /// <returns>A total count of even-numbered integers.</returns>
        public static int FindNumbersWithEvenNumberDigits(int[] input)
        {
            var totalCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string valueToEvaluate = input[i].ToString();
                if (valueToEvaluate.Length % 2 == 0)
                {
                    totalCount++;
                }
            }

            return totalCount;
        }

        /// <summary>
        /// This method be able to take the input string and create an acronym.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>A compressed version - or the acronym.</returns>
        public static string MakeAcronym(string input)
        {
            return string.Empty;
        }
    }
}