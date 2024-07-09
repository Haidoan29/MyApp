using Project3.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3.Models
{
    public class FareRule : Base
    {
        public int ClassID { get; set; }
        public int RouterID { get; set; }
        public decimal Fare { get; set; }
        [ForeignKey("RouterID")]
        public virtual MyRouter? Router { get; set; }
        [ForeignKey("ClassID")]
        public virtual Class? Class { get; set; }

    }
   
}
