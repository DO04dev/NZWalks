using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NZWalksDBContext nZWalksDBContext;

        public RegionRepository(NZWalksDBContext nZWalksDBContext)
        { 
            this.nZWalksDBContext = nZWalksDBContext;
        }

        public IEnumerable<Region> GetAll()
        {
            return nZWalksDBContext.Regions.ToList();
        }
    }
}
