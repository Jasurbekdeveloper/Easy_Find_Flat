using Find_Easy_Flat.Api.Models.Foundation.Guests;
using Microsoft.EntityFrameworkCore;

namespace Find_Easy_Flat.Api.Brokers.StorageBroker
{
    public partial class StorageBroker
    {
        public DbSet<Guest> Guests { get; set; }
    }
}
