using Project3.Data;
using Project3.Models;

namespace Project3.Repository
{
    public interface IReservationSuperFastFeeRepository : IBaseRepository<ReservationSuperFastFee>
    {

    }
    public class ReservationSuperFastFeeRepository : BaseRepository<ReservationSuperFastFee>, IReservationSuperFastFeeRepository
    {
        public ReservationSuperFastFeeRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
