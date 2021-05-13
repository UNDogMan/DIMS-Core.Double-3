namespace DIMS_Core.DataAccessLayer.Exceptions
{
    public class EntityNotExistException : BaseException
    {
        public string Method { get; set; }
        
        public EntityNotExistException(string methodName, string message) : base(message)
        {
            Method = methodName;
        }
    }
}