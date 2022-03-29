// <copyright file="AvoidObstaclesTest.cs" company="PKCodes">
// Copyright (c) PKCodes. All rights reserved.
// </copyright>

namespace ExerciseProblems.Tests
{
    using System;
    using ExerciseProblems;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// This class will test the functionality of the solution to the avoidObstacles problem.
    /// </summary>
    [TestClass]
    public class AvoidObstaclesTest
    {
        /// <summary>
        /// This method will test the functionality of <see cref="Solver.AvoidObstacles(int[])"/>.
        /// </summary>
        [TestMethod]
        public void AvoidObstacles_BasicTest()
        {
            int[] inputArray = { 3, 5, 4, 6, 7, 8, 9 };
            var output = Solver.AvoidObstacles(inputArray);
            Console.WriteLine($"output = {output}");
            Assert.IsTrue(output > 0);
        }
    }
}