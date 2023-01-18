using Find_Easy_Flat.Api.Models.Foundation.Guests;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Find_Easy_Flat.Api.Brokers.StorageBroker
{
    public partial class StorageBroker
    {
        public DbSet<Guest> Guests { get; set; }

        public async ValueTask<Guest> InsertGuest(Guest guest)
        {
            using var broker = new StorageBroker(this.configuration);

            EntityEntry<Guest> EntityEntry =
                await broker.AddAsync(guest);

            await broker.SaveChangesAsync();
            return EntityEntry.Entity;

        }
    }
}
