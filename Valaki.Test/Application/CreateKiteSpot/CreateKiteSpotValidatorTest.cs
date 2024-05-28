﻿using FluentValidation.TestHelper;
using Valaki.Application.Features.KiteSpotFeatures.CreateKiteSpot;
using Valaki.Domain.Entities;

namespace Valaki.Test.Application.CreateKiteSpot;

public class CreateKiteSpotValidatorTest : IClassFixture<ValakiApiFactory>
{
    ValakiApiFactory factory;

    public CreateKiteSpotValidatorTest(ValakiApiFactory fixture)
    {
        factory = fixture;
    }

    [Fact]
    public void Validate() 
    {
        
    }
}
