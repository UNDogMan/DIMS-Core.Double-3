using DIMS_Core.DataAccessLayer.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DIMS_Core.DataAccessLayer.Repositories
{
    public class TaskRepository : Repository<Task>
    {
        public TaskRepository(DbContext context) : base(context)
        {
        }

        public override System.Threading.Tasks.Task Delete(int id)
        {
            var idParam = new SqlParameter("@id", id);
            return _context.Database.ExecuteSqlRawAsync("exec [dbo].[DeleteTask] @id", idParam);
        }
    }
}