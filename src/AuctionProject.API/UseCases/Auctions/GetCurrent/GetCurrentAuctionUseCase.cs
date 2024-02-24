using AuctionProject.API.Entities;
using AuctionProject.API.Repositories;

namespace AuctionProject.API.UseCases.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCase
    {
        public Auction Execute()
        {
            var repository = new AuctionDbContext();

            return repository.Auctions.First();
        }
    }
}
