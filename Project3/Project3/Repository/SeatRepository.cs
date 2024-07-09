using Project3.Data;
using Project3.Models;

namespace Project3.Repository
{
    public interface ISeatReponsitory : IBaseRepository<Seat>
    {

    }
    public class SeatRepository : BaseRepository<Seat>, ISeatReponsitory
    {
        public SeatRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
