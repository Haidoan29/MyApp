using Project3.Data;
using Project3.Models;

namespace Project3.Repository
{
    public interface IFareRuleRepository : IBaseRepository<FareRule>
    {

    }
    public class FareRuleRepository : BaseRepository<FareRule>, IFareRuleRepository
    {
        public FareRuleRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
