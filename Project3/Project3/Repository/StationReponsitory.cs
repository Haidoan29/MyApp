using Project3.Data;
using Project3.Models;

namespace Project3.Repository
{
    public interface IStationReponsitory : IBaseRepository<Station>
    {

    }
    
    public class StationReponsitory : BaseRepository<Station>, IStationReponsitory
    {
        public StationReponsitory(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
