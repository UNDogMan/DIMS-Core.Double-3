using DIMS_Core.DataAccessLayer.Interfaces;
using DIMS_Core.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace DIMS_Core.DataAccessLayer.Repositories
{
    public class VUserTrackRepository : ReadOnlyRepository<VUserTrack>
    {
        public VUserTrackRepository(DimsCoreContext context) : base(context)
        {
            
        }
    }
}
