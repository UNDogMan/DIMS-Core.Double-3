namespace DIMS_Core.DataAccessLayer.Exceptions
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

        public static void CheckEntityExists(object entity, string methodName)
        {
            if (entity is null)
            {
                throw new EntityNotExistException(methodName, "Entity not exists in database");
            }
        }
    }
}