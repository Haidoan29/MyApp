using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project3.Models;

using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Transaction = Project3.Models.Transaction;

namespace Project3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {


            //this.Data();
        }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Cancellation> Cancellations { get; set; }
        public virtual DbSet<CancellationFeeRule> CancellationFeeRules { get; set; }
        public virtual DbSet<DailyCashTransaction> DailyCashTransactions { get; set; }
        public virtual DbSet<DayMaster> DayMasters { get; set; }
        public virtual DbSet<FareRule> FareRules { get; set; }
        public virtual DbSet<Train> Trains { get; set; }
        public virtual DbSet<TrainSchedule> TrainSchedules { get; set; }
        public virtual DbSet<ReservationSuperFastFee> ReservationSuperFastFees { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<MyRouter> MyRouters { get; set; }
        public virtual DbSet<Station> Stations { get; set; }
        public virtual DbSet<Class> Classes { get; set; }







        //private async void Data()
        //{
        //    if (this.Class.Count() <= 0)
        //    {
        //        var c1 = new Class() { ClassName = "C2209G" };
        //        var c2 = new Class() { ClassName = "C2209G1" };
        //        var c3 = new Class() { ClassName = "C2209G2" };
        //        var c4 = new Class() { ClassName = "A11111A" };
        //        var c5 = new Class() { ClassName = "C2209G4" };
        //        var c6 = new Class() { ClassName = "C2209D" };


        //        this.Class.Add(c1);
        //        this.Class.Add(c2);
        //        this.Class.Add(c3);
        //        this.Class.Add(c4);
        //        this.Class.Add(c5);
        //        this.Class.Add(c6);

        //        this.SaveChanges();
        //    }
        //}
    }
}
