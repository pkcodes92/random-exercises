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

        /// <summary>
        /// This method will be able to solve the problem of creating an acronym.
        /// </summary>
        public static void CreateAcronym()
        {
            Console.WriteLine("Enter a text from which to create an acronym: ");
            var stringToMakeAnAcronym = Console.ReadLine();
            Console.WriteLine($"Your acronym: {Solver.MakeAcronym(stringToMakeAnAcronym)}");
        }

        /// <summary>
        /// This method will be solving the problem of finding alternating sums.
        /// </summary>
        public static void AlternatingSums()
        {
            Console.WriteLine("Enter an array of integers (space-separated) to find the alternating sums: ");
            string[] inputStr = Console.ReadLine().Split(' ');
            int[] input = Array.ConvertAll(inputStr, int.Parse);
            Console.WriteLine($"The resulting alternating sums are: {Solver.FindAlternatingSums(input)}");
        }

        /// <summary>
        /// This method will take two arrays and multiply the elements that are in both arrays.
        /// </summary>
        public static void ArrayElementsMultiplication()
        {
            int[] firstArray = { 1, 3, 4, -5, 4 };
            int[] secondArray = { 2, 4, 3, -5, 22 };

            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", firstArray));
            Console.WriteLine("Array2: [{0}]", string.Join(", ", secondArray));
            Console.WriteLine(
                "Multiplying the corresponding elements of both arrays: [{0}]",
                string.Join(", ", Solver.MultiplyArrayElements(firstArray, secondArray, firstArray.Length)));
        }

        /// <summary>
        /// This method will solve the avoid obstacles problem.
        /// </summary>
        public static void AvoidObstacles()
        {
            int[] inputArray = { 3, 4, 6, 7, 8, 9 };
            var solution = Solver.AvoidObstacles(inputArray);
            Console.WriteLine($"For Avoid Obstacles the solution is: {solution}");
        }

        /// <summary>
        /// This method will address the solution to the knapsack ligt problem.
        /// </summary>
        public static void KnapsackLight()
        {
            int val1 = 10;
            int weight1 = 5;
            int val2 = 6;
            int weight2 = 4;
            int maxW = 8;
            int solution = Solver.KnapsackLight(val1, weight1, val2, weight2, maxW);
            Console.WriteLine($"For the Knapsack Light problem, solution = {solution}");
        }

        /// <summary>
        /// This method will solve the extra number problem.
        /// </summary>
        public static void ExtraNumber()
        {
            int a = 2;
            int b = 3;
            int c = 2;
            int solution = Solver.ExtraNumber(a, b, c);
            Console.WriteLine($"For Extra Number, the solution = {solution}");
        }

        /// <summary>
        /// This method will solve the problem for reaching the next level.
        /// </summary>
        public static void ReachNextLevel()
        {
            int experience = 3;
            int reward = 5;
            int threshold = 10;
            bool solution = Solver.ReachNextLevel(experience, threshold, reward);
            Console.WriteLine($"Can Reach Next Level = {solution}");
        }

        /// <summary>
        /// This method solves the problem is infinite process.
        /// </summary>
        public static void IsInfiniteProcess()
        {
            int a = 2;
            int b = 3;
            bool result = Solver.IsInfiniteProcess(a, b);
            Console.WriteLine($"Is Infinite Process? {result}");
        }
    }
}