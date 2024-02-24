using Microsoft.EntityFrameworkCore;
using AuctionProject.API.Entities;

namespace AuctionProject.API.Repositories
{
    public class AuctionDbContext : DbContext
    {
        public DbSet<Auction> Auctions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=D:\Backend\DBs\AuctionDB.db");
        }
    }
}
