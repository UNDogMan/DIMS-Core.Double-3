namespace DIMS_Core.Common.Exceptions
{
    public static class ExceptionHelper
    {
        public static void CheckId(int id)
        {
            if (id <= 0)
            {
                throw new InvalidArgumentException("id");
            }
        }

        public static void CheckEntityExists(object entity, string entityName)
        {
            if (entity is null)
            {
                throw new ObjectNotFoundException(entityName);
            }
        }
    }
}