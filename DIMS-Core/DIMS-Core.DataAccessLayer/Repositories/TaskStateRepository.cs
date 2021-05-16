using DIMS_Core.DataAccessLayer.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Task = System.Threading.Tasks.Task;

namespace DIMS_Core.DataAccessLayer.Repositories
{
    public class TaskStateRepository : Repository<TaskState>
    {
        public TaskStateRepository(DbContext context) : base(context)
        {
        }

        public Task SetUserTaskAsFail(int userId, int taskId)
        {
            var userIdParam = new SqlParameter("@userId", userId);
            var taskIdParam = new SqlParameter("@taskId", taskId);
            return GetDatabase().ExecuteSqlRawAsync("exec [dbo].[SetUserTaskAsFail] @userId, @taskId", userIdParam, taskIdParam);
        }
        
        public Task SetUserTaskAsSuccess(int userId, int taskId)
        {
            var userIdParam = new SqlParameter("@userId", userId);
            var taskIdParam = new SqlParameter("@taskId", taskId);
            return GetDatabase().ExecuteSqlRawAsync("exec [dbo].[SetUserTaskAsSuccess] @userId, @taskId", userIdParam, taskIdParam);
        }
    }
}