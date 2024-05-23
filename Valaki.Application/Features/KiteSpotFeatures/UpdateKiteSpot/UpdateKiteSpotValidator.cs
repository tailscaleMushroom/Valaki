using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valaki.Application.Features.KiteSpotFeatures.UpdateKiteSpot;

 public sealed class UpdateKiteSpotValidator : AbstractValidator<UpdateKiteSpotRequest>
{
    public UpdateKiteSpotValidator() 
    {
        RuleFor(x => x.Email).NotEmpty();
        RuleFor(x => x.Name).NotEmpty();
    }
}

