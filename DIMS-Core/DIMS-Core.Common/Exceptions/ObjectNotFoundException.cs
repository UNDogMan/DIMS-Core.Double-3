namespace DIMS_Core.Common.Exceptions
{
    public class ObjectNotFoundException : BaseException
    {
        public ObjectNotFoundException(string entityName) 
            : base($"Object not found for {entityName}")
        {
            
        }
    }
}