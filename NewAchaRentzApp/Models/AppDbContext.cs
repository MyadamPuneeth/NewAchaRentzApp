using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebPagesMvc.Models;

namespace WebPagesMvc.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarExtraDetail> CarExtraDetails { get; set; }
        public DbSet<CarPhoto> CarPhotos { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Payment> Payments { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
