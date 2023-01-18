using EFxceptions;
using Microsoft.EntityFrameworkCore;

namespace Find_Easy_Flat.Api.Brokers.StorageBroker
{
    public partial class StorageBroker : EFxceptionsContext
    {
        private readonly IConfiguration configuration;

        public StorageBroker(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConnectingString =
                this.configuration.GetConnectionString(name: "DefaultConnectingString");

            optionsBuilder.UseSqlServer(ConnectingString);
        }
        public override void Dispose() { }
    }
}
