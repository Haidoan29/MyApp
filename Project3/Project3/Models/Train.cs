using Project3.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3.Models
{
    public enum UpDownStatus
    {
        Up,
        Down
    }
    public class Train : Base
    {
        public string TrainName { get; set; }
        public int NumCoachesAC3 { get; set; }
        public int NumCoachesFirstClass { get; set; }
        public int NumCoachesSleeper { get; set; }
        public UpDownStatus UpDownStatus { get; set; }
        public int RouteID { get; set; }
        [ForeignKey("RouteID")]
        public virtual MyRouter? Routers { get; set; }
        public ICollection<TrainSchedule>? TrainSchedules { get; set; }
        public ICollection<DayMaster>? DayMasters { get; set; }
        //public ICollection<Transaction>? Transactions { get; set; }
        public ICollection<Seat>? Seat { get; set; }
    }
    
}
