// <copyright file="ArrayInputSizeException.cs" company="PKCodes">
// Copyright (c) PKCodes. All rights reserved.
// </copyright>

namespace ExerciseProblems.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// This class is the array input size exception.
    /// </summary>
    [Serializable]
    public class ArrayInputSizeException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayInputSizeException"/> class.
        /// </summary>
        /// <param name="message">The message to render on the screen.</param>
        public ArrayInputSizeException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArrayInputSizeException"/> class.
        /// </summary>
        /// <param name="serializationInfo">The serialization info.</param>
        /// <param name="streamingContext">The current streaming context.</param>
        protected ArrayInputSizeException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
        }
    }
}