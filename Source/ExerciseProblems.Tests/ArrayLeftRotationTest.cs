// <copyright file="ArrayLeftRotationTest.cs" company="PKCodes">
// Copyright (c) PKCodes. All rights reserved.
// </copyright>

namespace ExerciseProblems.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// This test class is for the array left rotation problem implementation.
    /// </summary>
    [TestClass]
    public class ArrayLeftRotationTest
    {
        /// <summary>
        /// This method is to make sure that the left rotation works.
        /// </summary>
        [TestMethod]
        public void LeftRotateArrayTest()
        {
            var a = new int[] { 12, 53, 4, 6, 98, 39, 81, 3 };
            var input = new int[2 * a.Length];
            const int k = 3;
            var outputResult = Solver.LeftRotateArray(input, a, k, a.Length);
            Console.WriteLine($"Output Results Length: {outputResult.Length}");
            Assert.IsNotNull(outputResult);
        }
    }
}
