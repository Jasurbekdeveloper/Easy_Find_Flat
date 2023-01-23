using Find_Easy_Flat.Api.Brokers.StorageBroker;
using Find_Easy_Flat.Api.Models.Foundation.Guests;
using Find_Easy_Flat.Api.Services.Foundation.Guests;
using FluentAssertions;
using Moq;
using Tynamix.ObjectFiller;
using Xunit;

namespace Find_Easy_Flat.Api.Test.Services.Faundation.Guests
{
    public partial class GuestServiceTests
    {
        private readonly Mock<IStorageBroker> storageBrokerMock;
        private readonly IGuestService guestService;

        public GuestServiceTests()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();

            this.guestService = 
                new GuestService(storageBroker:this.storageBrokerMock.Object);
        }
       

        public static Guest CreateRandomGuest() =>
            CreateFillerGuest(GenerateRandomDate()).Create();

        private static DateTimeOffset GenerateRandomDate() =>
            new DateTimeRange(new DateTime()).GetValue();

        private static Filler<Guest> CreateFillerGuest(DateTimeOffset date)
        {
            var filler = new Filler<Guest>();

            filler.Setup()
                .OnType<DateTimeOffset>().Use(date);   
            
            return filler;
        }

    }
}
