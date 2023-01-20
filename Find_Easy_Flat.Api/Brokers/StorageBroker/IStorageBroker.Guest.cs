using Find_Easy_Flat.Api.Models.Foundation.Guests;

namespace Find_Easy_Flat.Api.Brokers.StorageBroker
{
    public partial interface IStorageBroker
    {
        //CRUD functions
        ValueTask<Guest> InsertGuest(Guest guest);
        //CRUD functions
        ValueTask<Guest> InsertGuestAsync(Guest guest);
    }
}
