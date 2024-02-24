using AuctionProject.API.UseCases.Auctions.GetCurrent;
using Microsoft.AspNetCore.Mvc;

namespace AuctionProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCurrentAuction()
        {
            var useCase = new GetCurrentAuctionUseCase();

            var result = useCase.Execute();

            if (result is null)
                return NoContent();

            return Ok(result);
        }
    }
}
