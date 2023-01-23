using Find_Easy_Flat.Api.Models.Foundation.Guests;

namespace Find_Easy_Flat.Api.Services.Foundation.Guests
{
    public interface IGuestService
    {
        ValueTask<Guest> AddGuestAsync(Guest guest);
    }
}
