using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class CabInvoiceException : Exception
    {
        /// <summary>
        /// Custom Exception,ENUM is a constant.
        /// </summary>
        public enum ExceptionType
        {
            INVALID_RIDE_TYPE,
            INVALID_DISTANCE,
            INVALID_TIME,
            NULL_RIDE,
            INVALID_USER_ID
        }

        ExceptionType type;

        /// <summary>
        /// Creating a parameterised constructor initializes a new instance of the CabInvoiceException class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="message">The message.</param>
        public CabInvoiceException(ExceptionType type,string message) : base(message)
        {
            this.type = type;
        }
    }
}
