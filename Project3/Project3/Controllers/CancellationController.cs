using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project3.Models;
using Project3.Repository;

namespace Project3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CancellationController : BaseController<Cancellation>
    {
        public CancellationController(IBaseRepository<Cancellation> repository) : base(repository)
        {
        }
    }
}
