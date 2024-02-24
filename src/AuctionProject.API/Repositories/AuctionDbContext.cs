using Microsoft.EntityFrameworkCore;
using AuctionProject.API.Entities;

namespace AuctionProject.API.Repositories
{
    public class AuctionDbContext : DbContext
    {
        public DbSet<Auction> Auctions { get; set; }

        /*TODO - CONFIGURAR DB*/
    }
}
