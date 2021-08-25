using System;
using System.Collections.Generic;
using System.Text;

namespace section11.exercises.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
