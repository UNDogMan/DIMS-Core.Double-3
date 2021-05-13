using DIMS_Core.DataAccessLayer.Interfaces;
using DIMS_Core.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace DIMS_Core.DataAccessLayer.Repositories
{
    public class VUserTrackRepository : IReadOnlyRepository<VUserTrack>
    {
        private readonly DimsCoreContext _context;

        public VUserTrackRepository(DimsCoreContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public IQueryable<VUserTrack> GetAll()
        {
            return _context.VUserTracks.AsNoTracking();
        }
    }
}
