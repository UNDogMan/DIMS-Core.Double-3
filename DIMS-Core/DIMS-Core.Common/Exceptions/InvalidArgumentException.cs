namespace DIMS_Core.Common.Exceptions
{
    public class InvalidArgumentException : BaseException
    {
        public string ParameterName { get; set; }
        
        public InvalidArgumentException(string paramName) 
            : base($"Wrong argument value of {paramName}")
        {
            ParameterName = paramName;
        }
    }
}