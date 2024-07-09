using Project3.Data;
using Project3.Models;

namespace Project3.Repository
{
    public interface IDailyCashTransactionRepository : IBaseRepository<DailyCashTransaction>
    {

    }
    public class DailyCashTransactionRepository : BaseRepository<DailyCashTransaction>, IDailyCashTransactionRepository
    {
        public DailyCashTransactionRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
