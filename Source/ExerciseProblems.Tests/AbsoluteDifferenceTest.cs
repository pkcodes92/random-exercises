// <copyright file="AbsoluteDifferenceTest.cs" company="PKCodes">
// Copyright (c) PKCodes. All rights reserved.
// </copyright>

namespace ExerciseProblems.Tests
{
    using System;
    using ExerciseProblems;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// This is the unit test class for the absolute difference problem.
    /// </summary>
    [TestClass]
    public class AbsoluteDifferenceTest
    {
        /// <summary>
        /// This method is used to test the normal case.
        /// </summary>
        [TestMethod]
        public void FindAbsDifferenceTest_InputLessThan51()
        {
            const int x = 4;
            var output = Solver.FindDifference(x);
            Console.WriteLine($"Result = {output}");
            Assert.IsTrue(x < 51 && output < 51);
        }

        /// <summary>
        /// This method is used to test the case where the input integer is greater than 51.
        /// </summary>
        [TestMethod]
        public void FindAbsDifferenceTest_InputGreaterThan51()
        {
            const int x = 52;
            var output = Solver.FindDifference(x);
            Console.WriteLine($"Result = {output}");
            Assert.IsTrue(x > 51);
        }
    }
}
