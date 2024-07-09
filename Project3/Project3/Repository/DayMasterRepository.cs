using Project3.Data;
using Project3.Models;

namespace Project3.Repository
{
    public interface IDayMasterRepository : IBaseRepository<DayMaster>
    {

    }
    public class DayMasterRepository : BaseRepository<DayMaster>, IDayMasterRepository
    {
        public DayMasterRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
