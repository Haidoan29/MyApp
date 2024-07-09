using Project3.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3.Models
{
    public class TrainSchedule : Base
    {
        //public int ScheduleID { get; set; }
        public int TrainID { get; set; }
        public int StartStationID { get; set; }
        public int EndStationID { get; set; }
        
        public DateTime JourneyDate { get; set; }

        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        [ForeignKey("TrainNo")]
        public virtual Train? Train { get; set; }
        //[ForeignKey("startstationid")]

        //public virtual Station? startstation { get; set; }
        //[ForeignKey("endstationid")]
        //public virtual Station? endstation { get; set; }
    }
}
