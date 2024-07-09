using Project3.Data;
using Project3.Models;
using Project3.Repository;


namespace Project3.Repository
{
    public interface ICustomerRopository : IBaseRepository<Customer>
    {

    }
    public class CustomerRopository : BaseRepository<Customer>, ICustomerRopository
    {
        public CustomerRopository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context, httpContextAccessor)
        {
        }
    }
}
