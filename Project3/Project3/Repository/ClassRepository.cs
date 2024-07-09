using Project3.Data;
using Project3.Models;

namespace Project3.Repository
{
    public interface IClassRepository : IBaseRepository<Class>
    {

    }
    public class ClassRepository : BaseRepository<Class>, IClassRepository
    {
        public ClassRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
