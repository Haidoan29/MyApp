using Project3.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3.Models
{
    public class ReservationSuperFastFee : Base
    {
        public int ClassID { get; set; }
        public decimal ReservationFee { get; set; }
        public decimal SuperFastFee { get; set; }
        [ForeignKey("ClassID")]
        public virtual Class? Class { get; set; }
    }
}
