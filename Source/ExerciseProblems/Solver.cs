// <copyright file="Solver.cs" company="PKCodes">
// Copyright (c) PKCodes. All rights reserved.
// </copyright>
namespace ExerciseProblems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
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
                throw new ArgumentZeroException(nameof(value1));
            }

            if (weight1 == 0)
            {
                throw new ArgumentZeroException(nameof(weight1));
            }

            if (value2 == 0)
            {
                throw new ArgumentZeroException(nameof(value2));
            }

            if (weight2 == 0)
            {
                throw new ArgumentZeroException(nameof(weight2));
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
            if (a == 0)
            {
                throw new ArgumentZeroException(nameof(a));
            }

            if (b == 0)
            {
                throw new ArgumentZeroException(nameof(b));
            }

            if (c == 0)
            {
                throw new ArgumentZeroException(nameof(c));
            }

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

        /// <summary>
        /// This method will solve the reachNextLevel problem.
        /// </summary>
        /// <param name="experience">The amount of experience points.</param>
        /// <param name="threshold">The threshold required to reach the next level.</param>
        /// <param name="reward">The number of reward points.</param>
        /// <returns>The output result and having the player reach the next level.</returns>
        public static bool ReachNextLevel(int experience, int threshold, int reward)
        {
            if (experience == 0)
            {
                throw new ArgumentZeroException(nameof(experience));
            }

            if (threshold == 0)
            {
                throw new ArgumentZeroException(nameof(threshold));
            }

            if (reward == 0)
            {
                throw new ArgumentZeroException(nameof(reward));
            }

            return reward >= threshold - experience;
        }

        /// <summary>
        /// This method will execute the core algorithm behind the is infinite process problem.
        /// </summary>
        /// <param name="a">The integer value of a.</param>
        /// <param name="b">The integer value of b.</param>
        /// <returns>A boolean result to see if the two numbers result in an infinite process.</returns>
        public static bool IsInfiniteProcess(int a, int b)
        {
            if (a == 0)
            {
                throw new ArgumentZeroException(nameof(a));
            }

            if (b == 0)
            {
                throw new ArgumentZeroException(nameof(b));
            }

            return a > b || (b - a) % 2 != 0;
        }

        /// <summary>
        /// This method will show the implentation of the Bogo Sort.
        /// </summary>
        /// <param name="inputList">The input list of integers.</param>
        /// <param name="announce">A boolean value determining whether or not to display output in the console.</param>
        /// <param name="delay">The time delay between each output to the console.</param>
        public static void BogoSort(List<int> inputList, bool announce, int delay)
        {
            if (inputList is null)
            {
                throw new ArgumentNullException(nameof(inputList));
            }

            if (delay == 0)
            {
                throw new ArgumentZeroException(nameof(delay));
            }

            int iteration = 0;
            while (!IsSorted(inputList))
            {
                if (announce)
                {
                    PrintIteration(inputList, iteration);
                }

                if (delay != 0)
                {
                    Thread.Sleep(Math.Abs(delay));
                }

                inputList = Remap(inputList);
                iteration++;
            }

            PrintIteration(inputList, iteration);
            Console.WriteLine();
            Console.WriteLine($"Bogo Sort completed after {iteration} iterations");
        }

        /// <summary>
        /// This method will solve the Box Blur problem.
        /// </summary>
        /// <param name="image">A 2D Array input.</param>
        /// <returns>A 2D array representing the blurred image.</returns>
        public static int[][] BoxBlur(int[][] image)
        {
            if (image is null)
            {
                throw new ArgumentNullException(nameof(image));
            }

            int[][] result = new int[image.Length - 2][];
            int[] ii = new int[] { -1, -1, -1, 0, 1, 1, 1, 0 };
            int[] jj = new int[] { -1, 0, 1, 1, 1, 0, -1, -1 };

            int temp;
            for (int i = 1; i < image.Length - 1; i++)
            {
                result[i - 1] = new int[image[i].Length - 2];
                for (int j = 0; j < image[i].Length - 1; j++)
                {
                    temp = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        bool condition1 = 0 <= i + ii[k] && ii[k] < image.Length;
                        bool condition2 = 0 <= j + jj[k] && j + jj[k] < image[i].Length;
                        if (condition1 && condition2)
                        {
                            temp += image[i + ii[k]][j + jj[k]];
                        }

                        result[i - 1][j - 1] = (image[i][j] + temp) / 9;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// This method will be executing the bubble sort algorithm.
        /// </summary>
        /// <param name="arr">The input array of integers.</param>
        /// <param name="n">The size of the array, or the number of moves to sort the entire array.</param>
        /// <returns>An integer value which represents the number of moves taken to sort an array.</returns>
        public static int BubbleSort(int[] arr, int n)
        {
            if (arr is null)
            {
                throw new ArgumentNullException(nameof(arr));
            }

            if (n == 0)
            {
                throw new ArgumentZeroException($"Value of n = {n}");
            }

            int i, j, temp;
            int swappedCount = 0;
            bool swapped;

            for (i = 0; i < n; ++i)
            {
                swapped = false;
                for (j = 0; j < n - i - 1; ++j)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = true;
                        swappedCount++;
                    }
                }

                // If no elements were swapped by the inner most loop, then break.
                if (swapped == false)
                {
                    break;
                }
            }

            return swappedCount;
        }

        private static void PrintIteration(List<int> list, int iteration)
        {
            Console.Write("Bogo Sort iteration {0}: ", iteration);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
                if (i < list.Count)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }

        private static bool IsSorted(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

        private static List<int> Remap(List<int> list)
        {
            if (list is null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            int temp;
            List<int> newList = new List<int>();
            Random r = new Random();

            while (list.Count > 0)
            {
                temp = (int)r.Next(list.Count);
                newList.Add(list[temp]);
                list.RemoveAt(temp);
            }

            return newList;
        }
    }
}