using Project3.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3.Models
{
    public class DayMaster : Base
    {
        public int DayID { get; set; }
        public int TrainID { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        [ForeignKey("TrainID")]
        public virtual Train? Train { get; set; }
    }
}
