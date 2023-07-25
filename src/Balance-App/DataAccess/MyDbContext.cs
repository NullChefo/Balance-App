using System;
using Microsoft.EntityFrameworkCore;
using Balance_App.Entities;
using Microsoft.Extensions.Configuration;


namespace Balance_App.DataAccess
{
    public class MyDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public MyDbContext(DbContextOptions<MyDbContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }
        
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
            string connectionString = _configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseNpgsql(connectionString);
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