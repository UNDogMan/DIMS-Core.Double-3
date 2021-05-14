using DIMS_Core.DataAccessLayer.Interfaces;
using DIMS_Core.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DIMS_Core.DataAccessLayer.Repositories
{
    public class VUserTaskRepository : ReadOnlyRepository<VUserTask>
    {
        public VUserTaskRepository(DimsCoreContext context) : base(context)
        {
            
        }
    }
}
