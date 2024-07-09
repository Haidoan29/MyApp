using Project3.Data;
using Project3.Models;

namespace Project3.Repository
{
    public interface ITrainScheduleRepository : IBaseRepository<TrainSchedule>
    {

    }
    public class TrainScheduleRepository : BaseRepository<TrainSchedule>, ITrainScheduleRepository
    {
        public TrainScheduleRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
