using FluentValidation.TestHelper;
using Valaki.Application.Features.KiteSpotFeatures.CreateKiteSpot;
using Valaki.Domain.Entities;

namespace Valaki.Test.Application.CreateKiteSpot;

public class CreateKiteSpotValidatorTest
{
    private CreateKiteSpotValidator validator;

    private void Setup()
    {
        validator = new CreateKiteSpotValidator();
    }

    [Fact]
    public void Validate() 
    {
        var kiteSpotRequest = new CreateKiteSpotRequest();
        var result = validator.TestValidate(kiteSpotRequest);
    }
}
