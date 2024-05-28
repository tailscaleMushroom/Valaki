using FluentValidation.TestHelper;
using Valaki.Application.Features.KiteSpotFeatures.CreateKiteSpot;
using Valaki.Domain.Entities;

namespace Valaki.Test.Application.CreateKiteSpot;

public class Test : IClassFixture<ValakiApiFactory>
{
    ValakiApiFactory factory;

    public Test(ValakiApiFactory fixture)
    {
        factory = fixture;
    }

    [Fact]
    public void Validate() 
    {
        
    }
}
