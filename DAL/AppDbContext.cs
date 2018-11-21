using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

//TODO: Make this using statement match your project
using Rabe_Celina_HW6.Models;

//TODO: Make this namespace match your project
namespace Rabe_Celina_HW6.DAL
{
    //NOTE: This class definition references the user class for this project.  
    //If your User class is called something other than AppUser, you will need
    //to change it in the line below
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        //TODO: Add your DbSets here.  You will need one for each model you want to store in the database
        //IMPORTANT: Do NOT add DbSets for your ViewModel classes - they are not stored in your database

        //Also, remember that Identity will add a DbSet for your User class.  It will be called Users.  
        //If you add another DbSet for users, you WILL get an error
        //create the db set

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<SupplierDetail> SupplierDetails { get; set; }



    }
}

