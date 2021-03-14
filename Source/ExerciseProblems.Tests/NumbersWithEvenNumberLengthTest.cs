// <copyright file="NumbersWithEvenNumberLengthTest.cs" company="PKCodes">
// Copyright (c) PKCodes. All rights reserved.
// </copyright>

namespace ExerciseProblems.Tests
{
    using System;
    using ExerciseProblems;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// This class tests the logic for the problem to find the number of integers which are of even-length in an array.
    /// </summary>
    [TestClass]
    public class NumbersWithEvenNumberLengthTest
    {
        /// <summary>
        /// This method is a baseline unit test to make sure that there is a proper result returning.
        /// </summary>
        [TestMethod]
        public void BaseLineUnitTest()
        {
            var inputInts = new int[] { 32, 283, 9997, 1, 32, 4 };
            var expectedResult = 3;
            var calculatedResult = Solver.FindNumbersWithEvenNumberDigits(inputInts);
            Console.WriteLine($"Number of integers which are even length: {calculatedResult}");
            Assert.AreEqual(expectedResult, calculatedResult);
        }
    }
}