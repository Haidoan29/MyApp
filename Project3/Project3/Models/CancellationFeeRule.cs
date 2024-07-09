using Project3.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3.Models
{
    public class CancellationFeeRule : Base
    {
       
        public int ClassID { get; set; }
        public decimal CancellationFee { get; set; }
        [ForeignKey("ClassID")]
        public virtual Class? Class { get; set; }
    }
}
