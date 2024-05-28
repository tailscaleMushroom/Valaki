using FluentValidation.TestHelper;
using Valaki.Application.Features.KiteSpotFeatures.CreateKiteSpot;
using Valaki.Domain.Entities;

namespace Valaki.Test.Application.CreateKiteSpot;

public class TestTest : IClassFixture<ValakiApiFactory>
{
    ValakiApiFactory factory;

    public TestTest(ValakiApiFactory fixture)
    {
        factory = fixture;
    }

    [Fact]
    public void Validate() 
    {
        
    }
}
