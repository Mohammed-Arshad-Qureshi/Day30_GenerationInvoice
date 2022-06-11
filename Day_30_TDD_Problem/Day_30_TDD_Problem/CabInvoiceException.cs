using System;
using System.Collections.Generic;
using System.Text;

namespace Day_30_TDD_Problem
{
    internal class CabInvoiceException : Exception
    {
        public enum ExceptionType
        {
            INVALID_DISTANCE, INVALID_TIME, NULL_RIDE,
            INVALID_ID, INVALID_TYPE
        }
        public ExceptionType type;
        public CabInvoiceException(ExceptionType type, string message) : base(message) // Creating a constructor with parent class
        {
            this.type = type;// Assigning value
        }
    }
}
