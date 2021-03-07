// <copyright file="LeftRotationQuantityException.cs" company="PKCodes">
// Copyright (c) PKCodes. All rights reserved.
// </copyright>

namespace ExerciseProblems.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// This class is the array quantity exception class.
    /// </summary>
    [Serializable]
    public class LeftRotationQuantityException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LeftRotationQuantityException"/> class.
        /// </summary>
        /// <param name="message">The message to render on the screen.</param>
        public LeftRotationQuantityException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LeftRotationQuantityException"/> class.
        /// </summary>
        /// <param name="serializationInfo">The serialization information.</param>
        /// <param name="streamingContext">The current streaming context.</param>
        protected LeftRotationQuantityException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
        }
    }
}