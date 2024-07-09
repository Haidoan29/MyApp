using Project3.Models;

namespace Project3.Models
{
    public class Cancellation : Base
    {
        public string PRNNo { get; set; }
        public DateTime CancellationDate { get; set; }
        public decimal CancellationFee { get; set; }

    }
}
