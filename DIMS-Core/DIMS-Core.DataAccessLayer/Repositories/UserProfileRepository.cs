using DIMS_Core.DataAccessLayer.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Task = System.Threading.Tasks.Task;

namespace DIMS_Core.DataAccessLayer.Repositories
{
    public class UserProfileRepository : Repository<UserProfile>
    {
        public UserProfileRepository(DimsCoreContext context) : base(context)
        {
        }

        public override Task Delete(int id)
        {
            var idParam = new SqlParameter("@id", id);
            return _context.Database.ExecuteSqlRawAsync("exec [dbo].[DeleteUser] @id", idParam);
        }
    }
}