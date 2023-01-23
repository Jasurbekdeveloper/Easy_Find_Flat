using Find_Easy_Flat.Api.Brokers.StorageBroker;
using Find_Easy_Flat.Api.Models.Foundation.Guests;

namespace Find_Easy_Flat.Api.Services.Foundation.Guests
{
    public class GuestService : IGuestService
    {
        private readonly IStorageBroker _storageBroker;

        public GuestService(IStorageBroker storageBroker)
        {
            _storageBroker = storageBroker;
        }

        public async ValueTask<Guest> AddGuestAsync(Guest guest) =>
            await this._storageBroker.InsertGuestAsync(guest);
    }
}
