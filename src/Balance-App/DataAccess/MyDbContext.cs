using Microsoft.EntityFrameworkCore;
using Balance_App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Balance_App.DataAccess
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Balance> Balance { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<UserToBalance> UserToBalances { get; set; }
        public MyDbContext()
        {
            Users = this.Set<User>();
            Balance = this.Set<Balance>();
            Bills = this.Set<Bill>();
            UserToBalances = this.Set<UserToBalance>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=BalanceProjectDB;User Id=applogin;Password=12344321;");


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    Username = "admin",
                    Password = "admin",
                    FirstName = "Admin",
                    LastName = "Admin"
                });
        }
    }
}
