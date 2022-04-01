// <copyright file="NumbersWithEvenDigitsTest.cs" company="PKCodes">
// Copyright (c) PKCodes. All rights reserved.
// </copyright>

namespace ExerciseProblems.Tests
{
    using System;
    using ExerciseProblems;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// This will unit test the solution to the problem to find numbers that have an even number of digits.
    /// </summary>
    [TestClass]
    public class NumbersWithEvenDigitsTest
    {
        /// <summary>
        /// This method will test the functionality in <see cref="Solver.FindNumbersWithEvenNumberDigits(int[])"/>.
        /// </summary>
        [TestMethod]
        public void FindNumbersWithEvenNumberDigits_NormalCase_Test()
        {
            int[] inputTest = new int[] { 23, 3, 101, 2983 };
            int expectedResult = 2;
            int calculatedResult = Solver.FindNumbersWithEvenNumberDigits(inputTest);
            Console.WriteLine($"Number of results: {calculatedResult}");
            Assert.AreEqual(expectedResult, calculatedResult);
        }
    }
}