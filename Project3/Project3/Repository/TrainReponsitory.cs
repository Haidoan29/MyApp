using Project3.Data;
using Project3.Models;

namespace Project3.Repository
{
    public interface ITrainReponsitory : IBaseRepository<Train>
    {

    }
    public class TrainReponsitory : BaseRepository<Train>, ITrainReponsitory
    {
        public TrainReponsitory(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
