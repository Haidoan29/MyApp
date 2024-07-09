using Project3.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project3.Models
{
    [Table("Router")]
    public class MyRouter : Base
    {
        public string RouteName { get; set; }
        public int StartStationID { get; set; }
        public int EndStation { get; set; }

        //[ForeignKey("StartStationID")]
        //public virtual Station? StartStation { get; set; }

        //[ForeignKey("EndStation")]
        //public virtual Station? EndStations { get; set; }

        public ICollection<Train>? Trains { get; set; }
    }
}
