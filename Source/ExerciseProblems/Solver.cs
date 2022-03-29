// <copyright file="Solver.cs" company="PKCodes">
// Copyright (c) PKCodes. All rights reserved.
// </copyright>
namespace ExerciseProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
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

        /// <summary>
        /// This method will be calculating the obstacles to avoid.
        /// </summary>
        /// <param name="inputArray">The input array, consisting of the obstacles.</param>
        /// <returns>The minimum length of the jump in order to avoid all obstacles.</returns>
        public static int AvoidObstacles(int[] inputArray)
        {
            if (inputArray is null)
            {
                throw new ArgumentNullException(nameof(inputArray));
            }

            var list = inputArray.ToList();

            for (int i = 1; i < list.Max() + 1; i++)
            {
                if (list.All(n => n % i != 0))
                {
                    return i;
                }
            }

            return list.Max() + 1;
        }

        /// <summary>
        /// This method will solve the knapsack light problem.
        /// </summary>
        /// <param name="value1">The first value.</param>
        /// <param name="weight1">The first weight.</param>
        /// <param name="value2">The second value.</param>
        /// <param name="weight2">The second weight.</param>
        /// <param name="maxWeight">The maximum weight of the knapsack.</param>
        /// <returns>An integer of the knapsack weight that is to be carried.</returns>
        public static int KnapsackLight(int value1, int weight1, int value2, int weight2, int maxWeight)
        {
            if (value1 == 0)
            {
                throw new ArgumentNullException(nameof(value1));
            }

            if (weight1 == 0)
            {
                throw new ArgumentNullException(nameof(weight1));
            }

            if (value2 == 0)
            {
                throw new ArgumentNullException(nameof(value2));
            }

            if (weight2 == 0)
            {
                throw new ArgumentNullException(nameof(weight2));
            }

            int numericalSol;
            if (weight1 + weight2 <= maxWeight)
            {
                numericalSol = value1 + value2;
            }
            else if (weight1 <= maxWeight && weight2 <= maxWeight)
            {
                numericalSol = Math.Max(value1, value2);
            }
            else if (weight1 <= maxWeight)
            {
                numericalSol = value1;
            }
            else if (weight2 <= maxWeight)
            {
                numericalSol = value2;
            }
            else
            {
                numericalSol = 0;
            }

            return numericalSol;
        }

        /// <summary>
        /// This method will select the extra number.
        /// </summary>
        /// <param name="a">The first of three integers.</param>
        /// <param name="b">The second of three integers.</param>
        /// <param name="c">The third of three integers.</param>
        /// <returns>The extra number that has been selected.</returns>
        public static int ExtraNumber(int a, int b, int c)
        {
            int numericalSolution = 0;
            if (a == b)
            {
                numericalSolution = c;
            }
            else if (b == c)
            {
                numericalSolution = a;
            }
            else if (a == c)
            {
                numericalSolution = b;
            }

            return numericalSolution;
        }
    }
}