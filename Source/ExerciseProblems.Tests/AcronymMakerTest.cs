// <copyright file="AcronymMakerTest.cs" company="PKCodes">
// Copyright (c) PKCodes. All rights reserved.
// </copyright>

namespace ExerciseProblems.Tests
{
    using System;
    using ExerciseProblems;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// This is the unit test for the acronym maker.
    /// </summary>
    [TestClass]
    public class AcronymMakerTest
    {
        /// <summary>
        /// This method will look at the nominal non-null input string.
        /// </summary>
        [TestMethod]
        public void CreateBasicAcronymNonNullTest()
        {
            var inputString = "the quick brown fox";
            var expectedAcronym = "TQBF";
            var calculatedAcronym = Solver.MakeAcronym(inputString);
            Assert.AreEqual(expectedAcronym, calculatedAcronym);
        }

        /// <summary>
        /// This method is used to make sure that the ArgumentNullException is thrown.
        /// </summary>
        [TestMethod]
        public void CreateAcronymExceptionTest()
        {
            string inputString = null;
            Assert.ThrowsException<ArgumentNullException>(() => Solver.MakeAcronym(inputString));
        }
    }
}