using Project3.Models;

namespace Project3.Models
{
    public class DailyCashTransaction : Base
    {
        public DateTime TransactionDate { get; set; }
        public decimal MoneyReceived { get; set; }
        public decimal MoneyRefund { get; set; }
    }
}
