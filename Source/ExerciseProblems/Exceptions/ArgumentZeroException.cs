// <copyright file="ArgumentZeroException.cs" company="PKCodes">
// Copyright (c) PKCodes. All rights reserved.
// </copyright>

namespace ExerciseProblems.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// This class is for the argument zero exception.
    /// </summary>
    [Serializable]
    public class ArgumentZeroException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentZeroException"/> class.
        /// </summary>
        /// <param name="message">The message to render on the screen.</param>
        public ArgumentZeroException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArgumentZeroException"/> class.
        /// </summary>
        /// <param name="serializationInfo">The serialization information.</param>
        /// <param name="streamingContext">The current streaming context.</param>
        protected ArgumentZeroException(
            SerializationInfo serializationInfo,
            StreamingContext streamingContext)
        {
        }
    }
}