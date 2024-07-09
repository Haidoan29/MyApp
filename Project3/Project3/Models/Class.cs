namespace Project3.Models
{
    public class Class:Base
    {
        public string ClassName { get; set; }
        public ICollection<CancellationFeeRule>? CancellationFeeRules { get; set; }
        public ICollection<ReservationSuperFastFee>? ReservationSuperFastFees { get; set; }
        public ICollection<FareRule>? FareRules { get; set; }
        public ICollection<Seat>? Seats { get; set; }
    }
}
