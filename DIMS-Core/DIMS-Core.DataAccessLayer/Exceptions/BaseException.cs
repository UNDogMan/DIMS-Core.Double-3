using System;

namespace DIMS_Core.DataAccessLayer.Exceptions
{
    public abstract class BaseException : Exception
    {
        public BaseException(string message) : base(message)
        {
            
        }
    }
}