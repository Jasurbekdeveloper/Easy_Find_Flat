using Find_Easy_Flat.Api.Models.Foundation.Guests;
using FluentAssertions;
using Force.DeepCloner;
using Moq;
using Xunit;

namespace Find_Easy_Flat.Api.Test.Services.Faundation.Guests
{
    public partial class GuestServiceTests
    {
        [Fact]
        public async Task ShouldAddAsync()
        {
            //given
            Guest inputGuest = CreateRandomGuest();
            Guest returningGuest = inputGuest;
            Guest exceptedGuest = returningGuest.DeepClone();

            this.storageBrokerMock.Setup(storageBroker => storageBroker
            .InsertGuestAsync(inputGuest))
                .ReturnsAsync(returningGuest);

            //when

            Guest actualGuest = 
                await this.guestService.AddGuestAsync(inputGuest);

            //then

            actualGuest.Should().BeEquivalentTo(expectation:exceptedGuest);

            this.storageBrokerMock.Verify(storageBroker => storageBroker
            .InsertGuestAsync(inputGuest),Times.Once);

            this.storageBrokerMock.VerifyNoOtherCalls();    
        }
    }
}
