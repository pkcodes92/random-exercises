// <copyright file="Solver.cs" company="PKCodes">
// Copyright (c) PKCodes. All rights reserved.
// </copyright>

namespace ExerciseProblems
{
    using System;
    using System.Collections.Generic;
    using ExerciseProblems.Exceptions;

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
            if (input is null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            var parts = input.Split(new char[] { ' ', '-', '_' });

            string res = string.Empty;
            foreach (var p in parts)
            {
                if (p.Length > 0)
                {
                    res += p.ToUpper()[0];
                }
            }

            return res;
        }

        /// <summary>
        /// This method will allow for finding the alternating sums.
        /// </summary>
        /// <param name="input">The array of integers coming in from the command line.</param>
        /// <returns>An array of integers of alternating sums.</returns>
        public static int[] FindAlternatingSums(int[] input)
        {
            if (input.Length % 2 != 0)
            {
                throw new ArrayInputSizeException($"The input is currently: {input.Length}");
            }

            int[] weights = new int[2];

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    weights[0] += input[i];
                }

                if (i % 2 == 1)
                {
                    weights[1] += input[i];
                }
            }

            return weights;
        }

        /// <summary>
        /// This method will make sure to calculate the product of the elements in both arrays.
        /// </summary>
        /// <param name="first">The first array.</param>
        /// <param name="second">The second array.</param>
        /// <param name="arrayLength">The length of the array.</param>
        /// <returns>An integer array that represents the necessary result.</returns>
        public static int[] MultiplyArrayElements(int[] first, int[] second, int arrayLength)
        {
            Console.WriteLine("Array1: [{0}]", string.Join(",", first));
            Console.WriteLine("Array2: [{0}]", string.Join(",", second));

            if (first is null)
            {
                throw new ArgumentNullException(nameof(first));
            }

            if (second is null)
            {
                throw new ArgumentNullException(nameof(second));
            }

            if (first.Length == 0 || second.Length == 0)
            {
                throw new MatrixMultiplicationException("The array inputs need to be greater than 0 elements!");
            }

            if (arrayLength == 0)
            {
                throw new MatrixMultiplicationException("The array length needs to Non-Zero!", arrayLength);
            }

            List<int> result = new List<int>();

            for (int i = 0; i < arrayLength; i++)
            {
                result.Add(first[i] * second[i]);
            }

            var resultArray = result.ToArray();
            return resultArray;
        }
    }
}