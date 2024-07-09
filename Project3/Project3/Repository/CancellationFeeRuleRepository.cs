using Project3.Data;
using Project3.Models;

namespace Project3.Repository
{
    public interface ICancellationFeeRuleRepository : IBaseRepository<CancellationFeeRule>
    {

    }
    public class CancellationFeeRuleRepository : BaseRepository<CancellationFeeRule>, ICancellationFeeRuleRepository
    {
        public CancellationFeeRuleRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
