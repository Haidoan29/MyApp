using Project3.Data;
using Project3.Models;

namespace Project3.Repository
{
    public interface ITransactionRepository : IBaseRepository<Transaction>
    {

    }
    public class TransactionRepository : BaseRepository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
