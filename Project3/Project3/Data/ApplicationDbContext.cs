using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project3.Models;



namespace Project3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {


            //this.Data();
        }
       







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
