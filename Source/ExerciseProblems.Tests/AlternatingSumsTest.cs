// <copyright file="AlternatingSumsTest.cs" company="PKCodes">
// Copyright (c) PKCodes. All rights reserved.
// </copyright>

namespace ExerciseProblems.Tests
{
    using System;
    using ExerciseProblems.Exceptions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// This is the test class for the alternating sums problem.
    /// </summary>
    [TestClass]
    public class AlternatingSumsTest
    {
        /// <summary>
        /// This test method will make sure that the output array is correct.
        /// </summary>
        [TestMethod]
        public void ProperArrayLengthTest()
        {
            int[] testInts = { 20, 40, 68, 90 };
            int[] expectedArray = { 88, 130 };
            var output = Solver.FindAlternatingSums(testInts);

            Console.WriteLine($"Output length: {output.Length}");

            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine($"{output[i] == expectedArray[i]}");
            }

            Assert.IsNotNull(output);
        }

        /// <summary>
        /// This test method will see if there is an exception thrown because
        /// of the input array length not being divisible by 2.
        /// </summary>
        [TestMethod]
        public void ImproperArrayLengthTest()
        {
            int[] testInts = { 20, 2, 4, 5, 6 };
            Assert.ThrowsException<ArrayInputSizeException>(() => Solver.FindAlternatingSums(testInts));
        }
    }
}
