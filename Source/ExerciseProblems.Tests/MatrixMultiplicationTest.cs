// <copyright file="MatrixMultiplicationTest.cs" company="PKCodes">
// Copyright (c) PKCodes. All rights reserved.
// </copyright>

namespace ExerciseProblems.Tests
{
    using System;
    using ExerciseProblems.Exceptions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// This class will be used for testing various scenarios on the matrix multiplication.
    /// </summary>
    [TestClass]
    public class MatrixMultiplicationTest
    {
        /// <summary>
        /// This method is the standard baseline test method.
        /// </summary>
        [TestMethod]
        public void MatrixMultiplication_Baseline_Test()
        {
            int[] first = new int[] { 1, 2, 3, 5, 6 };
            int[] second = new int[] { 2, 3, 4, 5, 7 };
            var baselineResult = Solver.MultiplyArrayElements(first, second, first.Length);
            Console.WriteLine($"{baselineResult}");
            Assert.IsNotNull(baselineResult);
        }

        /// <summary>
        /// This test method will ensure that there is an exception thrown.
        /// </summary>
        [TestMethod]
        public void MatrixMultiplication_Exception_Test()
        {
            int[] first = new int[] { 1, 2, 3, 4, 5 };
            int[] second = new int[] { };
            Assert.ThrowsException<MatrixMultiplicationException>(() => Solver.MultiplyArrayElements(first, second, first.Length));
        }
    }
}
