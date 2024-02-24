using AuctionProject.API.Entities;
using AuctionProject.API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AuctionProject.API.UseCases.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCase
    {
        public Auction? Execute()
        {
            var repository = new AuctionDbContext();

            return repository
                .Auctions
                .Include(auction => auction.Items)
                .First();
        }
    }
}
