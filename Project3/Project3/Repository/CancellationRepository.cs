using Project3.Data;
using Project3.Models;

namespace Project3.Repository
{
    public interface ICancellationRepository : IBaseRepository<Cancellation>
    {

    }
    public class CancellationRepository : BaseRepository<Cancellation>, ICancellationRepository
    {
        public CancellationRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
