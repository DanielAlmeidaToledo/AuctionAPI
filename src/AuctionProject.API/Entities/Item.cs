﻿namespace AuctionProject.API.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public int Conditiion { get; set; }
        public decimal BasePrice { get; set; }
        public int AuctionId { get; set; }
    }
}
