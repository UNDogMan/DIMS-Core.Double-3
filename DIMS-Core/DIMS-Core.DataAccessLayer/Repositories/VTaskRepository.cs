using DIMS_Core.DataAccessLayer.Interfaces;
using DIMS_Core.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DIMS_Core.DataAccessLayer.Repositories
{
    public class VTaskRepository : IReadOnlyRepository<VTask>
    {
        private readonly DimsCoreContext _context;

        public VTaskRepository(DimsCoreContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public IQueryable<VTask> GetAll()
        {
            return _context.VTasks.AsNoTracking();
        }
    }
}
