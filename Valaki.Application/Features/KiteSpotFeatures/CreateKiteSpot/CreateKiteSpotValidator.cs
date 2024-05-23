using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valaki.Application.Features.KiteSpotFeatures.CreateKiteSpot
{
    public sealed class CreateKiteSpotValidator : AbstractValidator<CreateKiteSpotRequest>
    {
        public CreateKiteSpotValidator() 
        {
            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}
