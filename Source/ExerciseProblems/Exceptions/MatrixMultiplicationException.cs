// <copyright file="MatrixMultiplicationException.cs" company="PKCodes">
// Copyright (c) PKCodes. All rights reserved.
// </copyright>

namespace ExerciseProblems.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// This exception class will be able to throw the right exceptions in the matrix multiplications.
    /// </summary>
    [Serializable]
    public class MatrixMultiplicationException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatrixMultiplicationException"/> class.
        /// </summary>
        /// <param name="message">The message to render on the screen.</param>
        public MatrixMultiplicationException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MatrixMultiplicationException"/> class.
        /// </summary>
        /// <param name="message">The message to render on the screen.</param>
        /// <param name="variableMissing">The parameter that is missing.</param>
        public MatrixMultiplicationException(string message, object variableMissing)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MatrixMultiplicationException"/> class.
        /// </summary>
        /// <param name="serializationInfo">The serialization info.</param>
        /// <param name="streamingContext">The current streaming context.</param>
        protected MatrixMultiplicationException(
            SerializationInfo serializationInfo,
            StreamingContext streamingContext)
        {
        }
    }
}
