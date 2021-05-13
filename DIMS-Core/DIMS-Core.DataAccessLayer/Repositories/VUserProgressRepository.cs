using DIMS_Core.DataAccessLayer.Interfaces;
using DIMS_Core.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DIMS_Core.DataAccessLayer.Repositories
{
    public class VUserProgressRepository : IReadOnlyRepository<VUserProgress>
    {
        private readonly DimsCoreContext _context;

        public VUserProgressRepository(DimsCoreContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public IQueryable<VUserProgress> GetAll()
        {
            return _context.VUserProgresses.AsNoTracking();
        }
    }
}
