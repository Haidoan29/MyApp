using Project3.Data;
using Project3.Models;

namespace Project3.Repository
{
    public interface IRoutesReponsitory : IBaseRepository<MyRouter>
    {

    }
    public class RoutesReponsitory : BaseRepository<MyRouter>, IRoutesReponsitory
    {
        public RoutesReponsitory(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
